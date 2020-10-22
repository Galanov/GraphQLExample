using GraphQLEx.Contracts;
using GraphQLEx.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLEx.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Owner> GetAll(){
            return _context.Owners.ToList();
        }
    }
}