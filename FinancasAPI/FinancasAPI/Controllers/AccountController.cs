using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Entities.Factory;
using FinancasAPI.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinancasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly AccountFactory _factory;
        
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
            _factory = new AccountFactory();
        }

        [HttpPost]

        public IActionResult CreateAccountt(object newAccountObj)
        {
            try
            {
                var newAccount = _factory.CreateAccount(newAccountObj);
                _accountService.CreateAccount(newAccount);
                
                return Ok("Conta criada com sucesso");

            }
            catch(Exception ex)
            {
                return Problem($"Message: {ex.Message}\nInnerException: {ex.InnerException}\nStack: {ex.StackTrace}");
            }
        }

        [HttpPut]
        public IActionResult UpdateAccount(AccountModel account)
        {
            try
            {
                _accountService.UpdateAccount(account);
                return Ok("Conta atualizada com sucesso");

            }
            catch (Exception ex)
            {
                return Problem($"Message: {ex.Message}\nInnerException: {ex.InnerException}\nStack: {ex.StackTrace}");
            }
        }

        [HttpDelete]
        public IActionResult DeleteAccount(int accountId)
        {
            try
            {
                _accountService.DeleteAccount(accountId);
                return Ok("Conta deletado com sucesso");

            }
            catch (Exception ex)
            {
                return Problem($"Message: {ex.Message}\nInnerException: {ex.InnerException}\nStack: {ex.StackTrace}");
            }
        }

    }
}
