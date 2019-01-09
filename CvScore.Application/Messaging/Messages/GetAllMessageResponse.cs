using System.Collections.Generic;
using CvScore.MetaData;

namespace CvScore.Application.Messaging.Messages
{
    public class GetAllMessageResponse
    {
        public IEnumerable<MessageDTO> MessageDTO { get; set; } 
    }
}
