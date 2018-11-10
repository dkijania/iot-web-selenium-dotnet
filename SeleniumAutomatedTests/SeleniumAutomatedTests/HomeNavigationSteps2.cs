using System;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests
{
    [Binding]
    public class HomeNavigationSteps
    {
        [When(@"User clicks '(.*)' drop arrow button")]
        public void WhenUserClicksDropArrowButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
