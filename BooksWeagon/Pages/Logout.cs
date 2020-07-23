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
   public class Logout
    {
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

     //   [FindsBy(How = How.XPath, Using = "//span[@class='login-bg sprite usermenu-bg']")]
      //  public IWebElement AccountSetting;

        [FindsBy(How = How.XPath, Using = "//a[@id='ctl00_lnkbtnLogout']")]
        public IWebElement Log;

        public void LogOut()
        {
          //  AccountSetting.Click();
            Thread.Sleep(5000);
            Log.Click();
        }
    }
}
