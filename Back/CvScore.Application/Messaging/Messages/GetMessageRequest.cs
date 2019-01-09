using CV.Application.DTO;

namespace CV.Application.Messaging.Messages
{
    public class GetMessageRequest
    {
        internal MessageDTO MessageDTO { get; private set; }

        public GetMessageRequest(MessageDTO messageDTO)
        {
            MessageDTO = messageDTO;
        }
    }
}
