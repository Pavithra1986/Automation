using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace automationpractice.Utilities
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Generic.driver = new FirefoxDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Generic.driver.Quit();
        }
    }
}
