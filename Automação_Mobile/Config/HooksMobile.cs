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

namespace Automação_Mobile.NewFolder1
{
    [Binding]
    public class HooksMobile
    {
        
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        public static IWebDriver driver { get; private set; }

        public HooksMobile() 

        {
            driver = new ChromeDriver();
           
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            
            driver.Navigate().GoToUrl("http://staging.annotation.tools.unbabel.com/");

          
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
        
       


    }
}
