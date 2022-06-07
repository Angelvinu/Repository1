using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //maximise the browser
            driver.Manage().Window.Maximize();

            //launch the turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            try
            {
                //identify username and enter the user name.
                driver.FindElement(By.Id("UserName")).SendKeys("hari");

                //identify password and enter the password.
                driver.FindElement(By.Id("Password")).SendKeys("123123");

                //identify login button and click on it.
                IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                login.Click();

            }

            catch (Exception)

            {
                Assert.Fail("turnup portal was not sucessfully lunched.");
            }
        }

    
    }
}
