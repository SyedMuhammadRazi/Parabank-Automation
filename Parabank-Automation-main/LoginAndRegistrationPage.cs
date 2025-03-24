using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    public class LoginAndRegistrationPage : BasePage
    {
        #region Locators
        By usernameFld = By.Name("username");
        By passwordFld = By.Name("password");
        By loginBtn = By.XPath("/html/body/div[1]/div[3]/div[1]/div/form/div[3]/input");
        By forgetLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/div/p[1]/a");
        By registerLnk = By.XPath("/html/body/div[1]/div[3]/div[1]/div/p[2]/a");
        By fnameFld = By.Id("firstName");
        By lnameFld = By.Id("lastName");
        By addressFld = By.Id("address.street");
        By cityFld = By.Id("address.city");
        By stateFld = By.Id("address.state");
        By zipCodeFld = By.Id("address.zipCode");
        By ssnFld = By.Id("ssn");
        By findInfoBtn = By.XPath("/html/body/div[1]/div[3]/div[2]/form/table/tbody/tr[8]/td[2]/input");
        By regFnameFld = By.Id("customer.firstName");
        By regLnameFld = By.Id("customer.lastName");
        By regAddressFld = By.Id("customer.address.street");
        By regCityFld = By.Id("customer.address.city");
        By regStateFld = By.Id("customer.address.state");
        By regZipCodeFld = By.Id("customer.address.zipCode");
        By regPhNoFld = By.Id("customer.phoneNumber");
        By regSsnFld = By.Id("customer.ssn");
        By regUserNameFld = By.Id("customer.username");
        By regPassFld = By.Id("customer.password");
        By regRePassFld = By.Id("repeatedPassword");
        By registerBtn = By.XPath("/html/body/div[1]/div[3]/div[2]/form/table/tbody/tr[13]/td[2]/input");
        #endregion

        #region Methods
        public void login(string url, string user, string pass)
        {
            driver.Url = url;
            driver.FindElement(usernameFld).SendKeys(user);
            driver.FindElement(passwordFld).SendKeys(pass);
            driver.FindElement(loginBtn).Click();
        }
        public void forgetUnamePass(string url, string firstName, string lastName, string address, string city, string state, string zipcode, string ssn)
        {
            driver.Url = url;
            driver.FindElement(forgetLnk).Click();
            driver.FindElement(fnameFld).SendKeys(firstName);
            driver.FindElement(lnameFld).SendKeys(lastName);
            driver.FindElement(addressFld).SendKeys(address);
            driver.FindElement(cityFld).SendKeys(city);
            driver.FindElement(stateFld).SendKeys(state);
            driver.FindElement(zipCodeFld).SendKeys(zipcode);
            driver.FindElement(ssnFld).SendKeys(ssn);
            driver.FindElement(findInfoBtn).Click();
        }
        public void register(string url, string firstName, string lastName, string address, string city, string state, string zipcode, string phone, string ssn, string username, string pass)
        {
            driver.Url = url;
            driver.FindElement(registerLnk).Click();
            driver.FindElement(regFnameFld).SendKeys(firstName);
            driver.FindElement(regLnameFld).SendKeys(lastName);
            driver.FindElement(regAddressFld).SendKeys(address);
            driver.FindElement(regCityFld).SendKeys(city);
            driver.FindElement(regStateFld).SendKeys(state);
            driver.FindElement(regZipCodeFld).SendKeys(zipcode);
            driver.FindElement(regPhNoFld).SendKeys(phone);
            driver.FindElement(regSsnFld).SendKeys(ssn);
            driver.FindElement(regUserNameFld).SendKeys(username);
            driver.FindElement(regPassFld).SendKeys(pass);
            driver.FindElement(regRePassFld).SendKeys(pass);
            driver.FindElement(registerBtn).Click();
        }
        #endregion
    }
}
