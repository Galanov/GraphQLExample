using GraphQL.Contracts;
using GraphQL.Entities;

namespace GraphQL.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}