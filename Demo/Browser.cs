using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Demo.Utilities;
using Demo.SeleniumHelper;
using Demo.PageObject;

namespace Demo
{
    public class Browser
    {
        public static IWebDriver Driver { get; set; }
        public static string Address { get; set; }


        public Browser(IWebDriver driver)
        {
            Driver = driver;
        }


        public static void Open()
        {
            Driver = new DriverFactory().Create();
            Address = ConfigurationHelper.Get<string>("URL");
            Driver.Url = Address;
        }





    }
}
