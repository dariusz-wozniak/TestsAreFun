namespace TestsAreFun.TestDoubleCustomer;

public interface ICustomerRepository
{
    IReadOnlyList<ICustomer> AllCustomers { get; }
    void Add(ICustomer customer);
}