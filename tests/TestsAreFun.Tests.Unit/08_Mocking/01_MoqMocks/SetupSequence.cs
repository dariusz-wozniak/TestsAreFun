using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._01_MoqMocks;

public class SetupSequence
{
    [Test]
    public void sequential_mock()
    {
        var customerMock = new Mock<ICustomer>();
        customerMock.SetupSequence(x => x.FirstName)
            .Returns("John")
            .Returns("Jason")
            .Returns("Adam");

        ICustomer customer = customerMock.Object;

        Assert.That(customer.FirstName, Is.EqualTo("John"));
        Assert.That(customer.FirstName, Is.EqualTo("Jason"));
        Assert.That(customer.FirstName, Is.EqualTo("Adam"));
        Assert.That(customer.FirstName, Is.Null);
    }
}