using TestsAreFun.TestDoubleCustomer;

// ReSharper disable CommentTypo

namespace TestsAreFun.Tests.Unit._08_Mocking._00a_TestDoubles;

public class TestDoubleTests
{
    /// <summary>
    /// Dummy (z ang. imitacja, marionetka) jest najprostszą z atrap, gdyż…
    /// nie robi absolutnie nic! Jego zadaniem jest tylko i wyłącznie spełnienie założeń sygnatury.
    /// </summary>
    [Test]
    public void dummy()
    {
        string firstName = null;

        // Dummy:
        string lastName = It.IsAny<string>();

        Assert.That(() => new TestDoubleCustomer.Customer(firstName, lastName), Throws.ArgumentNullException);
    }

    /// <summary>
    /// Stub (z ang. zalążek) to nieco bardziej zaawansowany dummy. Dodatkowo jednak, stub potrafi zwracać zdefiniowane przez nas wartości, o ile o nie poprosimy.
    /// Stub też nie wyrzuci błędu, jeśli nie zdefiniowaliśmy danego stanu (np. metody void są puste, a niezdefiniowane wartości wyjścia zwracają wartości domyślne).
    /// </summary>
    [Test]
    public void stub()
    {
        var customerValidator = new IsCustomerAdultValidator();

        // Stub:
        var customer = Mock.Of<ICustomer>(c => c.GetAge() == 21);

        bool validated = customerValidator.Validate(customer);

        Assert.That(validated, Is.True);
    }

    /// <summary>
    /// Fake (z ang. podróbka, falsyfikat) jest z kolei wariancją stuba i ma na celu symulowanie bardziej złożonych interakcji.
    /// Jeśli atrapa posiada złożone interakcje, której symulacja przy pomocy stuba jest niewykonalna (ograniczenia frameworka)
    /// lub bardzo złożona, możemy wykorzystać fake‘a. Jest to z reguły własnoręcznie napisana klasa, która posiada minimalną
    /// funkcjonalność aby spełnić założenia interakcji.
    /// </summary>
    [Test]
    public void fake()
    {
        // Fake:
        var customerRepository = new FakeCustomerRepository();

        customerRepository.Add(Mock.Of<ICustomer>(c =>
            c.FirstName == "John" &&
            c.LastName == "Kowalski"));

        customerRepository.Add(Mock.Of<ICustomer>(c => 
            c.FirstName == "Steve" && 
            c.LastName == "Jablonsky"));

        var customerReportingService = new CustomerReportingService(customerRepository);

        string report = customerReportingService.GenerateReport();

        Assert.That(report, Is.EqualTo("John Kowalski\nSteve Jablonsky"));
    }

    /// <summary>
    /// Mock (z ang. imitacja, atrapa) potrafi weryfikować zachowanie obiektu testowanego.
    /// Jego celem jest sprawdzenie czy dana składowa została wykonana.
    /// </summary>
    [Test]
    public void mock()
    {
        var customerValidator = new IsCustomerAdultValidator();

        // Mock:
        var customer = Mock.Of<ICustomer>(c => c.GetAge() == 21);

        customerValidator.Validate(customer);

        // Weryfikacja mocka:
        Mock.Get(customer).Verify(x => x.GetAge());
    }

    /// <summary>
    /// Spy (z ang. szpieg) to mock z dodatkową funkcjonalnoscią. O ile mock rejestrował czy
    /// dana składowa została wywołana, to spy sprawdza dodatkowo ilość wywołań.
    /// </summary>
    [Test]
    public void spy()
    {
        var customerValidator = new IsCustomerAdultValidator();

        // Spy:
        var customer = Mock.Of<ICustomer>(c => c.GetAge() == 21);

        customerValidator.Validate(customer);

        // Weryfikacja spy:
        Mock.Get(customer).Verify(x => x.GetAge(), Times.Once);
    }
}