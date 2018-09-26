using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Unbabel_AutomationAnnotationTool.Config
{
    class HooksAnnotationTool
    {
        public static IWebDriver  driver { get; private set; }

        public string screenshotsPasta;
        int contador = 1;

        public void startTestObject()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://staging.annotation.tools.unbabel.com/");

        
        }

        public void AfterScenario()
        {
            driver.Quit();
        }

      
    }
}
