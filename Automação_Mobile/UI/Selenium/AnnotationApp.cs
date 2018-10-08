using Unbabel.Annotation.Test.UI.Screens;
using Unbabel.Annotation.Test.UI.Selenium;

namespace Unbabel.Annotation.Test.UI.Selenium
{
    class AnnotationApp
    {
        public static Base App;

        public static void InitializeSession()
        {
            App = new Base();
            App.StartSession();
        }

        public static void DeleteSession()
        {
            App.EndSession();
        }
}
}
