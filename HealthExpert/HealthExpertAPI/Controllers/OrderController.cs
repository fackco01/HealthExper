using BussinessObject.ContextData;
using BussinessObject.Model.ModelPayment;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using HealthExpertAPI.DTO.DTOOrder;
using HealthExpertAPI.Extension.ExOrder;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HealthExpertAPI.Controllers
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repository = new OrderRepository();
        private readonly HealthExpertContext _context;
        private static readonly Random random = new Random();
        private static List<CheckoutDTO> _checkoutDataList = new List<CheckoutDTO>();

        private readonly IVnPayService _service;
        private readonly IConfiguration _configuration;

        public OrderController(IVnPayService service, IConfiguration configuration, HealthExpertContext context)
        {
            _configuration = configuration;
            _service = service;
            _context = context;
        }

        //Get List Order
        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<OrderDTO>> GetOrders()
        {
            var orderList = _repository.GetAllOrders();
            return Ok(orderList);
        }

        //View Checkout Order By Id
        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<OrderDTO> GetOrderById(Guid id)
        {
            var order = _repository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order.ToOrderDTO());
        }

        //Add to Order
        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOrder(CreateOrderDTO orderDTO)
        {
            var courseExists = _context.courses.Any(c => c.courseId == orderDTO.courseId);
            var accountExists = _context.accounts.Any(a => a.accountId == orderDTO.accountId);

            if (!courseExists || !accountExists)
            {
                return BadRequest("Course or account not found.");
            }

            var course = _context.courses.SingleOrDefault(c => c.courseId == orderDTO.courseId);
            var account = _context.accounts.SingleOrDefault(account => account.accountId == orderDTO.accountId);


            Order order = orderDTO.ToCreateOrder();

            order.price = (decimal?)Convert.ToDouble(course.price);

            _repository.AddOrder(order);
            _context.SaveChanges();

            var checkoutData = new CheckoutDTO
            {
                price = order.price,
                orderId = order.orderId,
                accountId = order.accountId,
                courseId = order.courseId
            };

            _checkoutDataList.Add(checkoutData);

            return Ok(order);
        }

        //Remove Order
        [AllowAnonymous]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult RemoveOrder(Guid id)
        {
            var order = _repository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            _repository.DeleteOrder(id);
            _context.SaveChanges();
            return Ok(order);
        }

        //Checkout Order
        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult CheckoutOrder(string payment = "VnPay")
        {
            if (_checkoutDataList.Count == 0)
            {
                return BadRequest("No checkout data available");
            }

            var checkoutData = _checkoutDataList[_checkoutDataList.Count - 1];

            if (payment != "VnPay")
            {
                return BadRequest("Invalid payment method");
            }

            var vnPayModel = new PaymentRequest
            {
                orderId = checkoutData.orderId,
                fullName = checkoutData.name,
                description = "Payment for order: " + checkoutData.orderId,
                amount = (double)checkoutData.price,
                createdDate = DateTime.Now
            };

            var paymentUrl = _service.CreatePaymentUrl(HttpContext, vnPayModel);
            return Ok(paymentUrl);
        }

    }
}
