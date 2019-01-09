using CV.Application.DTO;

namespace CV.Application.Messaging.Profiles
{
    public class GetProfileRequest
    {
        internal ProfileDTO ProfileDTO { get; set; }

        public GetProfileRequest(ProfileDTO profileDTO)
        {
            ProfileDTO = profileDTO;
        }
    }

}
