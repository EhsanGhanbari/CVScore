using CV.Application.Messaging.Profiles;

namespace CV.Application.ServicePresenting
{
    public interface IProfileService
    {

        CreateProfileResponse CreateProfile(CreateProfileRequest request);

        GetProfileReponse GetProfile(GetProfileRequest request);

        RemoveProfileResponse RemoveProfile(RemoveProfileRequest request);

        UpdateProfileRespose UpdateProfile(UpdateProfileRequest request);

    }
}
