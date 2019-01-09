using CvScore.Domain.Contacts;
using Raven.Client;

namespace CvScore.Data
{
    public class ContactRepository : Repository<Contact, int>, IContactRepository
    {
        public ContactRepository(IDocumentSession documentSession)
            : base(documentSession)
        {
        }
    }
}
