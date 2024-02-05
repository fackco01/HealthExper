using AutoMapper;
using BussinessObject.Model.ModelUser;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using HealthExpertAPI.DTO.DTOAccount;
using HealthExpertAPI.Extension.ExAccount;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthExpertAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _repository = new AccountRepository();
        private readonly HealthServices service = new HealthServices();

        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AccountController(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }

        // Register
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(AccountRegistrationDTO accountDTO)
        {
            if (accountDTO == null)
            {
                return BadRequest("Account Exist!!");
            }

            //var account = _mapper.Map<Account>(accountDTO);
            //account.isActive = true;
            //account.roleId = 4;

            Account account = new()
            {
                userName = accountDTO.userName,
                password = accountDTO.password,
                email = accountDTO.email,
                phone = accountDTO.phone,
                fullName = accountDTO.fullName,
                gender = accountDTO.gender,
                birthDate = accountDTO.birthDate,
                roleId = accountDTO.roleId = 4,
                isActive = accountDTO.isActive = true
            };

            _repository.AddAccount(account);
            return Ok();
        }

        //Vỉew Account
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<List<AccountDTO>> GetListAccount()
        {
            var accountList = _repository.GetListAccount().Select(account => account.ToAccountDTO());
            return Ok(accountList);
            //return Ok(accountList.Select(account => _mapper.Map<AccountDTO>(account)));
        }

        //Get Account by Id
        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult<AccountDTO> GetAccountById(Guid id)
        {
            var account = _repository.GetAccountById(id);
            if (account == null || !account.isActive)
            {
                return NotFound();
            }
            return Ok(account.ToAccountDTO());
        }

        //Update Account
        [AllowAnonymous]
        [HttpPut("{id}")]
        public ActionResult UpdateAccount(Guid id, AccountUpdateDTO accountDTO)
        {
            var account = _repository.GetAccountById(id);
            if (account == null || !account.isActive)
            {
                return NotFound();
            }
            account = accountDTO.ToAccountUpdate();
            _repository.UpdateAccount(id, account);
            return NoContent();
        }

        //Delete Account when change isActive = false
        [AllowAnonymous]
        [HttpDelete("{id}")]
        public ActionResult DeleteAccount(Guid id)
        {
            var account = _repository.GetAccountById(id);
            if (account == null || !account.isActive)
            {
                return NotFound();
            }
            account.isActive = false;
            _repository.UpdateAccount(id, account);
            return NoContent();
        }
    }
}
