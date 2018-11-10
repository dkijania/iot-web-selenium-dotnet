using OpenQA.Selenium;
using SeleniumAutomatedTests.Support.Extensions.TestActions.Core;

namespace SeleniumAutomatedTests.Support.Extensions.TestActions
{
    class CloseDriverAction : IAfterTestAction
    {
        private readonly IWebDriver _driver;

        public CloseDriverAction(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Run()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
