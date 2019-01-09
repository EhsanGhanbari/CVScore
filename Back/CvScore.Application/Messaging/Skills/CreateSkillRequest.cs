using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Application.DTO;

namespace CV.Application.Messaging.Skills
{
    public class CreateSkillRequest
    {
        internal SkillDTO SkillDTO { get; private set; }

        public CreateSkillRequest(SkillDTO skillDTO)
        {
            SkillDTO = skillDTO;
        }
    }
}
