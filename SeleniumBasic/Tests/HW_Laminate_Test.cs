using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    public class HW_Laminate_Test : BaseTest
    {
        [Test]
        public void Laminate()
        {
            Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
            Thread.Sleep(5000);
           // Driver.SwitchTo().Frame(1);

            IWebElement lengthRoomInput = Driver.FindElement(By.Id("ln_room_id"));        // поле ввода Длина комнаты
            IWebElement widthRoomInput = Driver.FindElement(By.Id("wd_room_id"));        // поле ввода Ширина комнаты
            IWebElement lengthPlateInput = Driver.FindElement(By.Id("ln_lam_id"));        // поле ввода Длина плашки
            IWebElement widthPlateInput = Driver.FindElement(By.Id("wd_lam_id"));        // поле ввода Ширина плашки
            IWebElement countPlatesInPackInput = Driver.FindElement(By.Id("n_packing"));        // поле ввода Число плашек в упаковке
            IWebElement areaPackInput = Driver.FindElement(By.Id("area"));         // поле ввода  Площадь упаковки
            IWebElement minLengthSegmentInput = Driver.FindElement(By.Id("min_length_segment_id"));         // поле ввода  Минимальная длина обрезка
            IWebElement indentWallsInput = Driver.FindElement(By.Id("indent_walls_id"));         // поле ввода  Отступ от стен

            IWebElement directionLaminate3RadioButton = Driver.FindElement(By.Id("direction-laminate-id3"));         // радио кнопка Укладка по диагонали 135

            IWebElement LayingMethod = Driver.FindElement(By.Id("laying_method_laminate")); // раскрывающийся список Способ укладки ламината:
            SelectElement selectElementLayingMethod = new SelectElement(LayingMethod);
            selectElementLayingMethod.SelectByValue("2");//выбираем c использованием отрезанного элемента

            lengthRoomInput.Clear(); //очищаем поле от данных по-умолчанию
            lengthRoomInput.SendKeys("400");
            Thread.Sleep(5000);

            widthRoomInput.Clear();
            widthRoomInput.SendKeys("300");
            Thread.Sleep(5000);

            lengthPlateInput.Clear();
            lengthPlateInput.SendKeys("1190");
            Thread.Sleep(5000);

            widthPlateInput.Clear();
            widthPlateInput.SendKeys("250");
            Thread.Sleep(5000);

            countPlatesInPackInput.Clear();
            countPlatesInPackInput.SendKeys("15");
            Thread.Sleep(5000);

            areaPackInput.SendKeys("2");
            Thread.Sleep(5000);

            //minLengthSegmentInput.Clear();
            minLengthSegmentInput.SendKeys("0");
            Thread.Sleep(5000);

            //indentWallsInput.Clear();
            indentWallsInput.SendKeys("0");
            Thread.Sleep(5000);

            directionLaminate3RadioButton.Click();
            Thread.Sleep(5000);
            
            IWebElement calcButton = Driver.FindElement(By.Id("btn_calculate"));// кнопка рассчитать
            calcButton.Click();
            Thread.Sleep(5000);
            
            Console.WriteLine(Driver.FindElement(By.ClassName("calc-result")).Text);
            var result = Driver.FindElement(By.ClassName("calc-result")).Text;
            Assert.That(result.Equals("Требуемое количество плашек ламината: 66\r\nКоличество упаковок ламината: 5\r\nСтоимость ламината: 0 руб\r\nВес ламината: 0 кг"));
        }
    }
}
