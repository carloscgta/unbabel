using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing.Imaging;
using System.Threading;
using TechTalk.SpecFlow;
using Unbabel.Annotation.Test.UI;
using Unbabel.Annotation.Test.UI.Selenium;

namespace Unbabel.Annotation.Test.UI.Config
{
    [Binding]
    public class Hooks
    {
        //public static AndroidDriver<AndroidElement> driverAndroid { get; private set; }
        //public static IOSDriver<IOSElement> driveIos { get; private set; }

        [Before]
        public static void Before()
        {
            AnnotationApp.InitializeSession();
        }
        [After]
        public static void After()
        {
            AnnotationApp.DeleteSession();
        }
        

    }
}
