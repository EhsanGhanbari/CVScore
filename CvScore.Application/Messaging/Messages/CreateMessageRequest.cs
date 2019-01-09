using CvScore.MetaData;

namespace CvScore.Application.Messaging.Messages
{
    public class CreateMessageRequest
    {
        public MessageDTO MessageDTO { get; private set; }

        public CreateMessageRequest(MessageDTO messageDTO)
        {
            MessageDTO = messageDTO;
        }
    }
}
