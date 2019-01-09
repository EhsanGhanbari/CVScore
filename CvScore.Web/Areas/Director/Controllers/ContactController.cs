using System.Web.Http;
using CvScore.Application.Service.IService;

namespace CvScore.Web.Areas.Director.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


    }
}
