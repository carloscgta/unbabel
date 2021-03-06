﻿using Inm.Mobile.Test.UI.Screens;
using System;
using TechTalk.SpecFlow;

namespace Unbabel.Annotation.Test.UI.StepsDefinitions
{
    [Binding]
    public class AnnotationSteps
    {
        UnbabelAnnotation_HomePage annotationpage = new UnbabelAnnotation_HomePage();
        Login_Page login = new Login_Page();
        [Given(@"I am logged into the Annotation tool")]
        public void GivenIAmLoggedIntoTheAnnotationTool()
        {
            login.performLogin("emanuel+annotator6", "carlos@unbabel");
        }
        
        [When(@"I select one test for perform the annotation")]
        public void WhenISelectOneTestForPerformTheAnnotation()
        {
            
        }
        
        [When(@"Select the Sorty by radio")]
        public void WhenSelectTheSortyByRadio()
        {
            
        }
        
        [Then(@"select the text to perform the annotation")]
        public void ThenSelectTheTextToPerformTheAnnotation()
        {
            
        }
        
        [Then(@"Click in Annotate")]
        public void ThenClickInAnnotate()
        {
            
        }
        
        [Then(@"Select the Error type")]
        public void ThenSelectTheErrorType()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click in Finish or Report and choose Finish")]
        public void ThenClickInFinishOrReportAndChooseFinish()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"set the task Comment text in the text field")]
        public void ThenSetTheTaskCommentTextInTheTextField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click in Finish button")]
        public void ThenClickInFinishButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Annotation is finished")]
        public void ThenTheAnnotationIsFinished()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
