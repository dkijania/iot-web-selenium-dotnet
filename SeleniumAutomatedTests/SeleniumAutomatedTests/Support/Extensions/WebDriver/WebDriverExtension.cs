using OpenQA.Selenium;

namespace SeleniumAutomatedTests.Support.Extensions.WebDriver
{
    internal static class WebDriverExtension
    {
        public static bool IsInCurrentViewPort(this IWebDriver webDriver, IWebElement webElement)
        {
            var windowYStart = (int)GetWindowTopYPosition(webDriver);
            var windowYEnd = (int)GetWindowBottomYPosition(webDriver) +  windowYStart;

            var elementYStart = webElement.Location.Y;
            var elementYEnd = elementYStart+ webElement.Size.Height;

            return windowYStart < elementYStart && windowYEnd > elementYEnd;
        }

        public static long GetWindowTopYPosition(this IWebDriver webDriver)
        {
            var executor = (IJavaScriptExecutor)webDriver;
            return (long)executor.ExecuteScript("return window.pageYOffset");
        }
        
        public static long GetWindowBottomYPosition(this IWebDriver webDriver)
        {
            var executor = (IJavaScriptExecutor)webDriver;
            return (long)executor.ExecuteScript("return window.innerWidth");
        }

    }
}
