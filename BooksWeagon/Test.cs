using BooksWeagon.Base;
using BooksWeagon.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWeagon
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class Test:BaseClass
    {
        IWebDriver driver;
        public Test(string browserName)
        {
            driver = StartBrowser("chrome");
           
        }
        [Test, Order(1)]
        public void LoginTest()
        {

            Login page = new Login(driver);
            page.LoginPage();
        }
        [Test, Order(2)]
       public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}
