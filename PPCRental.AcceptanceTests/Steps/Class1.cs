using System;
using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Driver.Home;
using PPCRental.AcceptanceTests.Driver.Login;

namespace PPCRental.AcceptanceTests.Steps
{
    [Binding]



    class Class1
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd() => ScenarioContext.Current.Pending();

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
