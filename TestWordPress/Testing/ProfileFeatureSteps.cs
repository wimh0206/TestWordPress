using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestWordPress.Helpers;
using TestWordPress.PageObjects;

namespace TestWordPress.Testing
{
    [Binding]
    public class ProfileFeatureSteps:SeleniumHelper
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [When(@"From the left panel, I select My Profile")]
        public void WhenFromTheLeftPanelISelectMyProfile()
        {
            Click(profilepageObject.MyProfileTab);
        }

        [When(@"Enter first name ""(.*)"", last name ""(.*)"", about me ""(.*)""")]
        public void WhenEnterFirstNameLastNameAboutMe(string p0, string p1, string p2)
        {
            DateTime date = DateTime.Now;
            SendKeyandKeyTab(profilepageObject.FirstNameText, p0);
            SendKeyandKeyTab(profilepageObject.LastNameText, p1);
            SendKeyandKeyTab(profilepageObject.AboutmeText, p2 + date);
        }

        [When(@"Click Save Profile Detail")]
        public void WhenClickSaveProfileDetail()
        {
            Click(profilepageObject.Savebutton);
        }
    }
}
