using SauceDemoC_.Pages.LoginPage;
using SauceDemoC_.Pages.ProductPage;
using SauceDemoC_.Tests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoC_.Tests.LoginTest
{
    [TestClass]
    public class LoginTest : BaseTest
    {
        [TestMethod]
        public void TestValidLogin()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.Login("standard_user", "secret_sauce");

            var productsPage = new ProductPage(Driver);
            Assert.AreEqual("Products", productsPage.GetPageTitle(), "Login failed.");
        }
    }
}
