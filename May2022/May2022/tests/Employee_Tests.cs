using May2022.pages;
using May2022.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests:CommonDriver
    {

        Homepage Homepageobj = new Homepage();
        EmployeePage EmployeePageObj = new EmployeePage();
        

        

        [Test]

        public void CreateEmployee()

        {
            //home page object initialisation and definition
            Homepageobj.GoToEmployeePage(driver);

            //employee page object and create employee record
            EmployeePageObj.CreateEmployee(driver);
        }

        [Test]

        public void EditEmployee()

        {
            // home page object initialisation and definition
            Homepageobj.GoToEmployeePage(driver);

            //employee page object and edit employee record
            EmployeePageObj.EditEmployee(driver);
        }

        [Test]

        public void DeleteEmployee()

        {
            // home page object initialisation and definition
            Homepageobj.GoToEmployeePage(driver);



            //employee page object and delete employee record
            EmployeePageObj.DeleteEmployee(driver);

        }

       
    }
}
