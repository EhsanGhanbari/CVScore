using CvScore.MetaData;

namespace CvScore.Application.Messaging.Messages
{
    public class GetMessageRequest
    {
        public MessageDTO MessageDTO { get; private set; }

        public GetMessageRequest(MessageDTO messageDTO)
        {
            MessageDTO = messageDTO;
        }
    }
}
