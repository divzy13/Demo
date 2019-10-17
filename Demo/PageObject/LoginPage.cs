using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using Demo.Utilities;
using Demo.Test_Data;



namespace Demo.PageObject
{
    public class LoginPage
    {
        DataBase dataBase = new DataBase();
        
        public static IWebElement LoginButton => Browser.Driver.FindElement(By.XPath("//nav[@id='desktop-menubar-nav-element']//a[@class='myaccount-icon']"));

        public static IWebElement CookiesClear => Browser.Driver.FindElement(By.Id("generalbtncookieok"));
        public static IWebElement UserNameField => Browser.Driver.FindElement(By.Id("loginInputModel_Email"));
        public static IWebElement passwordField => Browser.Driver.FindElement(By.Id("loginInputModel_Password"));

        public string cmd = "select Username from dbo.UserField where coloumn= 1";
        public static IWebElement SubmitLogin => Browser.Driver.FindElement(By.XPath("//*[@id='form0']//button[@title='Logga in till ditt konto']"));

        public static void LoginWithCred()
        {
            DataBase.GetInfo(10);
            LoginButton.Click();
            CookiesClear.Click();
            UserNameField.Click();
            UserNameField.SendKeys();
            passwordField.Click();
            passwordField.SendKeys("divya131");
            //SubmitLogin.Click();
        }
    }

}