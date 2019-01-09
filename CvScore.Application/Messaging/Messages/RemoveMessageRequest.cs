using CvScore.MetaData;

namespace CvScore.Application.Messaging.Messages
{
    public class RemoveMessageRequest
    {
        public MessageDTO MessageDTO { get; set; }

        public RemoveMessageRequest(MessageDTO messageDTO)
        {
            MessageDTO = messageDTO;
        }
    }
}
