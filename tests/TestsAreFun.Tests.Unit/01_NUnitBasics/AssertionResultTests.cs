namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

public class AssertionResultTests
{
    [Test]
    public void test_is_green() { Assert.Pass(); }

    [Test]
    [Explicit("Run explicitly or remove the attribute")]
    public void test_is_red() { Assert.Fail(); }

    [Test]
    public void test_is_ignored() { Assert.Ignore(); }

    [Test]
    public void test_is_inconclusive() { Assert.Inconclusive(); }
}