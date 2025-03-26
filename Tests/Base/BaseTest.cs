using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoC_.Tests.Base
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected string url = "https://www.saucedemo.com/";
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            string browser = TestContext.Properties["Browser"]?.ToString() ?? "chrome";
            Driver = WebDriverFactory.CreateDriver(browser);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url);
        }

        [TestCleanup]
        public void Teardown()
        {
            Driver.Quit();
        }
    }
}
