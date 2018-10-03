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
        
        public UnbabelAnnotation_HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(30)));
        }

     
        [FindsBy(How = How.XPath, Using = "//a[@href='/interface/5ba8b2a2f8b6d6002239e16b/']")]
        [CacheLookup]
        public IWebElement linkTask { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//div[@class='c-ToggleGroup__item is-active'][text()[contains(.,'GT')]]")]
        [CacheLookup]
        public IWebElement iconGT { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@class='c-ToggleGroup__item is-active'][text()[contains(.,'AN')]]")]
        [CacheLookup]
        public IWebElement iconAN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='c-ToggleGroup__item is-active'][text()[contains(.,'MK')]]")]
        [CacheLookup]
        public IWebElement iconMK { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//*[@class='c-TranslationViewer__line']")]
        [CacheLookup]
        public IWebElement divTextTranslationViewer  { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//input[@id='searchErrorTypes']")]
        [CacheLookup]
        public IWebElement inputErrorType { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//li[@class='c-MarkError__item is-open']")]
        [CacheLookup]
        public IWebElement listtErrorType { get; set; }


        

        [FindsBy(How = How.XPath, Using = "//div[@class='c-Sidebar__tab'][text()[contains(.,'Propose Glossary Terms')]]")]
        [CacheLookup]
        public IWebElement spanGlossaryTerms { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//div[@class='c-Sidebar__tab'][text()[contains(.,'Finish or Report')]]")]
        [CacheLookup]
        public IWebElement spanFinishReport { get; set; }


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
