using System.Net;
using System.Net.Http;
using System.Web.Http;
using CvScore.Application.Service.IService;

namespace CvScore.Web.Controllers
{
    public class MemberController : ApiController
    {
        private readonly IProfileService _profileService;
        private readonly ISkillService _skillService;
        private readonly IMessageService _messageService;


        public MemberController(IProfileService profileService, ISkillService skillService,
                                IMessageService messageService)
        {
            _profileService = profileService;
            _skillService = skillService;
            _messageService = messageService;
        }



        public HttpResponseMessage PutSkill()
        {
            if (ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
