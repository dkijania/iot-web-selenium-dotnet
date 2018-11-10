using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomatedTests.Support.Extensions.TestActions;
using SeleniumAutomatedTests.Support.Extensions.TestActions.Core;
using SeleniumAutomatedTests.Support.Extensions.WebDriver;
using SeleniumAutomatedTests.Support.UI.HomePage;
using SpecFlow.Unity;
using TechTalk.SpecFlow;
using Unity;
using Unity.Injection;
using Unity.RegistrationByConvention;

namespace SeleniumAutomatedTests.Support
{
    public static class TestDependencies
    {
        [ScenarioDependencies]
        public static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<SeleniumContext>();
            container.RegisterType<HomePageObject>();
            container.RegisterType<HomePageService>();
            container.RegisterType<TestActionExecutor>();
            return container;
        }
    }
}