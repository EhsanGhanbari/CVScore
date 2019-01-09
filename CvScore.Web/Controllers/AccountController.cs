using System.Web.Http;
using CvScore.Application.Service.IService;

namespace CvScore.Web.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }




    }
}
