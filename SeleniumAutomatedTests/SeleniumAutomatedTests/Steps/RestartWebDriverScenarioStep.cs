using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAutomatedTests.Support.Extensions.TestActions;
using SeleniumAutomatedTests.Support.Extensions.TestActions.Core;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests.Steps
{
    public class RestartWebDriverScenarioStep
    {
        private readonly TestActionExecutor _testActionExecutor;

        public RestartWebDriverScenarioStep(TestActionExecutor testActionExecutor)
        {
            _testActionExecutor = testActionExecutor;
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