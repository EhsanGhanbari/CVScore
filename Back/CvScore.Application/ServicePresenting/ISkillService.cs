using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Application.Messaging.Skills;

namespace CV.Application.ServicePresenting
{
    public interface ISkillService
    {
        CreateSkillResponse CreateSkill(CreateSkillRequest request);
        GetSkillResponse GetSkill(GetSkillRequest request);
        GetAllSkillResponse GetAllSkill(GetAllSkillRequest request);
        UpdateSkillResponse UpdateSkill(UpdateSkillRequest request);

    }
}
