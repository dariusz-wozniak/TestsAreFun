using TestsAreFun.Calculators;

namespace TestsAreFun.Tests.Unit._07_Generics;

[TestFixture(typeof(double))]
[TestFixture(typeof(decimal))]
[TestFixture(typeof(float))]
[TestFixture(typeof(int))]
[TestFixture(typeof(long))]
public class GenericCalculatorTests<T>
{
    [Test]
    public void addition_test()
    {
        dynamic a = 2;
        dynamic b = 3;

        var calculator = new GenericCalculator<T>();
        dynamic result = calculator.Add(a, b);

        Assert.That(result, Is.EqualTo(5));
    }
}