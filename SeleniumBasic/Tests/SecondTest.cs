﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    public  class SecondTest : BaseTest
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
    }
}
