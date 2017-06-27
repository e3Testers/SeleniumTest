using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace e3Test2UsingSeleniumIDE.SeleniumSteps
{
    public class GooglePage
    {
        IWebDriver driver;

        [SetUp]
        public void Initialise()
        {
            //Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"C:\Program Files (x86)\Microsoft Visual Studio\Visual Studio 2017\Projects\e3Test2\e3Test2UsingSeleniumIDE");
            //FirefoxDriverService driverService = FirefoxDriverService.CreateDefaultService();
            //driverService.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            //driver = new FirefoxDriver(driverService, new FirefoxOptions(), TimeSpan.FromMilliseconds(600));

            //IWebDriver driver = new RemoteWebDriver("http://localhost:52079");
            //driver.Url = "http://www.google.com";

            /*  FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(*///@"C:\Program Files (x86)\Microsoft Visual Studio\Visual Studio 2017\Projects\e3Test2\e3Test2UsingSeleniumIDE");
            string baseDir = @"C:\Users\rob.localadmin\Selenium";
            //C:\Users\rob.localadmin\Selenium
            //C:\Program Files (x86)\Microsoft Visual Studio\Visual Studio 2017\Projects\e3Test2\e3Test2UsingSeleniumIDE\
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", baseDir);
            IWebDriver driver = new ChromeDriver(baseDir);
            //@"C:\Program Files (x86)\Microsoft Visual Studio\Visual Studio 2017\Projects\e3Test2\e3Test2UsingSeleniumIDE"
        }


        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestName()
        {
            driver.Url = "http://www.google.com";

        }


        [TearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
            driver = null;

        }
    }
}
