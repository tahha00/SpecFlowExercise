using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowExercise.Support
{
    internal class HelpersStatic
    {
        public static IWebElement WaitForEl(IWebDriver driver, By locator, int timeToWait = 5)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(timeToWait));
            IWebElement element = wait.Until(drv => drv.FindElement(locator));
            return element;
        }
    }
}
