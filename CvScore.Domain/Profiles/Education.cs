using System;

namespace CvScore.Domain.Profiles
{
    public class Education
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public string Univercity { get; set; }
        public decimal Year { get; set; }

    }
}
