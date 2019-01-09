using CvScore.MetaData;

namespace CvScore.Application.Messaging.Skills
{
    public class GetSkillRequest
    {
        public SkillDTO SkillDTO { get; private set; }

        public GetSkillRequest(SkillDTO skillDTO)
        {
            SkillDTO = skillDTO;
        }
    }
}
