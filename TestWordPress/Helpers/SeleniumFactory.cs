using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace TestWordPress.Helpers
{
    class SeleniumFactory
    {
        static IWebDriver driver=null;
        public static IWebDriver CreateSeleniumSession()
        {
            Console.WriteLine("=============================================");
            var folderDrivers = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\drivers\\";
            Console.WriteLine("Create Selenium Session");
            switch (ConfigurationManager.AppSettings["Browser"])
            {
                case "IE":
                    InternetExplorerOptions options = new InternetExplorerOptions();
                    options.IgnoreZoomLevel = true;
                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    driver = new InternetExplorerDriver(folderDrivers + "IEDriver\\",options);
                    
                    break;
                case "FF":
                   // var PROXY = new Proxy();
                   // PROXY.HttpProxy = "localhost:82";
                    FirefoxProfile profile = new FirefoxProfile();
                    //profile.SetProxyPreferences(PROXY);
                    driver = new FirefoxDriver(profile);
                    
                   // driver = new FirefoxDriver(profile);
                    break;
                case "CH":
                    var chromedriver = folderDrivers + "ChromeDriver\\";
                    driver = new ChromeDriver(chromedriver);
                    break;
                default:
                    break;
            }
            SeleniumHelper.register(driver);
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["webURL"]);
            return driver;
        }
        public static void CloseSeleiumSession()
        {
            driver.Quit();
        }
    }
}
