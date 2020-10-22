using GraphQL;
using GraphQL.Types;
using GraphQLEx.GraphQL.GraphQLQueries;

namespace GraphQLEx.GraphQL.GraphQLSchema
{
    public class AppSchema: Schema
    {
       public AppSchema(IDependencyResolver resolver)
            :base(resolver)
        {
             Query = resolver.Resolve<AppQuery>();
        }
    }
}
