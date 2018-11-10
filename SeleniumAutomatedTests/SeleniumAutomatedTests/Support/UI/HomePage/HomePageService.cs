using OpenQA.Selenium;
using SeleniumAutomatedTests.Support.Configuration;
using SeleniumAutomatedTests.Support.Extensions.WebDriver;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests.Support.UI.HomePage
{
    [Binding]
    public class HomePageService
    {
        private readonly HomePageObject _pageObject;
        private readonly IWebDriver _webDriver;
        private readonly TestConfiguration _testConfiguration;

        public bool IsPricingSectionDisplayed => _webDriver.IsInCurrentViewPort(_pageObject.PricingHeader);

        public HomePageService(HomePageObject pageObject, SeleniumContext seleniumContext,
            TestConfiguration testConfiguration)
        {
            _pageObject = pageObject;
            _webDriver = seleniumContext.WebDriver;
            _testConfiguration = testConfiguration;
        }

        public void GotoPricingSectionByToolbar()
        {
            _pageObject.PricingToolbarButton.Click();
        }

        public void GotoPricingSectionByArrowButton()
        {
            _pageObject.PricingDropDownButton.Click();
        }

        public void NavigateToLogin()
        {
            _pageObject.LoginButton.Click();
        }

        public bool PageIsOpened()
        {
            return _pageObject.Banner.Displayed;
        }

        public void Navigate()
        {
            _webDriver.Navigate().GoToUrl(_testConfiguration.Url);
        }
    }
}