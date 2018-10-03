using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automação_Mobile.NewFolder1
{
    [Binding]
    public class HooksMobile
    {

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public static ChromeDriver driver { get; private set; }


        [BeforeScenario]
        public void BeforeScenario()
        {
            

            using (driver = new ChromeDriver())
            {
                // 1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("https://staging.annotation.tools.unbabel.com/");


            }

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
        
       


    }
}
