using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    public class TransferFundPage : BasePage
    {
        #region Locators
        By transferLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/ul/li[3]/a");
        By amountFld = By.Id("amount");
        By fromAccountSlt = By.Id("fromAccountId");
        By toAccountSlt = By.Id("toAccountId");
        By transferBtn = By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[1]/form/div[2]/input");
        #endregion

        #region Methods
        public void Transfer(string amount, string fromAccount, string toAccount)
        {
            driver.FindElement(transferLnk).Click();
            Thread.Sleep(2000);
            driver.FindElement(amountFld).SendKeys(amount);
            SelectElement fromAccountSelect = new SelectElement(driver.FindElement(fromAccountSlt));
            SelectElement toAccountSelect = new SelectElement(driver.FindElement(toAccountSlt));
            fromAccountSelect.SelectByText(fromAccount);
            toAccountSelect.SelectByText(toAccount);
            driver.FindElement(transferBtn).Click();
        }
        #endregion
    }
}
