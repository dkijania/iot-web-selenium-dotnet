using System.Collections.Generic;
using SeleniumAutomatedTests.Support.Extensions.WebDriver;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests.Support.Extensions.TestActions.Core
{
    [Binding]
    public class TestActionExecutor
    {
        private readonly List<IBeforeTestAction> _beforeTestActions;
        private readonly List<IAfterTestAction> _afterTestActions;

        public TestActionExecutor(SeleniumContext seleniumContext)
        {
            _beforeTestActions = new List<IBeforeTestAction>();
            _afterTestActions = new List<IAfterTestAction> {new CloseDriverAction(seleniumContext.WebDriver) };
        }

        public void Before()
        {
            _beforeTestActions.ForEach(x => x.Run());
        }

        public void After()
        {
            _afterTestActions.ForEach(x => x.Run());
        }
    }
}