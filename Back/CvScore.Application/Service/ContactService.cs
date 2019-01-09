using System;
using CV.Application.Mappers;
using CV.Application.Messaging.Contacts;
using CV.Application.ServicePresenting;
using CV.Repository.UnitOfWork;
using CV.Model.Contacts;

namespace CV.Application.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IContactRepository contactRepository, IUnitOfWork unitOfWork)
        {
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
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
            _unitOfWork.Commit();
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
            _unitOfWork.Commit();
            return response;
        }
    }
}
