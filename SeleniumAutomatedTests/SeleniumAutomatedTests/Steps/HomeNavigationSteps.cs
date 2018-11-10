using System;
using NUnit.Framework;
using SeleniumAutomatedTests.Support.Extensions.TestActions;
using SeleniumAutomatedTests.Support.Extensions.TestActions.Core;
using SeleniumAutomatedTests.Support.UI.HomePage;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests.Steps
{
    [Binding]
    public class HomeNavigationSteps
    {
        private readonly HomePageService _homeService;
        private readonly TestActionExecutor _testActionExecutor;
        
        public HomeNavigationSteps(HomePageService homeService, TestActionExecutor testActionExecutor)
        {
            _homeService = homeService;
            _testActionExecutor = testActionExecutor;
        }

        [Given(@"User is on Home Page")]
        public void GivenUserIsOnHomePage()
        {
            _homeService.Navigate();
        }

        [When(@"User clicks Pricing toolbar button")]
        public void WhenUserClicksToolbarButton()
        {
            _homeService.GotoPricingSectionByToolbar();
        }

        [When(@"User clicks Pricing drop arrow button")]
        public void WhenUserClicksDropDownButton()
        {
            _homeService.GotoPricingSectionByArrowButton();
        }
        
        [Then(@"User is navigated to Pricing section")]
        public void ThenUserIsNavigatedToSection()
        {
            Assert.IsTrue(_homeService.IsPricingSectionDisplayed, "After toolbar button is clicked pricing section is displayed");
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            _testActionExecutor.Before();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _testActionExecutor.After();
        }
    }
}
