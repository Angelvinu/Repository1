using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.utilities
{
    public  class WaitHelpers
    {
        //reusable function for wait amd clickable
        public static void WaitToBeClickable(IWebElement driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait ((IWebDriver)driver, new TimeSpan(0, 0, seconds));

            if ( locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if ( locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if ( locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }

        internal static void WaitToBeClickable(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static void WaitToBeClickable(IWebDriver driver, string v)
        {
            throw new NotImplementedException();
        }

        public static void WaitToBeVisible(IWebElement driver, string locator, string locatorValue, int seconds)

        {
            var wait = new WebDriverWait((IWebDriver)driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }

        }
    }

}
