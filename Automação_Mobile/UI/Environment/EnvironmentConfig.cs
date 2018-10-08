using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Remote;

namespace Inm.Mobile.Test.Environment
{
    class EnvironmentConfig
    {
        public static string CurrentDevice => ConfigurationManager.AppSettings["device"];
        
        public class Android
        {
            public static string DeviceName => ConfigurationManager.AppSettings["android_deviceName"];
            public static string PlatformName => ConfigurationManager.AppSettings["android_platformName"];
            public static string AutomationName => ConfigurationManager.AppSettings["android_automationName"];
            public static string AppPackage => ConfigurationManager.AppSettings["android_appPackage"];
            public static string AppActivity => ConfigurationManager.AppSettings["android_appActivity"];
            public static int NewCommandTimeout => Convert.ToInt32(ConfigurationManager.AppSettings["android_newCommandTimeout"]);
            public static string AutoGrantPermissions => ConfigurationManager.AppSettings["android_autoGrantPermissions"];
            public static string AutoAcceptAlerts => ConfigurationManager.AppSettings["android_autoAcceptAlerts"];
            public static string TestDroidTestTimeOut => ConfigurationManager.AppSettings["android_testdroid_testTimeout"];
            public static string AppiumServerUrl => ConfigurationManager.AppSettings["android_appiumServerUrl"];
            
            
        }
        public class Ios
        {
            public static string DeviceName => ConfigurationManager.AppSettings["ios_deviceName"];
            public static string PlatformName => ConfigurationManager.AppSettings["ios_platformName"];
            public static string PlataformVersion => ConfigurationManager.AppSettings["ios_platformVersion"];            
            public static string AutomationName => ConfigurationManager.AppSettings["ios_automationName"];
            public static string App => ConfigurationManager.AppSettings["ios_app"];
            public static string UDID => ConfigurationManager.AppSettings["ios_UDID"];
            public static string AppPackage => ConfigurationManager.AppSettings["ios_appPackage"];
            public static string AppActivity => ConfigurationManager.AppSettings["ios_appActivity"];
            public static int NewCommandTimeout => Convert.ToInt32(ConfigurationManager.AppSettings["ios_newCommandTimeout"]);
            public static string AutoGrantPermissions =>ConfigurationManager.AppSettings["ios_autoGrantPermissions"];
            public static string AutoAcceptAlerts => ConfigurationManager.AppSettings["ios_autoAcceptAlerts"];
            public static string TestDroidTestTimeOut => ConfigurationManager.AppSettings["ios_testdroid_testTimeout"];
            public static string AppiumServerUrl => ConfigurationManager.AppSettings["ios_appiumServerUrl"];           
        }
    }
}


