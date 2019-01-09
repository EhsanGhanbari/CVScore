
using CvScore.MetaData;

namespace CvScore.Application.Messaging.Contacts
{
    public class CreateContactResponse:BaseResponse
    {
        public ContactDTO ContactView { get; set; }
    }
}
