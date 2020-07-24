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
    public class BookSearch : IPlaceTheOrder
    {
    public IWebDriver driver;
    public BookSearch(IWebDriver driver)
    {
        this.driver = driver;
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]

    public IWebElement SearchTab;

    [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$Button1")]

    public IWebElement Search;

    [FindsBy(How = How.XPath, Using = "//div[@class='search-results fltrs']//div[1]//div[4]//div[5]//a[1]//input[1]")]

    public IWebElement Book;
        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//iframe")]

        public IWebElement frame;

        [FindsBy(How = How.XPath, Using = "//*[@id='BookCart_lvCart_imgPayment']")]

        public IWebElement Placeorder;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div[3]/div[2]/div[1]/div[2]/div/div/div/a")]

        public IWebElement Placeorder1;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-red']")]

        public IWebElement Paynow;

        public void Processing() {

            Thread.Sleep(5000);
            SearchTab.SendKeys("Scion of Ikshvaku");
            Search.Click();
            Thread.Sleep(5000);

            Book.Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(frame);
            Thread.Sleep(5000);
            // Switching to innerframe
            Placeorder.Click();
            Thread.Sleep(50000);
            Paynow.Click();
            Thread.Sleep(1000);

        }
    }
}
