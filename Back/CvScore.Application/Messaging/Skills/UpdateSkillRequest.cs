using CV.Application.DTO;

namespace CV.Application.Messaging.Skills
{
    public class UpdateSkillRequest
    {
        internal SkillDTO  SkillDTO { get; private set; }

        public UpdateSkillRequest(SkillDTO skillDTO)
        {
            SkillDTO = skillDTO;
        }

    }
}
