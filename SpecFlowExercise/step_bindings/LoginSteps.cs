using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using static SpecFlowExercise.Support.HelpersStatic;

namespace SpecFlowExercise.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        private IWebDriver _driver;

        [Before]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            _driver = new ChromeDriver(options);
        }

        [After]
        public void TearDown()
        {
            Thread.Sleep(2000);
            _driver.Quit();
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _driver.Url = "https://www.edgewordstraining.co.uk/webdriver2/";
            _driver.FindElement(By.PartialLinkText("Login")).Click();
        }

        [When(@"I submit my valid username and password")]
        public void WhenISubmitMyUsernameAndPassword()
        {
            _driver.FindElement(By.CssSelector("#username")).SendKeys("Edgewords");
            _driver.FindElement(By.CssSelector("#password")).SendKeys("edgewords123");
            _driver.FindElement(By.LinkText("Submit")).Click();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            IWebElement loggedInStatus = WaitForEl(_driver, By.CssSelector("#menu .last span"), 10);
            string loggedInStatusText = loggedInStatus.Text;

            //string loggedInStatusText = _driver.FindElement(By.CssSelector("#menu .last span")).Text;

            Assert.That(loggedInStatusText, Does.Contain("Log Out"), "User is not logged in");
        }
    }
}
