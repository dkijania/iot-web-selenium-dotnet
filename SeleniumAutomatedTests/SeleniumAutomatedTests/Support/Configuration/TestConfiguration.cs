using System.Configuration;
using TechTalk.SpecFlow;

namespace SeleniumAutomatedTests.Support.Configuration
{
    [Binding]
    public class TestConfiguration
    {
        public string Url { get; }

        public TestConfiguration()
        {
            Url = ConfigurationManager.AppSettings["Url"];
        }
    }
}
