# unbabel
The Automation exercise will be centered on an existing Unbabel tool called Annotation tool.
The purporse of this framework is to automate the regression test of Login and task annotation for the unbabl tool.
It is using POM pattern and also BDD.

What is necessary to running this framework:

1. Visual Studio 2017
2. Selenium WebDriver 3.0.1.0
3. SpecFlow
4. WebDriver Support
5. Google chrome driver

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


Config
ON this fold there is the "Hooks" class, it is responsible to start the Selenium driver and also start the chrome browser 
and go to the application address
Features
On this folder we create the feature files for the BDD
Pages
On this folder we store all page objects. Each page has all the elements mapped
Screenshots
For the evidence and report purpose
Steps
Here we have the steps file for the execution of the tests
