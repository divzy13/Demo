
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
using Demo.PageObject;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;

namespace Demo
{
    public class AutoTest
    {
        public static string _url;
        public static IWebDriver _driver;

        [SetUp]
        // public static void SetupTest()
        // {
        //     _driver = new DriverFactory().Create();
        //    PageFactory.InitElements(_driver, new AutoTest());
        //    _url = ConfigurationHelper.Get<string>("URL");
        //}

        public static void SetupTest(RemoteWebDriver driver) => _driver = driver;
        
        [Test]
        public static void Openwindow()
        {
            // driver = new ChromeDriver("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32");
            //  var chromeDriverService = ChromeDriverService.CreateDefaultService("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32", "chromedriver.exe");


            // var chromeOptions = new ChromeOptions();
            // chromeOptions.AddArguments("headless");
            // ChromeDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);

            _driver.Navigate().GoToUrl(_url);
            LoginPage.LoginWithCred();


        }

        [TearDown]
        public void Close()
        {
            _driver.Quit();
        }

    }
}