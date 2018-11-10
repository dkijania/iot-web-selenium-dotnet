using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests.Support.Extensions.WebDriver
{
    [Binding]
    public class SeleniumContext
    {
        public IWebDriver WebDriver { get; }

        public SeleniumContext()
        {
            WebDriver = new ChromeDriver();
        }
    }
}