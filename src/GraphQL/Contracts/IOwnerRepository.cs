using GraphQLEx.Entities;
using System.Collections.Generic;

namespace GraphQLEx.Contracts
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
    }
}