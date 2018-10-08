using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing.Imaging;
using System.Threading;
using TechTalk.SpecFlow;
using Inm.Mobile.Test.Appium.Drivers;
using Inm.Mobile.Test.Environment;

namespace Inm.Mobile.Test.Config
{
    [Binding]
    public class HooksMobile
    {
        public static AndroidDriver<AndroidElement> driverAndroid { get; private set; }
        public static IOSDriver<IOSElement> driveIos { get; private set; }

        public string screenshotsPasta;
        int contador = 1;

        [BeforeFeature]
        public static void Before()
        {
            var device = EnvironmentConfig.CurrentDevice;

            switch (device)
            {
                case "Android":
                    AndroidDriverProvider android = new AndroidDriverProvider();
                    DesiredCapabilities capAndroid = new DesiredCapabilities();
                    capAndroid = android.GetAndroidCapabilities();
                    driverAndroid = new AndroidDriver<AndroidElement>(new Uri(EnvironmentConfig.Android.AppiumServerUrl), capAndroid);
                    break;
                case "iOs":
                    IOsDriverProvider ios = new IOsDriverProvider();
                    DesiredCapabilities capIos = new DesiredCapabilities();
                    capIos = ios.GetIosCapabilities();
                    driveIos = new IOSDriver<IOSElement>(new Uri(EnvironmentConfig.Ios.AppiumServerUrl), capIos);
                    break;
                default:
                    break;
            }

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driverAndroid.Quit();
        }

        [AfterStep]
        public void Screenshot(IWebDriver driver, string screenshotsPasta)
        {
            ITakesScreenshot camera = driver as ITakesScreenshot;
            Screenshot foto = camera.GetScreenshot();
            foto.SaveAsFile(screenshotsPasta, ImageFormat.Png);
        }

        public static dynamic GetDriverDevice(string device)
        {
            if (device == "Android")
                return driverAndroid;
            else
                return driveIos;
        }

    }
}
