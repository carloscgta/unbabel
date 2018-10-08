using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Drawing.Imaging;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using Unbabel.Annotation.Test.UI.Environment;


namespace Unbabel.Annotation.Test.UI.Appium.Drivers
{
    public class IWebDriverProvider
    {
        public static IWebDriver webDriverElement { get; set; }

        public DesiredCapabilities GetAndroidCapabilities()
        {
            DesiredCapabilities caps = new DesiredCapabilities();

            try
            {
                caps.SetCapability("browserName", EnvironmentConfig.CurrentBrowser);
            }

            catch
            {
                //tem que tratar
                return caps;
            }

            return caps;           
        }
    }
}


