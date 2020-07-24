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
    class SavaAndContinue:IPlaceTheOrder
    {
        public IWebDriver driver;
        public SavaAndContinue(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]

        public IWebElement saveAndContinue;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_cpBody_ShoppingCart_lvCart_savecontinue']")]
        public IWebElement SaveAndContinue;
        public  void Processing()
        {
            saveAndContinue.Click();
            Thread.Sleep(2000);
            SaveAndContinue.Click();
            Thread.Sleep(2000);
        }
    }
}
