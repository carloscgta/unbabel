using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Remote;

namespace Unbabel.Annotation.Test.UI.Environment
{
    class EnvironmentConfig
    {
        public static string CurrentBrowser => ConfigurationManager.AppSettings["browser"];
        
        public class Android
        {
            public static string browserName => ConfigurationManager.AppSettings["AnnotationTool_browserName"];

            public static string DevURL => ConfigurationManager.AppSettings["AnnotationTool_DevURL"];

            public static string Username => ConfigurationManager.AppSettings["AnnotationTool_Username"];

            public static string Password => ConfigurationManager.AppSettings["AnnotationTool_Password"];



        }
      
    }
}


