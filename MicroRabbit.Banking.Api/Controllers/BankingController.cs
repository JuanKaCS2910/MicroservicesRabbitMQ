using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
	[Route("api/[controller]")]
	public class BankingController : ControllerBase
	{
		private readonly IAccountRepository _accountRepository;

		public BankingController(IAccountRepository accountRepository)
		{
			_accountRepository = accountRepository;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Account>> Get()
		{
			return Ok(_accountRepository.GetAccounts());
		}
	}
}
