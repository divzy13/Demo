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
        public string URL { get; set; }

        public Browser()
        {
            Driver = new DriverFactory().Create();
            URL = ConfigurationHelper.Get<string>("URL");
        }


        public static void Open(string URL)
        {
            Driver.Url = URL;
        }






    }
}
