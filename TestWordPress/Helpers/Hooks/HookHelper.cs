using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWordPress.PageObjects;

namespace TestWordPress.Helpers.Hooks
{
   public class HookHelper:SeleniumHelper
    {
       public static void LoginWordPress()
       {
           Click(PageObjects.homepageObject.LoginButton);
           SendKeyandKeyTab(loginObject.userNameTextbox, userName);
           SendKeyandKeyTab(loginObject.passwordTextbox, passWord);
           Click(loginObject.loginSubmitButton);

       }

      
    }
}
