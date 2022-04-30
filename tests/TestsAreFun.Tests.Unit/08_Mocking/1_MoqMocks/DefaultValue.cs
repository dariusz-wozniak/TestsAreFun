using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._1_MoqMocks;

public class DefaultValue
{
    [Test]
    public void default_value()
    {
        var customerMock = new Mock<ICustomer>();
        customerMock.SetReturnsDefault("Jason");

        ICustomer customer = customerMock.Object;

        Assert.That(customer.FirstName, Is.EqualTo("Jason"));
    }
}