using OpenQA.Selenium;
using System;

namespace ST_Project
{
    [TestClass]
    public class TestExecutionClass
    {
        LoginAndRegistrationPage loginPage = new LoginAndRegistrationPage();
        NewAccountPage accountPage = new NewAccountPage();
        TransferFundPage transferPage = new TransferFundPage();
        BillPaymentPage billPage = new BillPaymentPage();
        LoanRequestPage loanPage = new LoanRequestPage();
        UpdateInfoPage updatePage = new UpdateInfoPage();

        [TestInitialize]
        public void TestInit()
        {
            BasePage.SeleniumInit("Chrome");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.SeleniumCleanUp();
        }

        [TestMethod]
        public void LoginWithCorrectCredentials()
        {
            loginPage.login("https://parabank.parasoft.com/parabank/index.htm","hasgatta","hassaan");
            Thread.Sleep(1000);
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/p/b")).Text;
            Assert.AreEqual("Welcome", actualtext);
        }
        [TestMethod]
        public void ForgetUsernamePassword()
        {
            loginPage.forgetUnamePass("https://parabank.parasoft.com/parabank/index.htm","Hassaan","Gatta","Street 1","Karachi","Sindh","789345","12345678");
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/p[1]")).Text;
            Assert.AreEqual("Your login information was located successfully. You are now logged in.", actualtext);
        }
        [TestMethod]
        public void RegisterNewUser()
        {
            loginPage.register("https://parabank.parasoft.com/parabank/index.htm", "Hassaan", "Gatta", "Street 1", "Karachi", "Sindh", "789345", "02123456789", "12345678", "hasgatta", "hassaan");
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/p")).Text;
            Assert.AreEqual("Your account was created successfully. You are now logged in.", actualtext);
        }
        [TestMethod]
        public void OpenNewAccount()
        {
            loginPage.login("https://parabank.parasoft.com/parabank/index.htm", "hasgatta", "hassaan");
            accountPage.CreateAccount("Savings", "18450");
            Thread.Sleep(1000);
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[2]/p[1]")).Text;
            Assert.AreEqual("Congratulations, your account is now open.", actualtext);
        }
        [TestMethod]
        public void TransferMoney()
        {
            loginPage.login("https://parabank.parasoft.com/parabank/index.htm", "hasgatta", "hassaan");
            transferPage.Transfer("50", "17784", "18672");
            Thread.Sleep(1000);
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[2]/h1")).Text;
            Assert.AreEqual("Transfer Complete!", actualtext);
        }
        [TestMethod]
        public void PayBill()
        {
            loginPage.login("https://parabank.parasoft.com/parabank/index.htm", "hasgatta", "hassaan");
            billPage.PayBill("Hassaan","Street 1","Karachi","Sindh","789345","02123456789","13566","20","13677");
            Thread.Sleep(1000);
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[2]/h1")).Text;
            Assert.AreEqual("Bill Payment Complete", actualtext);
        }
        [TestMethod]
        public void ApplyLoan()
        {
            loginPage.login("https://parabank.parasoft.com/parabank/index.htm", "hasgatta", "hassaan");
            loanPage.loanRequest("200", "10", "14121");
            Thread.Sleep(1000);
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[2]/div[2]/p[1]")).Text;
            Assert.AreEqual("Congratulations, your loan has been approved.", actualtext);
        }
        [TestMethod]
        public void UpdateAddressInfo()
        {
            loginPage.login("https://parabank.parasoft.com/parabank/index.htm", "hasgatta", "hassaan");
            updatePage.updateInfo("", "", "Street 2", "", "", "", "");
            Thread.Sleep(1000);
            String actualtext = BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div[2]/p")).Text;
            Assert.AreEqual("Your updated address and phone number have been added to the system.", actualtext);
        }

    }
}