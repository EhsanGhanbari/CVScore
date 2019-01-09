using CvScore.MetaData;

namespace CvScore.Application.Messaging.Contacts
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
