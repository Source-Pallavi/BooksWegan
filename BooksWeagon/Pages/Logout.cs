using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWeagon.Pages
{
    class Logout
    {
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[@class='login-bg sprite usermenu-bg']")]
        public IWebElement AccountSetting;

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        public IWebElement Log;

        public void LogOut()
        {
            AccountSetting.Click();
            Thread.Sleep(50000);
            Log.Click();
        }
    }
}
