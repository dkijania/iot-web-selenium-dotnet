using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomatedTests.Support.Extensions.WebDriver;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests.Support.UI.HomePage
{
    [Binding]
    public class HomePageObject
    {        
        public HomePageObject(SeleniumContext seleniumContext)
        {
            PageFactory.InitElements(seleniumContext.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[span[text()='Login']]")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[span[text()='Pricing']]")]
        public IWebElement PricingToolbarButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Pricing']")]
        public IWebElement PricingHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='ArrowDropDown']")]
        public IWebElement PricingDropDownButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Chariot']")]
        public IWebElement Banner { get; set; }

    }
}
