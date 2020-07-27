using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BooksWeagon.Base;
using BooksWeagon.Email;
using BooksWeagon.Pages;
using BooksWeagon.ScreenShot;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWeagon
{

    [TestFixture("firefox")]
    [Parallelizable]
    public  class NegativeTest : BaseClass
    {
        IWebDriver driver;
        protected ExtentReports _extent = null;
        protected ExtentTest _test = null;
        ///For report directory creation and HTML report template creation
        ///For driver instantiation
        public static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NegativeTest(string browserName)
        {
            try
            {
                driver = StartBrowser("firefox");
                _extent = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter(@"C:\Users\rebel\source\repos\BooksWeagon\BooksWeagon\Extentreport\extent.html");
                //To create report directory and add HTML report into it
                _extent.AddSystemInfo("User Name", "Pallavi");
                _extent.AttachReporter(htmlReporter);
            }
            catch (Exception e)
            {
                throw (e);
            }

        }
        [Test, Order(1)]
        public void LoginTest()
        {

            Login page = new Login(driver);
            page.LoginPageNeg1();
            log.Info("done");
        }

        [Test, Order(2)]
        public void LoginTest1()
        {
            Login page = new Login(driver);
            page.LoginPageNeg2();
            log.Info("done");
        }
        [Test, Order(3)]
        public void LoginTest2()
        {
            Login page = new Login(driver);
            page.LoginPageNeg3();
            log.Info("done");
        }

        [TearDown]
        public void AfterTest()
        {
            try
            {
                _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
                var errorMessage = TestContext.CurrentContext.Result.Message;
                Status logstatus;
                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        string screenShotPath = ScreenS.Capture(driver, TestContext.CurrentContext.Test.Name);
                        _test.Log(logstatus, "Test ended with " + logstatus + " – " + errorMessage);
                        _test.Log(logstatus, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotPath));
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        _test.Log(logstatus, "Test ended with " + logstatus);
                        break;
                    default:
                        logstatus = Status.Pass;
                        _test.Log(logstatus, "Test ended with " + logstatus);
                        break;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        [OneTimeTearDown]
        public void AfterClass()
        {
            try
            {
                _extent.Flush();
                driver.Close();
                driver.Quit();
                SendEmail.Send_Report_In_Mail();
            }
            catch (Exception e)
            {
                throw (e);
            }

        }
    }
}
