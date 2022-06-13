
using May2022.pages;
using May2022.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace May2022.utilities
{

    [TestFixture]
    [Parallelizable]
    public class TimeNMa_Tests : CommonDriver

    {

        Homepage Homepageobj = new Homepage();
        TMPage TMPageojb = new TMPage();

       
        [Test, Order(1), Description("First Test")]

        public void CreateTM()
        {

            //home page object initialisation and definition
            Homepageobj.GoToHomePg(driver);

            TMPageojb.CreateTM(driver);
        }

        [Test, Order(2), Description("Second Test")]

        public void EditTM()
        {
            //home page object initialisation and definition
            Homepageobj.GoToHomePg(driver);

            TMPageojb.EditTM(driver);
        }

        [Test, Order(3),Description("Third Test")]

        public void DeleteTM()
        {
            //home page object initialisation and definition
            Homepageobj.GoToHomePg(driver);
            TMPageojb.DeleteTM(driver);
        }

      
    }
}











