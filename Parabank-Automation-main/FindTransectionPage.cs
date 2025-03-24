using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    public class FindTransectionPage : BasePage
    {
        #region Locators
        By findTransactionLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/ul/li[5]/a");
        By accountSlt = By.Id("accountId");
        By tIdFld = By.Id("transactionId");
        By findByIdBtn = By.Id("findById");
        By dateFld = By.Id("transactionDate");
        By findByDateBtn = By.Id("findByDate");
        By fromDateFld = By.Id("fromDate");
        By toDateFld = By.Id("toDate");
        By findByDateRangeBtn = By.Id("findByDateRange");
        By amountFld = By.Id("amount");
        By findByAmountBtn = By.Id("findByAmount");
        #endregion

        #region Methods
        public void findByTId(string account, string transactionId)
        {
            driver.FindElement(findTransactionLnk).Click();
            SelectElement accSelect = new SelectElement(driver.FindElement(accountSlt));
            accSelect.SelectByText(account);
            driver.FindElement(tIdFld).SendKeys(transactionId);
            driver.FindElement(findByIdBtn).Click(); 
        }
        public void findByDate(string account, string date)
        {
            driver.FindElement(findTransactionLnk).Click();
            SelectElement accSelect = new SelectElement(driver.FindElement(accountSlt));
            accSelect.SelectByText(account);
            driver.FindElement(dateFld).SendKeys(date);
            driver.FindElement(findByDateBtn).Click();
        }
        public void findByDateRange(string account, string fromDate, String toDate)
        {
            driver.FindElement(findTransactionLnk).Click();
            SelectElement accSelect = new SelectElement(driver.FindElement(accountSlt));
            accSelect.SelectByText(account);
            driver.FindElement(fromDateFld).SendKeys(fromDate);
            driver.FindElement(toDateFld).SendKeys(toDate);
            driver.FindElement(findByDateRangeBtn).Click();
        }
        public void findByAmount(string account, string amount)
        {
            driver.FindElement(findTransactionLnk).Click();
            SelectElement accSelect = new SelectElement(driver.FindElement(accountSlt));
            accSelect.SelectByText(account);
            driver.FindElement(amountFld).SendKeys(amount);
            driver.FindElement(findByAmountBtn).Click();
        }
        #endregion
    }
}
