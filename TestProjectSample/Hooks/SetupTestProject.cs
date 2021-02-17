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
        private GenericDriver _genericDriver;

        [BeforeScenario()]
        public void CreateDriver()
        {
            _genericDriver = new GenericDriver(projectName: "Webinar February 2021", jobName: "TestProjectSample");
        }
    }
}
