using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests
{
    [TestFixture]
    public class WebDriverTest
    {
        [Test]
        public void SimpleDriverTest()
        {
            IWebDriver webdriver = new SimpleDriver().Driver;
            webdriver.Manage().Window.Maximize();
            webdriver.Navigate().GoToUrl("http://onliner.by");
            webdriver.Quit();
            
        }

        [Test]
        public void AdvancedDriverTest()
        {
            IWebDriver webdriver = new AdvancedDriver().GetChromeDriver();
            webdriver.Manage().Window.Maximize();
            webdriver.Navigate().GoToUrl("http://onliner.by");
            webdriver.Quit();

        }

        [Test]
        public void FactoryDriverTest()
        {
            IWebDriver webdriver = new Browser().Driver;
            webdriver.Manage().Window.Maximize();
            webdriver.Navigate().GoToUrl("http://onliner.by");
            webdriver.Quit();

        }
    }
}
