using System.ServiceModel;
using CvScore.Application.Messaging.Profiles;

namespace CvScore.Application.Service.IService
{
    [ServiceContract]
    public interface IProfileService
    {

        [OperationContract]
        CreateProfileResponse CreateProfile(CreateProfileRequest request);

        [OperationContract]
        GetProfileReponse GetProfile(GetProfileRequest request);

        [OperationContract]
        RemoveProfileResponse RemoveProfile(RemoveProfileRequest request);

        [OperationContract]
        UpdateProfileRespose UpdateProfile(UpdateProfileRequest request);

    }
}
