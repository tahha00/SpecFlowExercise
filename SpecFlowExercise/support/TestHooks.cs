using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowExercise.support
{
    [Binding]
    public class TestHooks
    {
        public static IWebDriver _driver;

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

    }
}
