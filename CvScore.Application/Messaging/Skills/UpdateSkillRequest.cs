using CvScore.MetaData;

namespace CvScore.Application.Messaging.Skills
{
    public class UpdateSkillRequest
    {
        public SkillDTO  SkillDTO { get; private set; }

        public UpdateSkillRequest(SkillDTO skillDTO)
        {
            SkillDTO = skillDTO;
        }

    }
}
