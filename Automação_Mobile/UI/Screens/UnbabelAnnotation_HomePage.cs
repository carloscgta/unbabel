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

        public static readonly By iconGT = By.XPath("//div[@class='c-ToggleGroup__item is-active'][text()[contains(.,'GT')]]");

        public static readonly By linkAnnotations = By.XPath("(//div[@class='c-AnnotateApp__main g-container']//following-sibling::span/..)[2]");
        
        public static readonly By linkFinishOrReport = By.XPath("(//div[@class='c-Sidebar__tab']//following-sibling::span/..)[6]");

        public static readonly By iconAN = By.XPath("//*[@class='c-ToggleGroup__item is-active'][text()[contains(.,'AN')]]");

        public static readonly By iconMK = By.XPath("//*[@class='c-ToggleGroup__item is-active'][text()[contains(.,'MK')]]");

        public static readonly By divTextTranslationViewer = By.XPath("//div[@class='c-AnnotateApp__content']");
        
        public static readonly By inputErrorType = By.XPath("//input[@id='searchErrorTypes']");

        public static readonly By listtErrorType = By.XPath("//*[@class='c-MarkError__list is-active']");

        public static readonly By spanGlossaryTerms = By.XPath("//div[@class='c-Sidebar__tab'][text()[contains(.,'Propose Glossary Terms')]]");

        public static readonly By englishTargetTextListString = By.XPath("//div[@class='c-TranslationViewer__panel is-target']");

        public static readonly By spanishTargetTextListString = By.XPath("//div[@class='c-TranslationViewer__panel is-source']");

        public static readonly By spanFinishReport = By.XPath("//div[@class='c-Sidebar__tab'][text()[contains(.,'Finish or Report')]]");
        public static readonly By radioSortByPosition = By.XPath("//input[@id='positionSortBy']");
        
        public static readonly By lisToDoTasksIconsListData = By.XPath("//div[@class='c-TopBar__navWrapper']");

        public static readonly By listTextAnnotationBlock = By.XPath("//div[@class='c-TextBlock']");

        public static readonly By iconTask = By.XPath("(//span[contains(text(),'To Do')])[1]");

        public static readonly By listSeverityRadioOptions = By.XPath("//*[@class='c-MarkError__form']");

        public static readonly By btnAdd = By.XPath("//button[@class='c-Button c-Button--cta']");

        public static readonly By radioFinish = By.XPath("//input[@id='finishOption']");

        public static readonly By buttonFinish = By.XPath("//button[@class='c-Button c-Button--cta']");

        public static readonly By btnYesFinishJob = By.XPath("//div[@id='js-modal-footer']//following-sibling::button");

        

        public static readonly IWebElement  elementList;

        public string atribute = null;
        public string textBlock = null;

        public string text = "Click here for instructions on how to add a card.";

        public void confirmFinishJob()
        {
            //Click(btnYesFinishJob);
            Driver.SwitchTo().Alert().Accept();
            
        }

        public void clickAddBtn()
        {
            Driver.FindElement(btnAdd).Click();

        }

        public void selectTheSeverityRadio(string severityOption)
        {
            IList<IWebElement> allOptions = Driver.FindElements(listSeverityRadioOptions);
            string severityOptionText = null;
            foreach (IWebElement element in allOptions)
            {

                severityOptionText = element.FindElement(iconTask).ToString();
                if (severityOptionText.Equals(severityOption))
                {
                    element.Click();
                   
                }

            }

        }

     public void selectTheTypeOfError()
        {

            IList<IWebElement> allOptions = Driver.FindElements(listtErrorType);

            foreach (IWebElement element in allOptions)
            {

                atribute = element.FindElement(listtErrorType).ToString();
                if (atribute.Equals("Accuracy"))
                {
                    element.Click();
                    if (atribute.Equals("Addition"))
                        element.Click();
                }

            }
            
        }




        public void Click(By locator)
        {
            Driver.FindElement(locator).Click();
            //SearchElement(locator).Click();
        }

        public void CheckToDoTask()
        {
            //element.FindElement(lisToDoTasksIconsListData);
            IList<IWebElement> allOptions = Driver.FindElements(lisToDoTasksIconsListData);
            

            foreach (IWebElement element in allOptions)
            {
               
                atribute = element.ToString();
                if (atribute.Equals("To Do"))
                {
                    element.Click();
                }

            }

        }

        public void sortByPosition()
        {

            Driver.FindElement(radioSortByPosition).Click();
        }

        public void clickOnAnnotationLink()
        {

            Driver.FindElement(linkAnnotations).Click();
        }

        

        public void highlightTheText()
        {
            Actions actions = new Actions(Driver);
            
            int length = text.Substring(0, text.IndexOf("a")).Length;
            //actions.MoveToElement(SearchElement(element), X, Y);
            actions.KeyDown(Keys.LeftShift);
            for (int i= 0; i < length; i++)
            {
                actions.SendKeys(Keys.ArrowRight);
                
            }
            actions.ClickAndHold();
            actions.Build().Perform();

            //actions.ClickAndHold();
            //actions.MoveByOffset(lengh, 0);
            //actions.Release();
            //actions.Perform();

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
