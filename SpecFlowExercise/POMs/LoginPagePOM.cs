using System;
using OpenQA.Selenium;


namespace SpecFlowExercise.POMs
{
	class LoginPagePOM
	{
		private IWebDriver _driver;
		
		public LoginPagePOM(IWebDriver driver)
		{
			this._driver = driver;
		}

		private IWebElement _username => _driver.FindElement(By.CssSelector("#username"));
        private IWebElement _password => _driver.FindElement(By.CssSelector("#password"));
		private IWebElement _submit => _driver.FindElement(By.LinkText("Submit"));

        //Service methods
        public LoginPagePOM SetUsername(string username)
        {
            _username.Clear();
            _username.SendKeys(username);
            return this;
        }

        public LoginPagePOM SetPassword(string password)
        {
            _password.Clear();
            _password.SendKeys(password);
            return this;
        }

        public void SubmitForm()
        {
            _submit.Click();
        }

    }
}
