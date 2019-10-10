using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using Demo.Utilities;
using System.IO;
using System.Reflection;

namespace Demo.SeleniumHelper
{
    public enum DriverName
    {
        Firefox,
        Chrome,
        InternetExplorer

    }

    public class DriverFactory
    {
        public static FirefoxOptions FirefoxOptions
        {
            get
            {
                var firefoxprofile = new FirefoxOptions();
                firefoxprofile.SetPreference("network.automatic-ntlm-auth.trusted-uris", "http://localhost");
                return firefoxprofile;

            }
        }

        public IWebDriver Create()
        {
            IWebDriver driver;
            var driverName = ConfigurationHelper.Get<DriverName>("DriverName");
            switch(driverName)
            {
                case DriverName.Chrome:
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("headless");
                    driver = new ChromeDriver("C:\\Users\\divya.raveendran\\Downloads\\chromedriver_win32");
                   // driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
                    break;

                case DriverName.Firefox:
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\divya.raveendran\Downloads\geckodriver-v0.25.0-win64", "geckodriver.exe");
                    //Give the path of the Firefox Browser        
                    service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    driver = new FirefoxDriver(service);

                   // var firefoxProfile = FirefoxOptions;
                    // driver = new FirefoxDriver(firefoxProfile);
                    driver.Manage().Window.Maximize();
                    break;

                case DriverName.InternetExplorer:
                    driver = new InternetExplorerDriver(AppDomain.CurrentDomain.BaseDirectory, new InternetExplorerOptions(), TimeSpan.FromMinutes(5));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();

            }

            driver.Manage().Window.Maximize();
            var TimeOut = driver.Manage().Timeouts();

            TimeOut.ImplicitWait = TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("Wait"));
            TimeOut.PageLoad = TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("Wait"));

            return driver;
        }


    }
}
