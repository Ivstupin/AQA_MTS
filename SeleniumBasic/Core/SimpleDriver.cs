using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SeleniumBasic.Core
{
    public class SimpleDriver
    {
        public IWebDriver Driver
        { 
            get
            {
                var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

                //return new ChromeDriver(
                //@"\Users\greck\source\repos\AQA_MTS\SeleniumBasic\Resources\");
                //return new ChromeDriver(basePath + @"/Resources/");
                return new ChromeDriver();
            }
        }
    }
}
