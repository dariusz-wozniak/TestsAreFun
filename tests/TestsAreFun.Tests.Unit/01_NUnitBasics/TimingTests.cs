using System.Threading;

namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

public class TimingTests
{
    [Test]
    [Explicit]
    [Timeout(1000)]
    public void timeout()
    {
        for (int i = 1; i < 10; ++i)
        {
            TestContext.WriteLine($"Run #{i}");
            Thread.Sleep(250);
        }

        Assert.Pass();
    }

    /// <summary>
    /// This attribute does not cancel the test if the time is exceeded.
    /// It merely waits for the test to complete and then compares the elapsed time to the specified maximum.
    /// If you want to cancel long-running tests, see Timeout Attribute.
    /// </summary>
    [Test]
    [Explicit]
    [MaxTime(50)]
    public void max_time()
    {
        Thread.Sleep(1000);
        TestContext.WriteLine("After sleep thread");
    }
}