using System;
using System.CodeDom;
using System.Security.Cryptography;
using System.Threading;
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
            _driver.Navigate().GoToUrl("http://www.pfconcept.com/cgi-bin/wspd_pcdb_cgi.sh/y/y2ypfconcept.p");
        }

        [TestMethod, TestCategory("Smoke")]
        public void LogInAccount()
        {
            _driver.FindElement(By.ClassName("caption"));
            var pageTitle = _driver.Title;
            Assert.AreEqual(pageTitle, "Welcome to PF Concept");

            var accountNumber = _driver.FindElement(By.Id("account_number"));
            accountNumber.SendKeys("121");
            var username = _driver.FindElement(By.Id("user_name"));
            username.SendKeys("yw-am");
            var password = _driver.FindElement(By.Id("user_password"));
            password.SendKeys("a.mak1122");
            var loginButton = _driver.FindElement(By.Id("loginbtn"));
            loginButton.Click();

        }

        [TestMethod, TestCategory("UAT")]
        public void CallAnotherTest()
        {
            Console.WriteLine("This another Test");
        }


        [TestCleanup]
        public void TearDown()
        {
            Thread.Sleep(5000);
        }
          
        
            
        }
    }


