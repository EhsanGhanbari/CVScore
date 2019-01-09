using System;


namespace CvScore.Domain.Profiles
{
    public class Profile : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }


        public virtual Education Education { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }
        public virtual WebSite WebSite { get; set; }
    }
}
