using CvScore.MetaData;

namespace CvScore.Application.Messaging.Skills
{
    public class CreateSkillRequest
    {
        public SkillDTO SkillDTO { get; private set; }

        public CreateSkillRequest(SkillDTO skillDTO)
        {
            SkillDTO = skillDTO;
        }
    }
}
