using GraphQL.Types;
using GraphQLEx.Contracts;
using GraphQLEx.GraphQL.GraphQLTypes;

namespace GraphQLEx.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IOwnerRepository repository)
        {
            Field<ListGraphType<OwnerType>>(
            "owners",
            resolve: context => repository.GetAll()
        );
        }
    }
}