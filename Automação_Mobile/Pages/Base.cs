using Automação_Mobile.NewFolder1;
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

   
namespace Automação_Mobile
{
    public class Base
    {
        WebDriverWait wait;
        //public AndroidDriver<AndroidElement> driver
        public IWebDriver driver

        {
            get
            {
                return HooksMobile.driver;
            }
        }
        
        public void clicar(By element)
        {
            
            driver.FindElement(element).Click();
        }
  
        public void preencherTexto(By element, string texto)
        {

            driver.FindElement(element).SendKeys(texto);
        }

        public void esconder_teclado()
        {
            //driver. HideKeyboard();
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
                throw;
            }
        }
    

    public static void Wait(int miliseconds, int maxTimeOutSeconds = 60)
        {
            var wait = new WebDriverWait(HooksMobile.driver, new TimeSpan(0, 0, 1, maxTimeOutSeconds));
            var delay = new TimeSpan(0, 0, 0, 0, miliseconds);
            var timestamp = DateTime.Now;
            wait.Until(webDriver => (DateTime.Now - timestamp) > delay);
        }



    }
}
