using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    public class HW_SKF_Test : BaseTest
    {

        [Test]
        [Retry(3)]
      
        public void ValidateSKF()
        {

            Driver.Navigate().GoToUrl("https://bymed.top/calc/%d1%81%d0%ba%d1%84-2148");
            Thread.Sleep(3000);

            Driver.SwitchTo().Frame(0);

            IWebElement ageInput = Driver.FindElement(By.Id("age"));        // поле ввода возраст
            IWebElement creatininInput = Driver.FindElement(By.Name("cr")); // поле ввода Креатинин
            IWebElement massInput = Driver.FindElement(By.Name("mass")); // поле ввода Масса тела
            
            IWebElement selectDropdownSex = Driver.FindElement(By.Id("sex")); // раскрывающийся список Пол
            SelectElement selectElementSex = new SelectElement(selectDropdownSex);
            selectElementSex.SelectByIndex(1);//выбираем женский

            IWebElement selectDropdownCr = Driver.FindElement(By.Id("cr-size"));
            SelectElement selectElementCreatininOptions = new SelectElement(selectDropdownCr); // раскрывающийся список мкмоль/ммоль/мг
            selectElementCreatininOptions.SelectByValue("mg");//выбираем мг

            IWebElement calcButton = Driver.FindElement(By.TagName("button"));// кнопка рассчитать
            
            ageInput.SendKeys("30");
            creatininInput.SendKeys("10");
            massInput.SendKeys("80");
            calcButton.Click();
            
            IWebElement resultMdrd = Driver.FindElement(By.Id("mdrd_res"));
            Assert.That(resultMdrd.Text, Is.EqualTo("4.57"));

            IWebElement resultCkd_Epi = Driver.FindElement(By.Id("ckd_epi_res"));
            Assert.That(resultCkd_Epi.Text, Is.EqualTo("4.67"));

            IWebElement resultCockcroft_Gault = Driver.FindElement(By.Id("cge_res"));
            Assert.That(resultCockcroft_Gault.Text, Is.EqualTo("10.39"));

        }
    }
}
