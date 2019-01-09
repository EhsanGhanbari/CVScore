using System;

namespace CvScore.Domain.Messages
{
    public class Message : IAggregateRoot
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
