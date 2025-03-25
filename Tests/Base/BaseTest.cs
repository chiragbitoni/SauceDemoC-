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

        [TestInitialize]
        public void Setup()
        {
            Driver = new ChromeDriver();
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
