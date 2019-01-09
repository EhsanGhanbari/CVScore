using CV.Application.DTO;

namespace CV.Application.Messaging.Messages
{
    public class CreateMessageRequest
    {
        internal MessageDTO MessageDTO { get; private set; }

        public CreateMessageRequest(MessageDTO messageDTO)
        {
            MessageDTO = messageDTO;
        }
    }
}
