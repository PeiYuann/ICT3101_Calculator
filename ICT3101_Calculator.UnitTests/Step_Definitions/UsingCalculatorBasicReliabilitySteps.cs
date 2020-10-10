using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private double _result;
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        { this._calculator = calc; }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press CFI")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressCFI(int p0, int p1, int p2)
        {
            _result = _calculator.CFI(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press AEF")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressAEF(int p0, int p1, int p2)
        {
            _result = _calculator.AEF(p0, p1, p2);
        }
        
        [Then(@"the reliability result should be ""(.*)""")]
        public void ThenTheReliabilityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
