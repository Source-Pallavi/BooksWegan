using BooksWeagon.Address;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWeagon.Pages
{
    public class PlaceOrder
    {
        public IWebDriver driver;
        public PlaceOrder(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        public IWebElement SearchTab;

        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$Button1")]
        public IWebElement Search;

        /* [FindsBy(How = How.XPath, Using = "//a[@href='https://www.bookswagon.com/book/wings-fire-au-apj-abdul/9788173711466']")]
         public IWebElement Book;*/

        [FindsBy(How = How.XPath, Using = "//div[@class='search-results fltrs']//div[1]//div[4]//div[5]//a[1]//input[1]")]

        public IWebElement Book;

     /*   [FindsBy(How = How.XPath, Using = "//a[@href='https://www.bookswagon.com/shoppingcart.aspx?pid=3876019&vid=111&ptype=1']")]
        public IWebElement BuyNow;*/
        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//iframe")] 

        public IWebElement frame;

       [FindsBy(How = How.XPath, Using = "//*[@id='BookCart_lvCart_imgPayment']")]

          public IWebElement Placeorder;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div[3]/div[2]/div[1]/div[2]/div/div/div/a")]

        public IWebElement Placeorder1;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-red']")]

        public IWebElement Paynow;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Continue')]")]

        public IWebElement continueButton;
      
       
      


        public IWebElement mobileNumber;
        public void Place()
        {//searching for book
            Thread.Sleep(1000);
            Thread.Sleep(5000);
            SearchTab.SendKeys("Scion of Ikshvaku");
            Search.Click();
            Thread.Sleep(5000);
            //buying the book
            Book.Click();
            Thread.Sleep(5000); 
            driver.SwitchTo().Frame(frame);
            Thread.Sleep(5000);
            // Switching to innerframe
            Placeorder.Click();
            Thread.Sleep(50000);

            Paynow.Click();
            Thread.Sleep(1000);
            IPlaceTheOrder placeOrder;
            placeOrder = new AddressDetails(driver);//address details
            placeOrder.Processing();
            placeOrder = new SavaAndContinue(driver);//*/..
            placeOrder.Processing();
           



        }
    }
}
