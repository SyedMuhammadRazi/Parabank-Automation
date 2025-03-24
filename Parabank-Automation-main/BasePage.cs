using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    public class BasePage
    {
        public static IWebDriver driver;

        public static void SeleniumInit(String browser)
        {
            if (browser == "Chrome")
            {
                IWebDriver chromeDriver = new ChromeDriver();
                driver = chromeDriver;
            }
            else if (browser == "FireFox")
            {
                driver = new FirefoxDriver();
            }
        }
        public static void SeleniumCleanUp()
        {
           driver.Close();
        }
    }
}
