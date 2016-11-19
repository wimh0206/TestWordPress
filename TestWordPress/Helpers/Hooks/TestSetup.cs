using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestWordPress.Helpers;


namespace TestWordPress.Helpers.Hooks
{
    [Binding]
    public class TestSetup
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            SeleniumFactory.CreateSeleniumSession();
        }
        [BeforeScenario("TestWithoutLogin")]
        public void TestWithoutLogin()
        {
            //TODO: implement logic that has to run before executing each scenario
            HookHelper.LoginWordPress();
            
        }
        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            if (ScenarioContext.Current.TestError != null)
            {
                SeleniumHelper.TakeScreenShot();
            }
            SeleniumFactory.CloseSeleiumSession();
        }
        [AfterScenario("UpdatenewPasswordintoappconfig")]
        public void UpdatenewPasswordintoappconfig()
        {
            //TODO: implement logic that has to run after executing each scenario
            if (ScenarioContext.Current.TestError == null)
            {
                SeleniumHelper.updateinApp("PassWord", SeleniumHelper.passWord);
            }
            
        }
    }
}
