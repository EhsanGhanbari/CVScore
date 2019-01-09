using CV.Application.Messaging.Contacts;

namespace CV.Application.ServicePresenting
{
    public interface IContactService
    {
        CreateContactResponse CreateContact(CreateContactRequest response);
        GetContactResponse GetContact(GetContactRequest request);
        GetAllContactResponse GetAllContact(GetAllContactRequest request);
        RemoveContactResponse RemoveContact(RemoveContactRequest request);
    }
}
