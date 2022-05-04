using System.Linq;
using Bogus;
using TestsAreFun.BigObject;
using Person = TestsAreFun.BigObject.Person;

namespace TestsAreFun.Tests.Unit._13_GenerateData;

public class using_bogus
{
    [Test]
    public void test()
    {
        var faker = new Faker<Person>()
            .StrictMode(ensureRulesForAllProperties: true)
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Born, f => f.Date.Past(50))
            .RuleFor(p => p.LivingCity, f => new City(f.Address.City(), new Country(f.Address.Country())))
            .RuleFor(p => p.BirthCity, f => new City(f.Address.City(), new Country(f.Address.Country())))
            .RuleFor(p => p.Citizenship, f => new Country(f.Address.Country()));

        var persons = faker.Generate(10);

        persons.Should().HaveCount(10);
        persons.Distinct().Should().HaveCount(10);
    }
}