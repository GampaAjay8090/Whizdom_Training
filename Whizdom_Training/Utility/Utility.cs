using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizdom_Training.StepDefinitions
{
    public class Utility
    {
        IWebDriver driver = null;
        Loginpageobj loginpageobj = new Loginpageobj();
        public void openbrowser(string btype)
        {
            if (btype.Equals("Morzilla"))
                driver = new FirefoxDriver();
            else if (btype.Equals("Chrome"))
                driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(3000);
        }
      public void Navigateurl(string url)
        {
            driver.Url = ConfigurationManager.AppSettings[url];
        }

        public IWebElement getelement(string objct) 
        {
            IWebElement e = null;
            if(objct.EndsWith("_xpath"))
                e = driver.FindElement(By.XPath(ConfigurationManager.AppSettings[objct]));
            return e;
        }

        public void click(string objct) 
        {
           getelement(objct).Click();
        }
        public void type(string objct, string data) 
        { 
          getelement(objct).SendKeys(data);
        }

        public static void GetConfigurationUsingSection()
        {
            var applicationSettings = ConfigurationManager.GetSection("ApplicationSettings") as NameValueCollection;
            if (applicationSettings.Count == 0)
            {
                Console.WriteLine("Application Settings are not defined");
            }
            else
            {
                foreach (var key in applicationSettings.AllKeys)
                {
                    Console.WriteLine(key + " = " + applicationSettings[key]);
                }
            }
        }
    }
}
