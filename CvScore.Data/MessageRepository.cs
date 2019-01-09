using CvScore.Domain.Messages;
using Raven.Client;

namespace CvScore.Data
{
    public class MessageRepository : Repository<Message, int>,IMessageRepository
    {
        public MessageRepository(IDocumentSession documentSession)
            : base(documentSession)
        {
        }
    }
}
