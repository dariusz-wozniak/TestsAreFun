using TestsAreFun.PersonWithPesel;

namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

public class PersonWithPeselTests
{
    [Test]
    public void when_two_persons_have_the_same_pesel_number_then_they_are_equal()
    {
        var comparer = new PersonByPeselEqualityComparer();

        Assert
            .That(Person.WithPesel("78111711616"),
                Is.EqualTo(Person.WithPesel("78111711616"))
                    .Using(comparer));
    }
}