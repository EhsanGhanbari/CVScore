using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Application.DTO;

namespace CV.Application.Messaging.Contacts
{
    public class CreateContactResponse:BaseResponse
    {
        public ContactDTO ContactView { get; set; }
    }
}
