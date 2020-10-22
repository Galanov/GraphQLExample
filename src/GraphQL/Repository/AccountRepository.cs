using GraphQLEx.Contracts;
using GraphQLEx.Entities;

namespace GraphQLEx.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext _context;

        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}