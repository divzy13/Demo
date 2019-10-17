
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
        public static string Url { get; set; }
        public static IWebDriver Driver { get; set; }

        [SetUp]
         public static void SetupTest()
         {
            //Driver = new driverfactory().create();
            //_url = configurationhelper.get<string>("url");
           // Browser.Open();
        }


        [Test]
        public static void Openwindow()
        {
            // driver = new ChromeDriver("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32");
            //  var chromeDriverService = ChromeDriverService.CreateDefaultService("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32", "chromedriver.exe");


            // var chromeOptions = new ChromeOptions();
            // chromeOptions.AddArguments("headless");
            // ChromeDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);

           /// Driver.Navigate().GoToUrl(Url);
            LoginPage.LoginWithCred();


        }

        [TearDown]
        public void Close()
        {
            Browser.Driver.Close();
        }

    }
}