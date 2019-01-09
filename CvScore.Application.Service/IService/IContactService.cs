using System.ServiceModel;
using CvScore.Application.Messaging.Contacts;

namespace CvScore.Application.Service.IService
{
    [ServiceContract]
    public interface IContactService
    {
        [OperationContract]
        CreateContactResponse CreateContact(CreateContactRequest response);
        
        [OperationContract]
        GetContactResponse GetContact(GetContactRequest request);
        
        [OperationContract]
        GetAllContactResponse GetAllContact(GetAllContactRequest request);
        
        [OperationContract]
        RemoveContactResponse RemoveContact(RemoveContactRequest request);
    }
}
