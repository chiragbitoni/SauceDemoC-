using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoC_.Pages.LoginPage
{
    public class LoginPage
    {
        private IWebDriver Driver;

        //Locators
        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        //Actions
        public void EnterUsername(string username)
        {
            Driver.FindElement(usernameField).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            Driver.FindElement(passwordField).SendKeys(password);
        }
        public void ClickLogin()
        {
            Driver.FindElement(loginButton).Click();
        }
        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }
    }
}
