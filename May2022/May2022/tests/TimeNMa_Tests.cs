
using May2022.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class TimeNMa_Tests
{
   static void Main(string[] args)
    {
        //setting a driver interface
        IWebDriver driver = new ChromeDriver();

        //login page object initialisation and definition

        LoginPage LoginPageobj = new LoginPage();
        LoginPageobj.LoginSteps(driver);

        //home page object initialisation and definition

        Homepage Homepageobj = new Homepage();
        Homepageobj.GoToHomePg(driver);

        //Time and Material page object initialisation and definition

        TMPage TMPageojb = new TMPage();
        TMPageojb.CreateTM(driver);

        TMPageojb.EditTM(driver);

        TMPageojb.DeleteTM(driver);

    }
}