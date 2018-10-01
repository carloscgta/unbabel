using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_Mobile.Pages
{
    class UnbabelAnnotation_HomePage : Base
    {
        public static IWebDriver driver;
        public UnbabelAnnotation_HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(30)));
        }

     
        [FindsBy(How = How.XPath, Using = "//a[@href='/interface/5ba8b2a2f8b6d6002239e16b/']")]
        [CacheLookup]
        public IWebElement linkTask { get; set; }



       [FindsBy(How = How.XPath, Using = "//div[@class='c-TopBar__navWrapper']")]
        //[CacheLookup]
        //public IWebElement toDoTasksIconsListData { get; set; }
        public static IList<IWebElement> toDoTasksIconsListData;

        

        public void CheckToDoTask()
        {
            
            IList<IWebElement> allOptions = toDoTasksIconsListData;

            string atribute = null;
            
            foreach (IWebElement element in allOptions)
            {
                atribute = element.TagName;
                if(atribute.Equals("To Do"))
                {
                    element.Click();
                }
                
            }
            
        }

        public void findTasksLink()
        {

            WaitUntilElementExists(driver, linkTask);
            linkTask.Click();
            

        }
        

    }
}
