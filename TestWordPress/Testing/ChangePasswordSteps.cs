using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class ChangePasswordSteps:SeleniumHelper
    {
        public string newPassword;
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [When(@"From the left panel, I select security")]
        public void WhenFromTheLeftPanelISelectSecurity()
        {
            Click(profilepageObject.SecurityTab);
            //test git
        }
        [When(@"I Enter new password")]
        public void WhenIEnterYourNewPassword()
        {
            //testgit 2
            newPassword = Helper.GetRandomString(6, 15);
            SendKey(profilepageObject.NewPasswordText, newPassword);

        }
        [Then(@"I verify password can be saved")]
        public void ThenIVerifyPasswordCanBeSaved()
        {

            Assert.IsTrue(CheckifDisplay(profilepageObject.PasswordCanSaveMessage), "Password is not match with format");
            if (CheckifDisplay(profilepageObject.PasswordCanSaveMessage))
            {
                passWord = newPassword;
                updateinApp("PassWord", passWord);
            }

        }

        [When(@"Click button Save Password")]
        public void WhenClickButtonSavePassword()
        {
            Click(profilepageObject.Savebutton);
        }

    }
}
