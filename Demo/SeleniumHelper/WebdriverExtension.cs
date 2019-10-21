using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Demo.Utilities;

namespace Demo.SeleniumHelper
{
    public class WebdriverExtension
    {

        public static void Wait(int miliseconds)
        {
            int maxTimeOutSeconds = ConfigurationHelper.Get<int>("Wait");
            var wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 1, maxTimeOutSeconds));
            var delay = new TimeSpan(0, 0, 0, 0, miliseconds);
            var timestamp = DateTime.Now;
            wait.Until(webDriver => (DateTime.Now - timestamp) > delay);
        }
    }
}
