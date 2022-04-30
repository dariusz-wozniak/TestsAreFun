namespace TestsAreFun.Tests.Unit._05_CombiningStrategies;

public class _2_Pairwise
{
    [Test]
    [Pairwise]
    public void pairwise_test(
        [Values(1, 2, 3)] int number,
        [Values("a", "b")] string text,
        [Values] bool boolean)
    {
        // ...
    }

    //// Uncomment to reveal number of tests:
    //[Test]
    //[Pairwise]
    //public void pairwise_with_a_lot_of_cases(
    //    [Range(1, 100)] int number1,
    //    [Range(1, 100)] int number2,
    //    [Range(1, 100)] int number3,
    //    [Values("a", "b")] string text,
    //    [Values] bool boolean)
    //{
    //    // ...
    //}
}