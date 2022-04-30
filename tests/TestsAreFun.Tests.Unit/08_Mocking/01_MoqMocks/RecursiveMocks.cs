using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._01_MoqMocks;

public class RecursiveMocks
{
    [Test]
    public void recursive_mock__imperative_syntax()
    {
        var customerMock = new Mock<ICustomer>();
        customerMock.Setup(x => x.PhoneNumber.Mobile).Returns("123-456-789");

        Assert.That(customerMock.Object.PhoneNumber.Mobile, Is.EqualTo("123-456-789"));
    }

    [Test]
    public void recursive_mock__declarative_syntax()
    {
        var customer = Mock.Of<ICustomer>(x => x.PhoneNumber.Mobile == "123-456-789");

        Assert.That(customer.PhoneNumber.Mobile, Is.EqualTo("123-456-789"));
    }
}