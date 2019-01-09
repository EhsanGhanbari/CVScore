using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Application.Messaging.Messages
{
    public class GetAllMessageRequest
    {
        public Guid UserId { get; set; }
    }
}
