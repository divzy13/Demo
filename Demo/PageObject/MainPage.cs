using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.PageObject
{
    public class MainPage
    {
        public static IWebElement HomeHeading => Browser.Driver.FindElement(By.XPath("//*[@id='main']/header/h1[text()='Mitt konto']"));
        public static IWebElement HomeName => Browser.Driver.FindElement(By.XPath("//*[@id='main']/div[1]/div/div[text()='Divya Raveendran']"));

        public bool Available()
        {
            return Browser.Driver.Title.Contains("Skånetrafiken - Mitt konto");
        }

        public void HomePage()
        {
             HomeName.Text.Contains("Divya Raveendran"); 
        }
    }
}
