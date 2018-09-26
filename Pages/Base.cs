using OpenQA.Selenium;
using System;
using Unbabel_AutomationAnnotationTool.Config;
using OpenQA.Selenium.Support.UI;

namespace Unbabel_AutomationAnnotationTool.Pages
{
    class Base
    {

        WebDriverWait wait;
        
        public IWebDriver  driver

        {
            get
            {
                return HooksAnnotationTool.driver;
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

        public static void Wait(int miliseconds, int maxTimeOutSeconds = 60)
        {
            var wait = new WebDriverWait(HooksAnnotationTool.driver, new TimeSpan(0, 0, 1, maxTimeOutSeconds));
            var delay = new TimeSpan(0, 0, 0, 0, miliseconds);
            var timestamp = DateTime.Now;
            wait.Until(webDriver => (DateTime.Now - timestamp) > delay);
        }



    }
}
