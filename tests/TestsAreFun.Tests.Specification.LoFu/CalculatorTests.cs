using System.Diagnostics.CodeAnalysis;
using FluentAssertions;
using TestsAreFun.Calculators;
#pragma warning disable CS8321

namespace TestsAreFun.Tests.Specification.LoFu;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public class CalculatorTests
{
    Calculator Subject;
    decimal Dividend;
    decimal Divisor;

    [SetUp]
    public void SetUp() => Subject = new Calculator();

    [LoFu, Test]
    public void Divide_two_positive_integers()
    {
        void When_dividend_is_10() => Dividend = 10;
        void and_divisor_is_5() => Divisor = 5;
        void Result_should_be_2() => Subject.Divide(Dividend, Divisor).Should().Be(2);
    }
}