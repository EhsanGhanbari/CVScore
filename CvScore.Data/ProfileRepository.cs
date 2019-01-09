using System;
using CvScore.Domain.Profiles;
using Raven.Client;

namespace CvScore.Data
{
    public class ProfileRepository : Repository<Profile, Guid>,IProfileRepository
    {
        public ProfileRepository(IDocumentSession documentSession)
            : base(documentSession)
        {
        }
    }
}
