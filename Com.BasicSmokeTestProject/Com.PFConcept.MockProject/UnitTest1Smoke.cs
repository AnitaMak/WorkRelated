using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Com.PFConcept.MockProject
{
    [TestClass]
    public class UnitTest1Smoke
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetUpTest()
        {
          _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.pfconcept.com");
        }

        [TestMethod]
        public void GetPageTitle()
        {
            Console.WriteLine("This is a Test to get the Page Title");
            string PageTitle = _driver.Title;
            Assert.AreEqual(PageTitle, "PFConcept.com");

        }

        [TestMethod]
        public void CallAnotherTest()
        {
            Console.WriteLine("This another Test");
        }

        [TestCleanup]
        public void TearDown()
          
        {
            _driver.Quit();
        }
    }

}
