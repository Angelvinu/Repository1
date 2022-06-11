
using May2022.pages;
using May2022.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace May2022.utilities
{

    [TestFixture]
    public class TimeNMa_Tests : CommonDriver

    {
    

        [SetUp]
        public void LoginActions()
        {
            //setting a driver interface
            driver = new ChromeDriver();

            //login page object initialisation and definition

            LoginPage LoginPageobj = new LoginPage();
            LoginPageobj.LoginSteps(driver);

            //home page object initialisation and definition

            Homepage Homepageobj = new Homepage();
            Homepageobj.GoToHomePg(driver);

        }

        [Test, Order(1), Description("First Test")]

        public void CreateTM()
        {

            TMPage TMPageojb = new TMPage();
            TMPageojb.CreateTM(driver);
        }

        [Test, Order(2), Description("Second Test")]

        public void EditTM()
        {
            TMPage TMPageojb = new TMPage();
            TMPageojb.EditTM(driver);
        }

        [Test, Order(3),Description("Third Test")]

        public void DeleteTM()
        {
            TMPage TMPageojb = new TMPage();
            TMPageojb.DeleteTM(driver);
        }

        [TearDown]

        public void CloseTest()
        {
            driver.Quit();
        }
    }
}











