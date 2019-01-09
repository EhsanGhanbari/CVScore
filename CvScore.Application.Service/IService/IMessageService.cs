using System.ServiceModel;
using CvScore.Application.Messaging.Messages;

namespace CvScore.Application.Service.IService
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        CreateMessageResponse CreateMessage(CreateMessageRequest request);
        
        [OperationContract]
        GetMessageResponse GetMessage(GetMessageRequest request);
        
        [OperationContract]
        GetAllMessageResponse GetAllMessage(GetAllMessageRequest request);
        
        [OperationContract]
        RemoveMessageResponse RemoveMessage(RemoveMessageRequest request);
    }
}
