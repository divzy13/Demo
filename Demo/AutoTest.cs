
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

namespace Demo
{
    class AutoTest
    {
        IWebDriver driver;

        
        [Test]
        public void Openwindow()
        {
           // driver = new ChromeDriver("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32");
            
            String url = "http://www.google.com";
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

          //  var chromeDriverService = ChromeDriverService.CreateDefaultService("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32", "chromedriver.exe");
            ChromeDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            driver.Navigate().GoToUrl(url);



           // driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.Manage().Window.Maximize();
            driver.Quit();


        }

    }
}