using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SampleCalculatorSpecflowNunit.StepDefinitions
{
    [Binding]
    public class CalculatorSpecflowNunitStepDefinitions
    {
        CalculatorMachine machine = new CalculatorMachine();
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p1)
        {
            machine.a = p1;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p2)
        {
            machine.b = p2;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            machine.Calculate("+");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, machine.res);
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            machine.Calculate("*");
        }

    }
}
