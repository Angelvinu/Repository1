using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.pages
{
    public class Homepage
    {
        public void GoToHomePg(IWebDriver driver)
        {
            //Identify the admin drop down
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //select the Time and material option from the drop down
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

            Thread.Sleep(2000);
        }
    }
}
