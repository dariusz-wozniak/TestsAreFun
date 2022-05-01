using TestsAreFun.Calculators;

namespace TestsAreFun.Tests.Specification.SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _context;
        private readonly Calculator _calculator;

        public CalculatorStepDefinitions(ScenarioContext context)
        {
            _context = context;
            _calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _context["firstNumber"] = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _context["secondNumber"] = number;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            var expectedResult = Convert.ToInt32(_context["result"]);

            expectedResult.Should().Be(result);
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            var first = Convert.ToInt32(_context["firstNumber"]);
            var second = Convert.ToInt32(_context["secondNumber"]);

            _context["result"] = _calculator.Divide(first, second);
        }
    }
}