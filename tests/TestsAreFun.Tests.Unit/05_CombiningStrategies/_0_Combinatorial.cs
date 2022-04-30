namespace TestsAreFun.Tests.Unit._05_CombiningStrategies;

public class _0_Combinatorial
{
    [Test]
    [Combinatorial]
    public void combinatorial_test(
        [Values(1, 2, 3)] int number,
        [Values("a", "b")] string text,
        [Values] bool boolean)
    {
        // ...
    }
}