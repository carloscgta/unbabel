using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unbabel.Annotation.Test.UI.Screens;

namespace Inm.Mobile.Test.UI.Screens
{
    class UnbabelAnnotation_HomePage : Base
    {
        public static readonly By linkTask = By.XPath("//a[@href='/interface/5ba8b2a2f8b6d6002239e16b/']");


        public static readonly By iconGT = By.ClassName("//div[@class='c-ToggleGroup__item is-active'][text()[contains(.,'GT')]]");


        public static readonly By iconAN = By.XPath("//*[@class='c-ToggleGroup__item is-active'][text()[contains(.,'AN')]]");

        public static readonly By iconMK = By.ClassName("//*[@class='c-ToggleGroup__item is-active'][text()[contains(.,'MK')]]");


        public static readonly By divTextTranslationViewer = By.XPath("//div[@class='c-AnnotateApp__content']");
        
        public static readonly By inputErrorType = By.XPath("//input[@id='searchErrorTypes']");

        public static readonly By listtErrorType = By.XPath("//li[@class='c-MarkError__item is-open']");

        public static readonly By spanGlossaryTerms = By.XPath("//div[@class='c-Sidebar__tab'][text()[contains(.,'Propose Glossary Terms')]]");

        public static readonly By englishTargetTextListString = By.XPath("//div[@class='c-TranslationViewer__panel is-target']");

        public static readonly By spanishTargetTextListString = By.XPath("//div[@class='c-TranslationViewer__panel is-source']");

        public static readonly By spanFinishReport = By.XPath("//div[@class='c-Sidebar__tab'][text()[contains(.,'Finish or Report')]]");

        
        public static readonly By lisToDoTasksIconsListData = By.XPath("//div[@class='c-TopBar__navWrapper']");

       public static readonly IWebElement  elementList;

        
        public string atribute = null;

        public void CheckToDoTask()
        {
            //element.FindElement(lisToDoTasksIconsListData);
            IList<IWebElement> allOptions = Driver.FindElements(lisToDoTasksIconsListData);

            

            foreach (IWebElement element in allOptions)
            {
                atribute = element.TagName;
                if (atribute.Equals("To Do"))
                {
                    element.Click();
                }

            }

        }

        public void highlightTheText(By element, int X, int Y)
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(SearchElement(element), X, Y);
            actions.ClickAndHold();
            actions.ClickAndHold();
            actions.MoveByOffset(100, 0);
            actions.Release();
            actions.Perform();

        }

        public void findTasksLink()
        {

            WaitUntilElementExists(Driver, linkTask);
            
            Click(linkTask);


        }




        public void TeclarBotaoEnter(By locator)
        {
            WaitUntilElementExists(Driver, locator);
            SearchElement(locator);
        }

        public void FillText(By locator, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return;
            }
            Click(locator);
            SearchElement(locator).SendKeys(text);

        }

      

    


    }


}
