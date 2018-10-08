using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inm.Mobile.Test.UI.Screens
{
    class Login_Page
    {
        [FindsBy(How = How.XPath, Using = "//button[@text='Login']")]
        [CacheLookup]
        public IWebElement btnDoLogin { get; set; }

        [FindsBy(How = How.ClassName, Using = "//input[@id='username']")]
        [CacheLookup]
        public IWebElement inputUserName { get; set; }


        [FindsBy(How = How.ClassName, Using = "//input[@id='password']")]
        [CacheLookup]
        public IWebElement inputSenha { get; set; }

        //update the locators


        public void performLogin(string user, string password)
        {


            inputUserName.SendKeys(user);


            inputSenha.SendKeys(password);


            btnDoLogin.Click();


        }

    }


}
