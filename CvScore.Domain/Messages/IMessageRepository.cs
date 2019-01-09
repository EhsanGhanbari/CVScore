using System;

namespace CvScore.Domain.Messages
{
    public interface IMessageRepository :IRepository<Message,Guid>
    {
    }
}
