using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoC_.Pages.ProductPage
{
    public class ProductPage
    {
        private IWebDriver Driver;
        private By ProductTitle = By.ClassName("title");
        private By AddToCartButton = By.CssSelector(".inventory_item button");

        public ProductPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public string GetPageTitle() => Driver.FindElement(ProductTitle).Text;

        public void AddFirstProductToCart() => Driver.FindElement(AddToCartButton).Click();
    }
}
