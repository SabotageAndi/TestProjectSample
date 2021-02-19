using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TestProject.OpenSDK.Drivers.Generic;

namespace TestProjectSample.Hooks
{
    [Binding]
    public class SetupTestProject
    {
        private readonly ScenarioContext _scenarioContext;
        private GenericDriver _genericDriver;

        public SetupTestProject(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario()]
        public void CreateDriver()
        {
            _genericDriver = new GenericDriver(projectName: "Webinar February 2021", jobName: "TestProjectSample");
        }

        [AfterScenario]
        public void CloseDriver()
        {

            _genericDriver.Report().Test(_scenarioContext.ScenarioInfo.Title, _scenarioContext.TestError is null);

            _genericDriver.Quit();
        }
    }
}
