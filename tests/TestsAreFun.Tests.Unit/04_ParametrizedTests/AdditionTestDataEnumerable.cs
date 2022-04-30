using System.Collections;

namespace TestsAreFun.Tests.Unit._04_ParametrizedTests;

public class AdditionTestDataEnumerable : IEnumerable<int[]>
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<int[]> GetEnumerator()
    {
        yield return new[] { 2, 2, 4 };
        yield return new[] { 1, -1, 0 };
    }
}