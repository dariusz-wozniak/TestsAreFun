using TestsAreFun.CodeCoverage;

namespace TestsAreFun.Tests.Unit._12_CodeCoverage;

public class NumberTests
{
    [Test]
    public void number_two_should_be_even()
    {
        bool isEven = Number.IsEven(2);

        Assert.That(isEven, Is.True);
    }
}