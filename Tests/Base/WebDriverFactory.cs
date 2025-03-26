using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoC_.Tests.Base
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver(string browser)
        {

            return browser.ToLower() switch
            {
                "chrome" => new ChromeDriver(),
                "firefox" => new FirefoxDriver(),
                "edge" => new EdgeDriver(),
                _ => throw new System.ArgumentException($"Browser '{browser}' is not supported")
            };
        }

        private static string GetBrowserFromConfig()
        {
            string configPath = "appsetings.json";
            if (File.Exists(configPath))
            {
                var json = File.ReadAllText(configPath);
                var jsonObj = JObject.Parse(json);
                return jsonObj["Browser"]?.ToString() ?? "chrome";
            }
            return "chrome";
        }
    }
}
