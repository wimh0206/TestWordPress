using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestWordPress.Helpers
{
    public class SeleniumHelper
    {
        public static IWebDriver driver;
        //user name & password to login
        public static String userName=ConfigurationManager.AppSettings["UserName"];
        public static String passWord = ConfigurationManager.AppSettings["PassWord"];
        public static int timeoutInSeconds = 10;
        public static void register (IWebDriver selenium)
        {
            driver = selenium;
        }
        //take a screen shot when scnenario fail
        public static void TakeScreenShot()
        {
            var DATE=DateTime.Now.ToString("yyyyMMdd");
            //var newfolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Image\\" + DATE + "\\";
            var newfolder = "Image\\" + DATE + "\\";
            if (!Directory.Exists(newfolder))
            {
                Directory.CreateDirectory(newfolder);
                Console.WriteLine("Screenshot folder has been created");
            }
            var screenshotDriver = driver as ITakesScreenshot;
            var screenShot = screenshotDriver.GetScreenshot();
            screenShot.SaveAsFile(newfolder
                                + ScenarioContext.Current.ScenarioInfo.Title
                                + DateTime.Now.ToString("yyyyMMddTHHmmss")
                                + ".png", ImageFormat.Png);

        }
        public static IWebElement FindElement(String xpath)
        {
            if(timeoutInSeconds>0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(By.XPath(xpath)));
            }
            return driver.FindElement(By.XPath(xpath));
        }
        //Click to element
        public  static void Click(String xpath)
        {
            Console.WriteLine("Click on: {0}", xpath);
            FindElement(xpath).Click();
            
	    }
        //Send key to element
        public static void  SendKey(String xpath, String Key)
        {
            Console.WriteLine("Enter {0} into {1} ", Key, xpath);
            var element = FindElement(xpath);
            element.Clear();
            element.SendKeys(Key);
		    
	    }
        //Send key to element and send key tab to next element after send key
        public static void SendKeyandKeyTab(String xpath, String Key)
        {
            Console.WriteLine("Enter {0} into {1} ", Key, xpath);
            var element = FindElement(xpath);
            element.Clear();
            element.SendKeys(Key);
            element.SendKeys(Keys.Tab);
        }
        //Mouse hover and click element
        public static void mouseHoverAndClick (String xpath)
        {
		    
		    Actions  action = new Actions(driver);
            var moveonmenu = FindElement(xpath);
		    action.MoveToElement(moveonmenu).Click().Perform();
		
	    }
        //check element is displayed in web
        public static bool CheckifDisplay(String xpath)
        {
            return FindElement(xpath).Displayed;
        }
        //Compare 2 text
        public static bool Verifytext(String expected, String actual)
        {
            return expected.ToLower().Trim().Contains(actual.ToLower().Trim());
        }
        //get text in element
        public static String  GetText(String xpath)
        {
            String text =FindElement(xpath).Text;
            Console.WriteLine(text);
            return text;

        }
        //update password when generate pass into app.config file
        public static void updatePassinApp(string passWord)
        {
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "\\App.config";
            Console.WriteLine(filePath);
            var map = new ExeConfigurationFileMap { ExeConfigFilename = filePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            config.AppSettings.Settings["PassWord"].Value = passWord;     
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Console.WriteLine("passnew update in config file" + config.AppSettings.Settings["PassWord"].Value);
        }
        public static void GotoUrl(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
        public static void updateinApp(string keywork,string keyupdate)
        {
            var filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+"\\App.config";
            Console.WriteLine(filePath);
            var map = new ExeConfigurationFileMap { ExeConfigFilename = filePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            config.AppSettings.Settings[keywork].Value = keyupdate;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Console.WriteLine("passnew update in config file" + config.AppSettings.Settings[keywork].Value);
        }
    }
}
