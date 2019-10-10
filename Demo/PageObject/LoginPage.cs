using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace Demo.PageObject
{
    public RemoteWebDriver _driver;
    public class LoginPage(_driver)
    {

        public static IWebDriver Driver => new RemoteWebDriver(_driver);


        //[FindsBy(How = How.XPath, Using = "
        public static IWebElement LoginButton => driver.FindElementByXPath("//*[@id='desktop - menubar - nav - element']//a[text()='Mitt konto'])]");

        [FindsBy(How = How.Id, Using = "loginInputModel_Email")]
        public static IWebElement UserNameField { get; set; }

        public static IWebElement UserNameField => driver.FindElementByClassName("//*[@id='desktop - menubar - nav - element']//a[text()='Mitt konto'])]");


        [FindsBy(How = How.Id, Using = "loginInputModel_Password")]
        public static IWebElement passwordField { get; set; }

        public string cmd = "select Username from dbo.UserField where coloumn= 1";

        [FindsBy(How = How.XPath, Using = "//*[@id='form0']//button[@title='Logga in till ditt konto']")]
        public static IWebElement SubmitLogin { get; set; }

        public static void LoginWithCred()
        {
            UserNameField.Click();
            UserNameField.SendKeys("divzy13@gmail.com");
            passwordField.Click();
            passwordField.SendKeys("divya131");
            SubmitLogin.Click();
        }
    }
}
