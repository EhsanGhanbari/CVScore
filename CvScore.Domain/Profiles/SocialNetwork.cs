using System;

namespace CvScore.Domain.Profiles
{
    public class SocialNetwork 
    {
        public Guid Id { get; set; }
        public string Twitter { get; set; }
        public string FaceBook { get; set; }
        public string LinkedIn { get; set; }
        public string GooglePlus { get; set; }
    }
}
