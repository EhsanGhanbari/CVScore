using System.Collections.Generic;
using CV.Application.DTO;

namespace CV.Application.Messaging.Skills
{
    public class GetAllSkillResponse
    {
        public IEnumerable<SkillDTO> SkillDtos { get; set; } 
    }
}
