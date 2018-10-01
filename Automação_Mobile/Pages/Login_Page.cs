using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_Mobile.Pages
{
    class Login : Base
    {
        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver= new ChromeDriver(), TimeSpan.FromSeconds(30)));
        }

        //a[@href='/interface/5ba8b2a2f8b6d6002239e16b/']

        [FindsBy(How = How.XPath, Using = "//button[@text='Login']")]
        [CacheLookup]
        public IWebElement btnDoLogin { get; set; }

        [FindsBy(How = How.ClassName, Using = "//input[@id='username']")]
        [CacheLookup]
        public IWebElement inputUserName { get; set; }

      
        [FindsBy(How = How.ClassName, Using = "//input[@id='password']")]
        [CacheLookup]
        public IWebElement inputSenha { get; set; }


        //public IWebElement txtNomeUsuarioLogado => driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView"));

        public void performLogin(string user, string password)
        {
         
            WaitUntilElementExists(driver, inputUserName);
            inputUserName.SendKeys(user);

            WaitUntilElementExists(driver, inputSenha);
            inputSenha.SendKeys(password);

            WaitUntilElementExists(driver, btnDoLogin);
            btnDoLogin.Click();


        }



    }


}