using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    public class BillPaymentPage : BasePage
    {
        #region Locators
        By payBillLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/ul/li[4]/a");
        By nameFld = By.Name("payee.name");
        By addressFld = By.Name("payee.address.street");
        By cityFld = By.Name("payee.address.city");
        By stateFld = By.Name("payee.address.state");
        By zipCodeFld = By.Name("payee.address.zipCode");
        By phNoFld = By.Name("payee.phoneNumber");
        By accountFld = By.Name("payee.accountNumber");
        By accountReFld = By.Name("verifyAccount");
        By amountFld = By.Name("amount");
        By fromAccountSlt = By.Name("fromAccountId");
        By payBtn = By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[1]/form/table/tbody/tr[14]/td[2]/input");
        #endregion

        #region Methods
        public void PayBill(string name, string address, string city, string state, string zipCode, string phNo, string toAccount, string amount, string fromAccount)
        {
            driver.FindElement(payBillLnk).Click();
            driver.FindElement(nameFld).SendKeys(name);
            driver.FindElement(addressFld).SendKeys(address);
            driver.FindElement(cityFld).SendKeys(city);
            driver.FindElement(stateFld).SendKeys(state);
            driver.FindElement(zipCodeFld).SendKeys(zipCode);
            driver.FindElement(phNoFld).SendKeys(phNo);
            driver.FindElement(accountFld).SendKeys(toAccount);
            driver.FindElement(accountReFld).SendKeys(toAccount);
            driver.FindElement(amountFld).SendKeys(amount);
            SelectElement accSelect = new SelectElement(driver.FindElement(fromAccountSlt));
            accSelect.SelectByText(fromAccount);
            driver.FindElement(payBtn).Click();
        }
        #endregion
    }
}
