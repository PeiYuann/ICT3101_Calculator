using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {

        private double _result;
        private Calculator _calculator;
        public UsingCalculatorAvailabilitySteps(Calculator calc)
        { this._calculator = calc; }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            try
            {
                _result = _calculator.MTBF(p0,p1);
            }
            catch (ArgumentException err)
            {
                ScenarioContext.Current[("Error")] = err;
            }
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            try
            {
                _result = _calculator.Avail(p0,p1);
            }
            catch (ArgumentException err)
            {
                ScenarioContext.Current[("Error")] = err;
            }
        }
        
        
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be argument exception")]
        public void ThenTheAvailabilityResultShouldBeArgumentException()
        {
            Assert.IsTrue(ScenarioContext.Current.ContainsKey("Error"));
        }

    }
}
