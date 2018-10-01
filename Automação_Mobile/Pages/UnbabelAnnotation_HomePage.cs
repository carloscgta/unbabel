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

        public UnbabelAnnotation_HomePage(AndroidDriver<AndroidElement> driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(30)));
        }

        

        [FindsBy(How = How.XPath, Using = "//a[@href='/interface/5ba8b2a2f8b6d6002239e16b/']")]
        [CacheLookup]
        public IWebElement linkTask { get; set; }

     


        //public IWebElement txtNomeUsuarioLogado => driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView"));

        public void findTasksLink()
        {

            WaitUntilElementExists(driver, linkTask);
            linkTask.Click();
            

        }
    }
}
