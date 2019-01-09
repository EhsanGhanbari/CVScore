using CV.Application.Mappers;
using CV.Application.Messaging.Skills;
using CV.Application.ServicePresenting;
using CV.Repository.UnitOfWork;
using CV.Model.Skills;

namespace CV.Application.Service
{
    public class SkillService :ISkillService
    {
        private readonly ISkillRepository  _skillRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SkillService(ISkillRepository skillRepository, IUnitOfWork unitOfWork)
        {
            _skillRepository = skillRepository;
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// Create Skill by Users
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateSkillResponse CreateSkill(CreateSkillRequest request)
        {
            var response = new CreateSkillResponse();
            var skill = request.SkillDTO.ConvertToSkillModel();
            _skillRepository.Add(skill);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Get Skill By it's Identity 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetSkillResponse GetSkill(GetSkillRequest request)
        {
            var response = new GetSkillResponse();
            var skill = _skillRepository.FindBy(request.SkillDTO.SkillId);
            response.SkillDTO = skill.ConvertToSkillDTO();
            return response;
        }



        /// <summary>
        /// get All Skills persisted in system 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllSkillResponse GetAllSkill(GetAllSkillRequest request)
        {
            var response = new GetAllSkillResponse();
            var skills = _skillRepository.FindAll();
            response.SkillDtos = skills.ConvertToSkillDTOList();
            return response;
        }


        /// <summary>
        /// Updates the Skill 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateSkillResponse UpdateSkill(UpdateSkillRequest request)
        {
            var response = new UpdateSkillResponse();
            var skill = request.SkillDTO.ConvertToSkillModel();
            _skillRepository.Save(skill);
            _unitOfWork.Commit();
            return response;
        }
    }
}
