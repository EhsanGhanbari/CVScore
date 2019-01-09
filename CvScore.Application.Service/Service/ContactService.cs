using CvScore.Application.Mappers;
using CvScore.Application.Messaging.Contacts;
using CvScore.Application.Service.IService;
using CvScore.Domain.Contacts;

namespace CvScore.Application.Service.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        /// <summary>
        /// Create Contact Method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateContactResponse CreateContact(CreateContactRequest request)
        {
            var response = new CreateContactResponse();
            var contact = response.ContactView.ConvertToContactModel();
            _contactRepository.Add(contact);
            return response;

        }

        public GetContactResponse GetContact(GetContactRequest request)
        {
            var response = new GetContactResponse();
            var contactView = _contactRepository.FindBy(request.ContactId);
             contactView.ConvertToContactView();
            return response;
        }


        /// <summary>
        /// GetAll made contact
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllContactResponse GetAllContact(GetAllContactRequest request)
        {
            var response = new GetAllContactResponse();
            var contactViewList = _contactRepository.FindAll();
            contactViewList.ConvertToContactViewList();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveContactResponse RemoveContact(RemoveContactRequest request)
        {
            var response = new RemoveContactResponse();
            var contact = new Contact {Id = request.ContactId};
            _contactRepository.Remove(contact);
            return response;
        }
    }
}
