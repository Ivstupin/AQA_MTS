using OpenQA.Selenium;
using SeleniumBasic.Helpers.Configuration;
using SeleniumBasic.Tests;


namespace SauceDemo.Tests
{
    public  class HW_SauceDemoTest : BaseTest
    {
        [Test]
        
        public void sauceDemoLocatorsTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

            // Find webElement by ID
            Driver.FindElement(By.Id("user-name")).SendKeys(Configurator.AppSettings.Username);
            // Find webElement by css #id
            Assert.That(Driver.FindElement(By.CssSelector("#user-name")).Displayed);

            // Find webElement by Name
            Driver.FindElement(By.Name("password")).SendKeys(Configurator.AppSettings.Password);
            // Find webElement by css .class
            Assert.That(Driver.FindElement(By.CssSelector(".error-message-container")).Displayed);

            // Find webElement by ClassName
            Driver.FindElement(By.ClassName("btn_action")).Click();
            // Find webElement by css .class1.class2
            Assert.That(Driver.FindElements(By.CssSelector(".btn.btn_inventory")).Count, Is.EqualTo(6));

            // Find webElement by TagName
            Assert.That(Driver.FindElements(By.TagName("div")).Count, Is.EqualTo(71));
            // Find webElement by css tagname
            Assert.That(Driver.FindElements(By.CssSelector("img")).Count, Is.EqualTo(8));

            // Find webElement by LinkText
            Assert.That(Driver.FindElement(By.LinkText("Sauce Labs Bolt T-Shirt")).Displayed);
            // Find webElement by PartialLinkText
            Assert.That(Driver.FindElement(By.PartialLinkText("Labs")).Displayed);

            // Find webElement by css .class1 .class2
            Assert.That(Driver.FindElements(By.CssSelector(".inventory_list .inventory_item_img")).Count, Is.EqualTo(12));

            // Find webElement by css tagname.class
            Assert.That(Driver.FindElement(By.CssSelector("div.header_label")).Displayed);

            // Find webElement by css [attribute=value]
            Assert.That(Driver.FindElements(By.CssSelector("[src = '/static/media/red-tatt-1200x1500.30dadef4.jpg']")).Count, Is.EqualTo(1));

            // Find webElement by css [attribute~=value]
            Assert.That(Driver.FindElements(By.CssSelector("[alt ~= 'Backpack']")).Count, Is.EqualTo(1));

            // Find webElement by css [attribute|=value]
             Assert.That(Driver.FindElements(By.CssSelector("[rel |= 'apple']")).Count, Is.EqualTo(1));

            // Find webElement by css [attribute^=value]
            Assert.That(Driver.FindElements(By.CssSelector("[rel ^= 'apple-tou']")).Count, Is.EqualTo(1));

            // Find webElement by css [attribute$=value]
             Assert.That(Driver.FindElements(By.CssSelector("[src $= '.jpg']")).Count, Is.EqualTo(6));

            // Find webElement by css [attribute*=value]
            Assert.That(Driver.FindElements(By.CssSelector("[alt *= 'Labs']")).Count, Is.EqualTo(5));


            // Find webElement by Xpath Поиск по атрибуту, например By.xpath("//tag[@attribute='value']");
            Assert.That(Driver.FindElement(By.XPath("//div[@class= 'header_label']")).Displayed);

            // Find webElement by XpathПоиск по тексту, например By.xpath("//tag[text()='text']");
            Assert.That(Driver.FindElement(By.XPath("//div[text()='Sauce Labs Backpack']")).Displayed);

            // Find webElement by Xpath Поиск по частичному совпадению атрибута, например By.xpath("//tag[contains(@attribute,'text')]");
            Assert.That(Driver.FindElement(By.XPath("//*[contains(@value, 'loh')]")).Displayed);

            // Find webElement by Xpath Поиск по частичному совпадению текста, например By.xpath("//tag[contains(text(),'text')]");
            Assert.That(Driver.FindElement(By.XPath("//div[contains(text(),'hemmed sle')]")).Displayed);

            // Find webElement by Xpath ancestor, например //*[text()='Enterprise Testing']//ancestor::div
              Assert.That(Driver.FindElement(By.XPath("//*[text()='Sauce Labs Onesie']//ancestor::body")).Displayed);

            // Find webElement by Xpath descendant
            Assert.That(Driver.FindElement(By.XPath("//div[@id = 'inventory_container']/descendant::div")).Displayed);

            // Find webElement by Xpath following
             Assert.That(Driver.FindElement(By.XPath("//div[@id = 'inventory_container']/following::div")).Displayed);

            // Find webElement by Xpath parent
            Assert.That(Driver.FindElement(By.XPath("//*[text()='Sauce Labs Onesie']//..")).Displayed);

            // Find webElement by Xpath preceding
            Assert.That(Driver.FindElement(By.XPath("//div[@id = 'inventory_container']/preceding::div")).Displayed);

            // Find webElement by Xpath *поиск элемента с условием AND, например //input[@class='_2zrpKA _1dBPDZ' and @type='text']
            Assert.That(Driver.FindElement(By.XPath("//div[@id='shopping_cart_container' and @class='shopping_cart_container']")).Displayed);



        }


    }
}
