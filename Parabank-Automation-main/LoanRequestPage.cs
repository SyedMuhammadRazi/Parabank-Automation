using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    public class LoanRequestPage : BasePage
    {
        #region Locators
        By reqLoanLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/ul/li[7]/a");
        By loanAmountFld = By.Id("amount");
        By downPaymentFld = By.Id("downPayment");
        By fromAccountSlt = By.Id("fromAccountId");
        By applyBtn = By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[1]/form/table/tbody/tr[4]/td[2]/input");
        #endregion

        #region Methods
        public void loanRequest(string amount, string downPayment, string fromAccount)
        {
            driver.FindElement(reqLoanLnk).Click();
            driver.FindElement(loanAmountFld).SendKeys(amount);
            driver.FindElement(downPaymentFld).SendKeys(downPayment);
            SelectElement accSelect = new SelectElement(driver.FindElement(fromAccountSlt));
            accSelect.SelectByText(fromAccount);
            driver.FindElement(applyBtn).Click();
        }
        #endregion
    }
}
