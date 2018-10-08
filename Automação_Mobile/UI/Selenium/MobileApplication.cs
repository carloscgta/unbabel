using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Unbabel.Annotation.Test.UI.Appium.Drivers;

namespace Unbabel.Annotation.Test.Selenium
{

    class MobileApplication
    {
        public IWebDriver Driver { get; private set; }
        

        public void StartSession()
        {
            Driver = IWebDriverProvider.webDriverElement;
        }

        public void EndSession()
        {
            Driver.Quit();
        }

        public bool IsShownWithinTimeout(By locator)
        {
            try
            {
                WaitUntil(ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch (ElementNotVisibleException)
            {
                return false;
            }
        }

        public void Click(By locator)
        {
            WaitUntil(ExpectedConditions.ElementToBeClickable(locator));
            FindElement(locator).Click();
        }

        public void esconder_teclado()
        {
            //driver.HideKeyboard();
        }

        public void WaitUntilElementExists(IWebDriver idriver, IWebElement elementLocator, int timeout = 35)
        {
            try
            {
                var wait = new WebDriverWait(idriver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Elemento com localizador: '" + elementLocator + "' não foi encontrado na página de contexto atual.");
            }
        }

        public void SendEnterKey(By locator)
        {
            TypeText(locator, Keys.Enter);
        }

        public void TypeText(By locator, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            WaitUntil(ExpectedConditions.ElementIsVisible(locator));
            FindElement(locator).SendKeys(text);
        }

        public IWebElement FindElement(By locator)
        {
            WaitUntil(ExpectedConditions.ElementExists(locator));
            return Driver.FindElement(locator);
        }

    

        public void WaitUntil(Func<IWebDriver, object> until, int seconds = 30)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(until);
        }
    }

}
