using BooksWeagon.NewFolder1;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWeagon.Pages
{
  public  class Login
    {
        public IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtEmail")]
        public IWebElement Userid;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_txtPassword']")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_btnLogin']")]
        public IWebElement SignIn;

        public void LoginPage()
        {
              CredentialsData credentials = new CredentialsData();
              Userid.SendKeys(credentials.email);
              Password.SendKeys(credentials.password);

            SignIn.Click();
            Thread.Sleep(5000);
        }

    }
}
