using System;
using CvScore.Domain.Skills;
using Raven.Client;

namespace CvScore.Data
{
    public class SkillRepository : Repository<Skill, Guid>, ISkillRepository
    {
        public SkillRepository(IDocumentSession documentSession)
            : base(documentSession)
        {
        }
    }
}
