using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Core
{
    public class AdvancedDriver
    {
        private string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public IWebDriver GetChromeDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--disable-extensions");
            //chromeOptions.AddArgument("--headless");

            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

            return new ChromeDriver(basePath + @"/Resources/",chromeOptions);
        }

        public IWebDriver GetFirefoxDriver()
        {
            var mimeTypes =
            "image/png,image/gif,image/jpeg,image/pjpeg,application/pdf,text/csv,application/vnd.ms-excel," +
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" +
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

            var ffOptions = new FirefoxOptions();
            var profile = new FirefoxProfile();

            profile.SetPreference("browser.download.folderList", 2);
            profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", mimeTypes);
            profile.SetPreference("browser.helperApps.neverAsk.openFile", mimeTypes);
            ffOptions.Profile = profile;

            ffOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

            return new FirefoxDriver(ffOptions);
        }
    }
}