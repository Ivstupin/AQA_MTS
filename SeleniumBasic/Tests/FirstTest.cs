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
    public class FirstTest : BaseTest
    {
        
        [Test]
        public void ValidateIKTCalculationTest()
        {
            
            Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");

            IWebElement weightInput = Driver.FindElement(By.Name("weight"));
            IWebElement heightInput = Driver.FindElement(By.Name("height"));
            IWebElement calcButton = Driver.FindElement(By.Id("calc-mass-c"));
            


            weightInput.SendKeys("80");
            heightInput.SendKeys("183");
            calcButton.Click();

            IWebElement resultText = Driver.FindElement(By.Id("imt-result"));
            Assert.That(resultText.Text, Is.EqualTo("23.9 - Норма"));
            
        }


        [Test]
        public void ValidateSKF()
        {
            Driver.Navigate().GoToUrl("https://bymed.top/calc/%d1%81%d0%ba%d1%84-2148");
            Thread.Sleep(3000);

            Driver.SwitchTo().Frame(1);


            IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
            SelectElement selectElement = new SelectElement(selectDropdown);
            
            selectElement.SelectByIndex(1);
            Thread.Sleep(2000);

            selectElement.SelectByValue("mg");
            Thread.Sleep(2000);

            selectElement.SelectByText("мкмоль/л");
            Thread.Sleep(2000);
        }


    }
}
