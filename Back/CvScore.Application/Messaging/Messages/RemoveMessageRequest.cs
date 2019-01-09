using CV.Application.DTO;

namespace CV.Application.Messaging.Messages
{
    public class RemoveMessageRequest
    {
        internal MessageDTO MessageDTO { get; set; }

        public RemoveMessageRequest(MessageDTO messageDTO)
        {
            MessageDTO = messageDTO;
        }
    }
}
