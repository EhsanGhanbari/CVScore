using System;
using CV.Application.Messaging.Profiles;
using CV.Application.ServicePresenting;
using CV.Repository.UnitOfWork;
using CV.Model.Profiles;

namespace CV.Application.Service
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProfileService(IProfileRepository profileRepository, IUnitOfWork unitOfWork)
        {
            _profileRepository = profileRepository;
            _unitOfWork = unitOfWork;
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
