using CvScore.MetaData.Profiles;

namespace CvScore.Application.Messaging.Profiles
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
