using System;
using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._06_Throws;

public class ThrowsTests
{
    [Test]
    public void mock_that_throws_exception()
    {
        var customer = Mock.Of<ICustomer>();

        Mock.Get(customer).Setup(x => x.FirstName).Throws<ArgumentNullException>();

        Assert.That(() => customer.FirstName, Throws.ArgumentNullException);
    }
}