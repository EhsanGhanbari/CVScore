using System;

namespace CvScore.MetaData
{
    public class MessageDTO
    {
        public Guid MessageId { get; set; }
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
