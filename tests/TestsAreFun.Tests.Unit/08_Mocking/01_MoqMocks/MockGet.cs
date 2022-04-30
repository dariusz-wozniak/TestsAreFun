using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._01_MoqMocks;

public class MockGet
{
    [Test]
    public void mock_get()
    {
        ICustomer customer = Mock.Of<ICustomer>(x => x.FirstName == "John");

        Mock<ICustomer> customerMock = Mock.Get(customer);
        customerMock.Setup(x => x.FirstName).Returns("Jason");

        Assert.That(customer.FirstName, Is.EqualTo("Jason"));
    }
}