using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    public class UpdateInfoPage : BasePage
    {
        #region Locators
        By updateProfileLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/ul/li[6]/a");
        By fnameFld = By.Id("customer.firstName");
        By lnameFld = By.Id("customer.lastName");
        By addressFld = By.Id("customer.address.street");
        By cityFld = By.Id("customer.address.city");
        By stateFld = By.Id("customer.address.state");
        By zipCodeFld = By.Id("customer.address.zipCode");
        By phNoFld = By.Id("customer.phoneNumber");
        By updateBtn = By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[1]/form/table/tbody/tr[8]/td[2]/input");
        #endregion

        #region Methods
        public void updateInfo(string fname, string lname, string address, string city, string state, string zipCode, string phoneNumber)
        {
            driver.FindElement(updateProfileLnk).Click();
            Thread.Sleep(1000);
            if(fname != "")
            {
                IWebElement ele = driver.FindElement(fnameFld);
                ele.Clear();
                ele.SendKeys(fname);
            }
            if (lname != "")
            {
                IWebElement ele = driver.FindElement(lnameFld);
                ele.Clear();
                ele.SendKeys(lname);
            }
            if (address != "")
            {
                IWebElement ele = driver.FindElement(addressFld);
                ele.Clear();
                ele.SendKeys(address);
            }
            if (city != "")
            {
                IWebElement ele = driver.FindElement(cityFld);
                ele.Clear();
                ele.SendKeys(city);
            }
            if (state != "")
            {
                IWebElement ele = driver.FindElement(stateFld);
                ele.Clear();
                ele.SendKeys(state);
            }
            if (zipCode != "")
            {
                IWebElement ele = driver.FindElement(zipCodeFld);
                ele.Clear();
                ele.SendKeys(zipCode);
            }
            if (phoneNumber != "")
            {
                IWebElement ele = driver.FindElement(phNoFld);
                ele.Clear();
                ele.SendKeys(phoneNumber);
            }
            Thread.Sleep(2000);
            driver.FindElement(updateBtn).Click();
        }
        #endregion
    }
}
