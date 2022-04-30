namespace TestsAreFun.Tests.Unit._10_FluentAssertions;

public class FluentAssertionTests
{
    [Test]
    public void some_simple_tests()
    {
        const string firstName = "Kunegunda";

        Assert.Multiple(() =>
        {
            firstName.Should().Be("Kunegunda");

            firstName.Should()
                .StartWith("Ku")
                .And.EndWith("da")
                .And.Contain("gun");
        });
    }
}