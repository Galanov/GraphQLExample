using GraphQLEx.Entities;
using System.Collections.Generic;
using System;

namespace GraphQLEx.Contracts
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(Guid id);
        Owner CreateOwner(Owner owner);

        Owner UpdateOwner(Owner dbOwner, Owner owner);

        void DeleteOwner(Owner owner);
    }
}