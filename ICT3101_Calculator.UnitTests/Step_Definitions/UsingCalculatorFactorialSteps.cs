using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private double _result;
        private Calculator _calculator;
        public UsingCalculatorFactorialSteps(Calculator calc)
        { this._calculator = calc; }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            
            try
            {
                _result = _calculator.Factorial(p0);
            }
            catch (ArgumentException err)
            {
                ScenarioContext.Current[("Error")] = err;
            }
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the factorial result should be invalid argument")]
        public void ThenTheFactorialResultShouldBeInvalidArgument()
        {
            Assert.IsTrue(ScenarioContext.Current.ContainsKey("Error"));
        }
    }
}
