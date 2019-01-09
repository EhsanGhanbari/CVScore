using CV.Application.DTO;

namespace CV.Application.Messaging.Contacts
{
    public class CreateContactRequest
    {
        internal ContactDTO ContactDTO { get; set; }

        public CreateContactRequest(ContactDTO contactDTO)
        {
            ContactDTO = contactDTO;
        }
    }
}
