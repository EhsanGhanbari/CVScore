using System.ServiceModel;
using CvScore.Application.Messaging.Skills;

namespace CvScore.Application.Service.IService
{
    [ServiceContract]
    public interface ISkillService
    {
        [OperationContract]
        CreateSkillResponse CreateSkill(CreateSkillRequest request);
        
        [OperationContract]
        GetSkillResponse GetSkill(GetSkillRequest request);
        
        [OperationContract]
        GetAllSkillResponse GetAllSkill(GetAllSkillRequest request);
        
        [OperationContract]
        UpdateSkillResponse UpdateSkill(UpdateSkillRequest request);

    }
}
