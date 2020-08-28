using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWeagon.Base
{
    public class BaseClass//base class for returning the driver its a factory class
    {
        IWebDriver driver = null;
       
        public IWebDriver StartBrowser(String browserName)
        {
           //browser factory
            try
            {
                if (browserName.ToLower().Equals("")) throw (new Exception("BROWSER_NAME is not specified"));
                if (browserName.ToLower().Equals("chrome")) driver = new ChromeDriver();//return chrome driver
                if (browserName.ToLower().Equals("firefox")) driver = new FirefoxDriver();//return firefox driver
            }
            catch (Exception e)
            {
                throw (new Exception("BROWSER_NAME is not specified"));
            }
            driver.Url = "https://www.bookswagon.com/login";//initializing url
            driver.Manage().Window.Maximize();//maxinizing the window
            return driver;//returns the driver
        }
        
    }
}
