using Automação_Mobile.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Automação_Mobile
{
    [Binding]
    public class AnnotationSteps
    {
        public static IWebDriver driver { get; private set; }

        public AnnotationSteps(IWebDriver driver)
        {

            PageFactory.InitElements(this, new RetryingElementLocator(driver= new ChromeDriver(), TimeSpan.FromSeconds(30)));
        }

        Login login = new Login(driver);
        string user = "emanuel + annotator6";
        string password = "carlos@unbabel";

        [Given(@"I have logged into the applicaton")]
        public void GivenIHaveLoggedIntoTheApplicaton()
        {
            //Log into the annotation tool
            login.performLogin(user,password);
        }
        
        [Given(@"I am in the home page")]
        public void GivenIAmInTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click in the task link")]
        public void WhenIClickInTheTaskLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Perform the annotation task")]
        public void ThenPerformTheAnnotationTask()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
