using System.Linq;
using NUnit.Framework.Interfaces;

namespace TestsAreFun.Tests.Unit._11_Extensibility.Database;

internal class DB
{
    public static readonly string DatabaseKey = "database";

    public static IDatabase GetDatabase(TestContext context)
    {
        return GetDatabase(context.Test.Properties);
    }

    private static IDatabase GetDatabase(TestContext.PropertyBagAdapter properties)
    {
        return properties[DatabaseKey].Cast<IDatabase>().Single();
    }

    public static IDatabase GetDatabase(ITest test)
    {
        return GetDatabase(test.Properties);
    }

    private static IDatabase GetDatabase(IPropertyBag propertyBag)
    {
        return propertyBag[DatabaseKey].Cast<IDatabase>().Single();
    }
}