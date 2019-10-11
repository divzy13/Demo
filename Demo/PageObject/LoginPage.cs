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
    public class LoginPage
    {
        public static IWebElement LoginButton => Browser.Driver.FindElement(By.XPath("//*[@id='desktop - menubar - nav - element']//a[text()='Mitt konto'])]"));
        public static IWebElement UserNameField => Browser.Driver.FindElement(By.Id("loginInputModel_Email"));
        public static IWebElement passwordField => Browser.Driver.FindElement(By.Id("loginInputModel_Password"));

        public string cmd = "select Username from dbo.UserField where coloumn= 1";
        public static IWebElement SubmitLogin => Browser.Driver.FindElement(By.XPath("//*[@id='form0']//button[@title='Logga in till ditt konto']"));

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