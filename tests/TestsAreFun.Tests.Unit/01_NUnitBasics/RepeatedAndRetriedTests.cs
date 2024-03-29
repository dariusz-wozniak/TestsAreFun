namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

public class RepeatedAndRetriedTests
{
    private int _retryCounter = 0;
    private int _repeatCounter = 0;

    [Test]
    [Repeat(3)]
    public void repeated()
    {
        TestContext.WriteLine($"Run #{++_repeatCounter}");
    }

    [Test]
    [Retry(20)]
    public void retry()
    {
        TestContext.WriteLine($"Run #{++_retryCounter}");

        if (_retryCounter == 20) Assert.Pass();
        Assert.Fail();
    }
}