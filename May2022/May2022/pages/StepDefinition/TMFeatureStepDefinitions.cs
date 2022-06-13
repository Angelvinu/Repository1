using May2022.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace May2022.pages.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver

    {
        [Given(@"I logged into turnup portal sucessfully")]
        public void GivenILoggedIntoTurnupPortalSucessfully()
        {
            //setting a driver interface
            driver = new ChromeDriver();

            //login page object initialisation and definition

            LoginPage LoginPageobj = new LoginPage();
            LoginPageobj.LoginSteps(driver);
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            //home page object initialisation and definition

            Homepage Homepageobj = new Homepage();
            Homepageobj.GoToHomePg(driver);
        }

        [When(@"I create time and material record sucessfully")]
        public void WhenICreateTimeAndMaterialRecordSucessfully()
        {

            //TM page object initialisation and functions
            TMPage TMPageojb = new TMPage();
            TMPageojb.CreateTM(driver);
           
        }

        [Then(@"Time and material record should be created sucessfully")]
        public void ThenTimeAndMaterialRecordShouldBeCreatedSucessfully()
        {
            TMPage TMPageojb = new TMPage();

            string RecentCode = TMPageojb.GetNewCode(driver);
            string RecentTypeCode = TMPageojb.GetNewTypeCode(driver);
            string RecentDescription = TMPageojb.GetNewDescription(driver);
            string RecentPrice = TMPageojb.GetNewPrice(driver);

            //Assertion 

            Assert.That(RecentCode == "visual1", "Actual Material record and expected doesnot match.");
            Assert.That(RecentTypeCode == "M", "Actual code and expected doesnot match.");
            Assert.That(RecentDescription == "sample 1", "Actual description and expected doesnot match.");
            Assert.That(RecentPrice == "$60.00", "Actual price and expected doesnot match.");
        }
    }
}
