using System;

namespace CvScore.Domain.Skills
{
    public class Skill : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }

        public long Score { get; set; }

    }
}
