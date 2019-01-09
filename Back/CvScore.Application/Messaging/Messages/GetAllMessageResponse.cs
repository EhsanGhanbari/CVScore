using System.Collections.Generic;
using CV.Application.DTO;

namespace CV.Application.Messaging.Messages
{
    public class GetAllMessageResponse
    {
        public IEnumerable<MessageDTO> MessageDTO { get; set; } 
    }
}
