using TestsAreFun.PersonWithHeight;

namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

public class PersonWithHeightTests
{
    [Test]
    public void when_two_persons_have_different_heights_than_they_are_different()
    {
        var comparer = new PersonByHeightComparer();

        Assert
            .That(Person.WithHeigthInCentimeters(170),
                Is.LessThan(Person.WithHeigthInCentimeters(180))
                    .Using(comparer));
    }
}