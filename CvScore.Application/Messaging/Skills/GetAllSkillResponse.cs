using System.Collections.Generic;
using CvScore.MetaData;

namespace CvScore.Application.Messaging.Skills
{
    public class GetAllSkillResponse
    {
        public IEnumerable<SkillDTO> SkillDtos { get; set; } 
    }
}
