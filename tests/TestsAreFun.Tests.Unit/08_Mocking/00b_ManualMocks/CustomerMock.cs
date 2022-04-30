using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._00b_ManualMocks;

internal class CustomerMock : ICustomer
{
    private readonly int _age;

    public CustomerMock(int age)
    {
        _age = age;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IPhoneNumber PhoneNumber { get; set; }
    public IList<IOrder> Orders { get; set; }

    public int GetAge()
    {
        return _age;
    }
}