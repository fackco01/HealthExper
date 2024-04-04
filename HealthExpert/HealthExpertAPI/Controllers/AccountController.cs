﻿using AutoMapper;
using BussinessObject.ContextData;
using BussinessObject.Model.ModelUser;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using HealthExpertAPI.DTO.DTOAccount;
using HealthExpertAPI.Extension.ExAccount;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace HealthExpertAPI.Controllers
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _repository = new AccountRepository();
        private readonly HealthServices service = new HealthServices();
        private readonly HealthExpertContext _context = new HealthExpertContext();

        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AccountController(IConfiguration configuration, IMapper mapper, HealthExpertContext context)
        {
            _configuration = configuration;
            _mapper = mapper;
            _context = context;
        }

        // Register
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(AccountRegistrationDTO accountDTO)
        {
            if (_context.accounts.Any(a => a.email == accountDTO.email))
            {
                return BadRequest("Account Exist!!");
            }

            CreatedPasswordHash(accountDTO.password,
                out byte[] passwordHash,
                out byte[] passwordSalt);

            Account account = accountDTO.ToAccountRegister(passwordHash, passwordSalt);
            account.verificationToken = CreateRandomToken();
            account.fullName = accountDTO.userName;
            account.phone = "0123456789";
            account.gender = true;
            account.roleId = 4;
            account.isActive = true;

            _repository.AddAccount(account);
            return Ok("Account successfully register!!");
        }

        //forgot password
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(string username)
        {
            var account = await _context.accounts.FirstOrDefaultAsync(u => u.userName == username);
            if (account == null && !account.isActive)
            {
                return BadRequest("User not found.");
            }

            account.passwordResetToken = CreateRandomToken();
            account.resetTokenExpires = DateTime.Now.AddDays(1);
            await _context.SaveChangesAsync();

            return Ok("You may now reset your password.");
        }

        //Reset password
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResettPassword(ResetPasswordDTO resetPasswordDTO)
        {
            var account = await _context.accounts.FirstOrDefaultAsync(u => u.passwordResetToken == resetPasswordDTO.token);
            if (account == null && !account.isActive || account.resetTokenExpires < DateTime.Now)
            {
                return BadRequest("Invalid Token.");
            }

            CreatedPasswordHash(resetPasswordDTO.password, out byte[] passwordHash, out byte[] passwordSalt);

            account.passwordHash = passwordHash;
            account.passwordSalt = passwordSalt;
            account.passwordResetToken = null;
            account.resetTokenExpires = null;

            await _context.SaveChangesAsync();

            return Ok("Password successfully reset.");
        }

        //Vỉew Account
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<List<AccountDTO>> GetListAccount()
        {
            var accountList = _repository.GetListAccount().Select(account => account.ToAccountDTO());
            return Ok(accountList);
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
        [HttpPost("{id}")]
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

        //Create Password Hash
        private void CreatedPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac
                    .ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        //Create Random Token
        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }

        //Get accountId by userName
        [AllowAnonymous]
        [HttpGet("{userName}")]
        public ActionResult GetAccountIdByUserName(string userName)
        {
            var account = _repository.GetAccountId(userName);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }
    }
}
