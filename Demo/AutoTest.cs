
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using OpenQA.Selenium.Firefox;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Demo.Utilities;
using Demo.SeleniumHelper;

namespace Demo
{
    class AutoTest
    {
        private string _url;
        private IWebDriver _driver;

        [SetUp]
        public void SetupTest()
        {
            _driver = new DriverFactory().Create();
            _url = ConfigurationHelper.Get<string>("URL");
        }
        
        [Test]
        public void Openwindow()
        {
            // driver = new ChromeDriver("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32");
            //  var chromeDriverService = ChromeDriverService.CreateDefaultService("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32", "chromedriver.exe");


            // var chromeOptions = new ChromeOptions();
            // chromeOptions.AddArguments("headless");
            // ChromeDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);

            _driver.Navigate().GoToUrl(_url);

        }

        [TearDown]
        public void Close()
        {
            _driver.Quit();
        }

    }
}