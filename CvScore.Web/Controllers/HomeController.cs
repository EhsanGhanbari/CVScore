using System.Net;
using System.Net.Http;
using System.Web.Http;
using CvScore.Application.Messaging.Contacts;
using CvScore.Application.Service.IService;
using CvScore.MetaData;

namespace CvScore.Web.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IContactService _contactService;

        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }


        /// <summary>
        /// Contact 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage PostContactMessage(ContactDTO contactDTO)
        {
            var request = new CreateContactRequest(contactDTO);
           
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            _contactService.CreateContact(request);
         
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, contactDTO);
     
            return response;
        }

    }
}