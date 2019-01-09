using CV.Application.DTO;

namespace CV.Application.Messaging.Profiles
{
    public class CreateProfileRequest
    {
        internal ProfileDTO ProfileDTO { get; set; }

        public CreateProfileRequest(ProfileDTO profileDTO)
        {
            ProfileDTO = profileDTO;
        }
    }
}
