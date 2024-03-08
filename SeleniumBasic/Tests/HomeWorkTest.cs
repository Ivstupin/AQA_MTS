using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumBasic.Helpers;
using SeleniumBasic.Tests;
using System.Reflection;

namespace SeleniumAdvanced.Tests
{
    public class HomeWorkTest : BaseTest
    {
        [Test]
        [Order(1)]
        public void ContextMenuTest()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");

            Actions actionsRMB = new Actions(Driver);

            actionsRMB.ContextClick(Driver.FindElement(By.Id("hot-spot"))).Build().Perform();

            IAlert alert = Driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));

            alert.Accept();
        }

        [Test]
        [Order(2)]
        public void DynamicControlsTest()
        {
            WaitsHelper waitsHelper = new(Driver, TimeSpan.FromSeconds(30));

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");

            IWebElement checkboxA = waitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("[label= 'blah']")); // находим локатор чек-бокса и проверяем отображение

            IWebElement buttonRemove = waitsHelper.WaitForVisibilityLocatedBy(By.XPath("//button[contains(text(),'Remove')]")); // находим локатор кнопки Remove проверяем отображение
            buttonRemove.Click(); // жмём кнопку Remove
            
            IWebElement messageAfterRemove = waitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@id='message']"));// находим локатор надписи It’s gone и проверяем отображение

            Assert.Multiple(() =>
            {
                Assert.That(messageAfterRemove.Text, Is.EqualTo("It's gone!")); // сверяем текст
                Assert.That(waitsHelper.WaitForElementInvisible(checkboxA)); // проверка чек-бокса на видимость > чек-бокс пропал
            });

            IWebElement input = waitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@id='input-example']/input"));  // находим локатор инпута и проверяем отображение
            Assert.That(!input.Enabled); // input disabled 

            IWebElement buttonEnable = waitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("[onclick= 'swapInput()']")); // находим локатор кнопки Enable и проверяем отображение
            buttonEnable.Click(); // жмём кнопку Enable

            IWebElement messageAfterEnable = waitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@id='message']")); // находим локатор надписи It's enabled и проверяем отображение
            Assert.Multiple(() =>
            {
                Assert.That(messageAfterEnable.Text, Is.EqualTo("It's enabled!")); // сверяем текст
                Assert.That(input.Enabled); // input Enabled
            });
        }

        [Test]
        [Order(3)]
        public void FileUploadTest()
        {
            WaitsHelper waitsHelper = new(Driver, TimeSpan.FromSeconds(30));

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            var fileUploadElement = WaitsHelper.WaitForExists(By.Id("file-upload"));

            // Получаем путь к исполняемому файлу (exe)
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // Конструируем путь к файлу внутри проекта
            string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");
           
            fileUploadElement.SendKeys(filePath);
            
            WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
            
            IWebElement nameFileAfterUploadOnPage = waitsHelper.WaitForVisibilityLocatedBy(By.Id("uploaded-files"));

            Assert.That(nameFileAfterUploadOnPage.Text, Is.SubsetOf(filePath));

            Thread.Sleep(5000);
        }

        [Test]
        [Order(4)]
        public void FramesTest()
        {
            WaitsHelper waitsHelper = new(Driver, TimeSpan.FromSeconds(30));

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/iframe");

            Driver.SwitchTo().Frame(Driver.FindElement(By.Id("mce_0_ifr")));

            IWebElement textInParagraph = waitsHelper.WaitForVisibilityLocatedBy(By.XPath("//p[contains(text(),'Your content goes here.')]"));
            
            Assert.That(textInParagraph.Text, Is.EqualTo("Your content goes here."));
        }

        [Test]
        [Order(5)]
        public void FileDownloadTest()
        {
            _ = new WaitsHelper(Driver, TimeSpan.FromSeconds(30));

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            
            var fileDownloadElement = WaitsHelper.WaitForExists(By.XPath("//*[contains(text(),'checkout-confirmation.pdf')]"));
            
            fileDownloadElement.Click();

            Thread.Sleep(5000);
            
            fileDownloadElement.Click();
            
            Thread.Sleep(15000);
            string fileDownloadName = fileDownloadElement.Text.ToString();
            
            Console.WriteLine(File.Exists(fileDownloadName) ? "Файл создан" : "Файл не создан");  // папка для скачивания по-умолчанию задана в DriverFactory 

            FileInfo fileInfo = new FileInfo(fileDownloadName);
            if (fileInfo.Exists)
            {
                Console.WriteLine($"Имя файла: {fileInfo.Name}");
                Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Размер: {fileInfo.Length}");
            }
        }

    }
}
