using System;

namespace CvScore.Domain.Contacts
{
    public class Contact : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
