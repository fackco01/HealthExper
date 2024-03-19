using BussinessObject.Model.ModelPayment;
using HealthExpertAPI.DTO.DTOOrder;

namespace HealthExpertAPI.Extension.ExOrder
{
    public static class OrderExtension
    {
        public static OrderDTO ToOrderDTO(this Order order)
        {
            return new OrderDTO
            {
                orderId = order.orderId,
                orderTime = order.orderTime,
                price = order.price,
                discount = order.discount,
                accountId = order.accountId,
                courseId = order.courseId,
            };
        }

        public static Order ToCreateOrder(this CreateOrderDTO orderDTO)
        {
            return new Order
            {
                orderTime = orderDTO.orderTime,
                price = orderDTO.price,
                discount = orderDTO.discount,
                accountId = orderDTO.accountId,
                courseId = orderDTO.courseId,
            };
        }
    }
}
