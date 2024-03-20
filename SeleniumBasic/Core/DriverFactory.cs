﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using LogLevel = OpenQA.Selenium.LogLevel;
using System.Reflection;

namespace SeleniumBasic.Core;

public class DriverFactory
{
    public IWebDriver? GetChromeDriver()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArguments("--incognito");
        //chromeOptions.AddArguments("--disable-gpu");
        chromeOptions.AddArguments("--disable-extensions");
        //chromeOptions.AddArguments("--headless");

        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string pathForDownloadsByDefault = Path.Combine(assemblyPath, "Downloads");
        chromeOptions.AddUserProfilePreference("download.default_directory", pathForDownloadsByDefault);// включение опции - папка для скачивания по-умолчанию
        
        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        new DriverManager().SetUpDriver(new ChromeConfig());
        return new ChromeDriver(chromeOptions);
    }

    public IWebDriver? GetFirefoxDriver()
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

        new DriverManager().SetUpDriver(new FirefoxConfig());
        return new FirefoxDriver(ffOptions);
    }
}