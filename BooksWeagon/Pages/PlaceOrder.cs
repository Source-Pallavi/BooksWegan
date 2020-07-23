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
        //div[@class='checkout-bg']
        [FindsBy(How = How.XPath, Using = "//div[@class='new']")]

        public IWebElement Frame;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_cpBody_txtNewRecipientName']")]

        public IWebElement receiptName;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='ctl00_cpBody_txtNewAddress']")]

        public IWebElement address;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewState")]

        public IWebElement state;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCity")]

        public IWebElement city;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]

        public IWebElement pinCode;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewMobile")]

        public IWebElement mobileNumber;

      /*  [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]

        public IWebElement saveAndContinue;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_cpBody_ShoppingCart_lvCart_savecontinue']")]
        public IWebElement SaveAndContinue;*/
        public void Place()
        {
            Thread.Sleep(5000);
            SearchTab.SendKeys("Scion of Ikshvaku");
            Search.Click();
            Thread.Sleep(5000);

            Book.Click();
            Thread.Sleep(5000); 

            /*BuyNow.Click();
            Thread.Sleep(5000);*/

            driver.SwitchTo().Frame(frame);
            Thread.Sleep(5000);
            // Switching to innerframe
            Placeorder.Click();
            Thread.Sleep(5000);
            Paynow.Click();
            // Placeorder1.Click();
          //  continueButton.Click();
            Thread.Sleep(1000);
          //  driver.SwitchTo().Frame(Frame);
          /*  receiptName.Click();
            Thread.Sleep(1000);
            receiptName.SendKeys("Pallavi");
            Thread.Sleep(1000);
            address.Click();
            Thread.Sleep(1000);
            address.SendKeys("G-25 Narmada Nagar, Khandwa");
            Thread.Sleep(1000);
            SelectElement selectState = new SelectElement(state);
            Thread.Sleep(1000);
            selectState.SelectByText("Madhya Pradesh");
            Thread.Sleep(1000);
            city.Click();
            Thread.Sleep(1000);
            city.SendKeys("Indore");
            Thread.Sleep(1000);
            pinCode.Click();
            Thread.Sleep(1000);
            pinCode.SendKeys("450001");
            Thread.Sleep(1000);
            mobileNumber.Click();
            Thread.Sleep(1000);
            mobileNumber.SendKeys("6232077345");
            Thread.Sleep(1000);*/
            /*   saveAndContinue.Click();
               Thread.Sleep(2000);
               SaveAndContinue.Click();
               Thread.Sleep(2000);*/
            IPlaceTheOrder placeOrder;
            placeOrder = new AddressDetails(driver);
            placeOrder.Processing();
            placeOrder = new SavaAndContinue(driver);
            placeOrder.Processing();
           



        }
    }
}
