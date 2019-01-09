using CvScore.MetaData;

namespace CvScore.Application.Messaging.Skills
{
    public class GetAllSkillRequest
    {
        internal SkillDTO SkillDTO { get; private set; }

        public GetAllSkillRequest(SkillDTO skillDTO)
        {
            SkillDTO = skillDTO;
        }
    }
}
