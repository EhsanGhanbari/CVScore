using System;
using CvScore.Application.Messaging.Profiles;
using CvScore.Application.Service.IService;
using CvScore.Domain.Profiles;

namespace CvScore.Application.Service.Service
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }


        /// <summary>
        /// Createa Profile 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var response = new CreateProfileResponse();


            return response;
        }

        /// <summary>
        /// Get Profile
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetProfileReponse GetProfile(GetProfileRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Remove Profile??
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveProfileResponse RemoveProfile(RemoveProfileRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update Profile
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateProfileRespose UpdateProfile(UpdateProfileRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
