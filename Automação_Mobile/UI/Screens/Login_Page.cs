using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unbabel.Annotation.Test.UI.Screens;

namespace Inm.Mobile.Test.UI.Screens
{
    class Login_Page: Base
    {

        public static readonly By btnDoLogin = By.XPath("//button[@text='Login']");

        public static readonly By inputUserName = By.XPath("//input[@id='username']");

        public static readonly By inputSenha = By.XPath("//input[@id='password']");
        
        

        public void performLogin(string user, string password)
        {

            Driver.FindElement(inputUserName).SendKeys(user);

            Driver.FindElement(inputSenha).SendKeys(password);

            Driver.FindElement(btnDoLogin).Click();

            
        }

    }


}
