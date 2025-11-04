using FluentAssertions;

namespace EABDDTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        int _firstNumber;
        int _secondNumber;



        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {

            Console.WriteLine($"First number is {number}");
            _firstNumber = number;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
           Console.WriteLine($"Second number is {number}");
           _secondNumber = number;
        }


        [Then("the result for {string} should be {int}")]
        public void ThenTheResultForAdditionShouldBe(string operation, int result)
        {
            if(operation == "addition")
            {
                result.Should().Be(_firstNumber + _secondNumber);
            }
            else if(operation == "substraction")
            {
                result.Should().Be(_firstNumber - _secondNumber);
            }
            else
            {
                throw new ArgumentException($"Unknown operation: {operation}");
            }
        }


        [Then("I am happy to say its {string}")]
        public void ThenIAmHappyToSayIts(string result)
        {
            Console.WriteLine($"The test has {result}");
        }


    }
}
