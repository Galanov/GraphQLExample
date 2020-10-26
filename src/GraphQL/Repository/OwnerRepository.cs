using GraphQLEx.Contracts;
using GraphQLEx.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

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

        public Owner GetById(Guid id) => _context.Owners.SingleOrDefault(o => o.Id.Equals(id));
    }
}