using Unbabel.Annotation.Test.UI.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using System.Threading;
using Unbabel.Annotation.Test.UI.Environment;
using OpenQA.Selenium.Chrome;
using Unbabel.Annotation.Test.UI.Appium.Drivers;
using OpenQA.Selenium.Interactions;

namespace Unbabel.Annotation.Test.UI.Screens
{
    public class Base
    {
        public static IWebDriver Driver { get; private set; }
        public static IWebElement webElement;
        public static ChromeDriver chromeDriver;

        public void StartSession()
        {
            IWebDriverProvider webDriver = new IWebDriverProvider();
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://staging.annotation.tools.unbabel.com/");
            Thread.Sleep(30000);
        }

        public void EndSession()
        {
            Driver.Quit();
        }
        
        public void WaitUntilElementExists(IWebDriver driver, By Locator, int timeout = 35)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(Locator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("The Element  '" + Locator + "'was no found");
            }
        }

        public bool IsShownWithinTimeout(By locator)
        {
            try
            {
                WaitUntilElementExists(Driver, locator);
                return true;
            }
            catch (ElementNotVisibleException)
            {
                return false;
            }
        }
        public void ClickElementByText(string sTexto)
        {
            Driver.FindElement(By.XPath("//*[@text='" + sTexto + "']")).Click();
        }
        
        public void Click(By locator)
        {
            webElement.FindElement(locator).Click();
            //SearchElement(locator).Click();
        }


        public IWebElement SearchElement(By locator)
        {
            //WaitUntil(ExpectedConditions.ElementExists(locator));
            WaitUntilElementExists(Driver, locator);
            return webElement.FindElement(locator);
        }




    }
}
