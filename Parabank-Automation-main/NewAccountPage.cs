using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ST_Project
{
    public class NewAccountPage : BasePage
    {
        #region Locators
        By newAccountPageLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/ul/li[1]/a");
        By typeSlt = By.Id("type");
        By accountSlt = By.Id("fromAccountId");
        By openAccountBtn = By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[1]/form/div/input");
        #endregion

        #region Methods
        public void CreateAccount(string type, string accountNumber)
        {
            driver.FindElement(newAccountPageLnk).Click();
            Thread.Sleep(2000);
            SelectElement typeSelect = new SelectElement(driver.FindElement(typeSlt));
            SelectElement accSelect = new SelectElement(driver.FindElement(accountSlt));
            typeSelect.SelectByText(type.ToUpper());
            accSelect.SelectByText(accountNumber);
            driver.FindElement(openAccountBtn).Click();
        }
        #endregion
    }
}
