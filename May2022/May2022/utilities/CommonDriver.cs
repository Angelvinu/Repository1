using May2022.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        //page Object initialization

        LoginPage LoginPageobj = new LoginPage();
     

        [SetUp]
        public void LoginActions()
        {
            //setting a driver interface
            driver = new ChromeDriver();

            //login page object initialisation and definition


            LoginPageobj.LoginSteps(driver);

            

        }

        [TearDown]

        public void CloseTest()
        {
            driver.Quit();
        }
    }
}
