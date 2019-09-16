
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class AutoTest
    {
        IWebDriver driver;

        
        [Test]
        public void Openwindow()
        {
            driver = new ChromeDriver("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32");
            driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.Manage().Window.Maximize();
            driver.Quit();

        }

    }
}