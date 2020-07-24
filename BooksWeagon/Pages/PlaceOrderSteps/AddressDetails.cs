using BooksWeagon.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWeagon.Address
{
   public class AddressDetails: IPlaceTheOrder
    {
        public IWebDriver driver;
        public AddressDetails(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

       

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewRecipientName")]

        public IWebElement receiptName;

        [FindsBy(How = How.XPath, Using = "//div[4]//div[2]//textarea[1]")]

        public IWebElement address;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewState")]

        public IWebElement state;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCity")]

        public IWebElement city;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]

        public IWebElement pinCode;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewMobile")]

        public IWebElement mobileNumber;

       /* [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]

        public IWebElement saveAndContinue;*/
        public void Processing()
        {

            Thread.Sleep(1000);
            receiptName.Click();
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
            Thread.Sleep(1000);
           /* saveAndContinue.Click();
            Thread.Sleep(2000);*/
        }
    }
}
