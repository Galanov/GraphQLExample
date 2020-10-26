using GraphQL.Types;
using GraphQLEx.Entities;

namespace GraphQLEx.GraphQL.GraphQLTypes
{
    public class AccountTypeEnumType: EnumerationGraphType<TypeOfAccount>
    {
        public AccountTypeEnumType()
        {
            Name = "Type";
            Description = "Enumeration for the account type object.";
        }
    }
}