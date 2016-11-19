using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TestWordPress.Helpers;
using TestWordPress.PageObjects;

namespace TestWordPress.Testing
{
    [Binding]
    public class LoginFeatureSteps:SeleniumHelper
    {
        public static string passwordlogin;
        public static string usernamelogin;
        
        [Given(@"I am in Login Page")]
        public void GivenIAmInLoginPage()
        {
            Console.WriteLine("Login page");
        }

        [When(@"I click Login Link")]
        public void WhenIClickLoginLink()
        {
            Click(PageObjects.homepageObject.LoginButton);
        }

        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            SendKeyandKeyTab(loginObject.userNameTextbox, userName);
            
        }
        [When(@"I enter username '(.*)'")]
        public void WhenIEnterUsername(string p0)
        {
            SendKeyandKeyTab(loginObject.userNameTextbox, p0);
            usernamelogin = p0;
        }

        [When(@"I enter password '(.*)'")]
        public void WhenIEnterPassword(string p0)
        {
            SendKeyandKeyTab(loginObject.passwordTextbox, p0);
            passwordlogin = p0;
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            SendKeyandKeyTab(loginObject.passwordTextbox, passWord);
          
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            Click(loginObject.loginSubmitButton);
        }
        

        [Then(@"I can log in successfully")]
        public void ThenICanLoginSuccessfully()
        {
            Click(homepageWithUser.avarta);
            Assert.AreEqual(GetText(profilepageObject.usernamedisplay), usernamelogin);
        }

        [Then(@"I can log in unsuccessfully")]
        public void ThenICanLogInUnsuccessfully()
        {
            Assert.IsTrue(CheckifDisplay(loginObject.ErrorLogin), "wrong login");
        }

        [When(@"Move mouse hover to avatar and click on the avarta")]
        public void WhenMoveMouseHoverToAvatarAndClickOnTheAvarta()
        {
            mouseHoverAndClick(homepageWithUser.avarta);
        }

       

        [Then(@"I verify save successfully")]
        public void ThenIVerifySaveSuccessfully()
        {
            Assert.IsTrue(CheckifDisplay(profilepageObject.SaveSuccessMessage), "Can not save");
            //update new password into appconfig
            
        }

        [When(@"I Click Sign-out and sign-in again")]
        public void WhenIClickSign_OutAndSign_InAgain()
        {
            Click(profilepageObject.SignOutbutton);
            Helpers.Hooks.HookHelper.LoginWordPress();
        }
    }
}
