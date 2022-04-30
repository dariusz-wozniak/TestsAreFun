using System.Linq;

namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

public class TestsWithContext
{
    [Test]
    [Author(name: "Jan Kowalski", email: "jan.kowalski@buziaczek.pl")]
    [Description("This is a test for showcasing usage of NUnit attributes")]
    public void informative_test()
    {
        TestContext.TestAdapter test = TestContext.CurrentContext.Test;

        string author = test.Properties["Author"].Cast<string>().Single();
        // author = Jan Kowalski <jan.kowalski@buziaczek.pl>

        string description = test.Properties["Description"].Cast<string>().Single();
        // description = This is a test for showcasing usage of NUnit attributes
    }
}