using AutoFixture;
using TestsAreFun.BigObject;

namespace TestsAreFun.Tests.Unit._13_GenerateData;

public class using_auto_fixture
{
    [Test]
    public void test()
    {
        var fixture = new Fixture();

        var person = fixture.Create<Person>();

        person.Id.Should().NotBe(Guid.Empty);
    }
}