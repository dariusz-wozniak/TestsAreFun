using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._01_MoqMocks;

public class DefaultValue
{
    [Test]
    public void default_value()
    {
        var customerMock = new Mock<ICustomer>();
        customerMock.SetReturnsDefault("Jason");

        ICustomer customer = customerMock.Object;

        Assert.That(customer.FirstName, Is.EqualTo("Jason"));
        Assert.That(customer.LastName, Is.EqualTo("Jason"));
    }
}