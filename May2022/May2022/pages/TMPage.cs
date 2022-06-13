using May2022.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //identify the create new button and click on it
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            

            //identify the drop down TypeCode for options.
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(2000);

            //select Material from the type code drop down 
            IWebElement DropDown = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/ li[1]"));
            DropDown.Click();

            //To select item from dropdwon
            //var TMDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            //Create select element subject
            //var SelectElement = new SelectElement(TMDropDown);
            //select By Text
            // SelectElement.SelectByText("Material");

            //identify code text box and enter the code
            driver.FindElement(By.Id("Code")).SendKeys("visual1");
            Thread.Sleep(1000);

            //identify description and enter the content inside the text box
            driver.FindElement(By.Id("Description")).SendKeys("sample 1");
            Thread.Sleep(1000);

            //identify price text box and enter the price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            driver.FindElement(By.Id("Price")).SendKeys("60.00");

            //identify the save button and click on save
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);

            //click on go to the last page button   
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            //check if the material record was created sucessfully
            
           
            
            

            Thread.Sleep(2000);

            //Assertion

            //the code has been sent to the step definition file under hookup

            //if (materialRecord.Text == "visual1")
            //{
            //    Console.WriteLine("Material record sucessfully created.");
            //}
            //else
            //{
            //    Console.WriteLine("Material record was not created sucessfully.");
            //}
        }

        public string GetNewCode(IWebDriver driver)

        {
            IWebElement RecentCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return RecentCode.Text;

        }

        public string GetNewTypeCode(IWebDriver driver)

        {
            IWebElement RecentTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return RecentTypeCode.Text;
        }

        public string GetNewDescription(IWebDriver driver)

        {
            IWebElement RecentDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return RecentDescription.Text;
        }

        public string GetNewPrice(IWebDriver driver)

        {
            IWebElement RecentPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return RecentPrice.Text;
        }
        public void EditTM(IWebDriver driver)

        {

            //3.Check if a user is able to update an existing time/material record successfully

            //click on go to the last page button 

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);

            //click on the edit option to update data
            IWebElement editCode2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editCode2.Click();
            Thread.Sleep(1000);

            //identify the drop down TypeCode for options.
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(2000);

            //select Material from the type code drop down 
            IWebElement DropDown2 = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/ li[1]"));
            DropDown2.Click();

            //select the code text box,remove the existing content and update 
            IWebElement edittedCode = driver.FindElement(By.Id("Code"));
            edittedCode.Clear();
            edittedCode.SendKeys("Team1");

            //select the description text box,remove the existing content and update in the textbox
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("sams2");
            Thread.Sleep(2000);

            //select the price inthe text box,remove the existing content and update in the textbox
            IWebElement editPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            editPrice.Click();
            Thread.Sleep(2000);

            IWebElement priceInput = driver.FindElement(By.Id("Price"));
            priceInput.Clear();
            Thread.Sleep(2000);
            editPrice.Click();
            priceInput.SendKeys("20.00");
            Thread.Sleep(2000);

            //save the updated information
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);

            //go to the last page of the table
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);

            //check that the material record has been created sucessfully
            IWebElement Code2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            IWebElement edittedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement Description2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement Price2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Thread.Sleep(2000);

            //Assertion

            Assert.That(Code2.Text == "Team1", "Actual Material record and expected doesnot match.");
            Assert.That(edittedTypeCode.Text == "M", "Actual code and expected doesnot match.");
            Assert.That(Description2.Text == "sams2", "Actual description and expected doesnot match.");
            Assert.That(Price2.Text == "$20.00", "Actual price and expected doesnot match.");
           

            //if (newMaterial.Text == "Team1")
            //{
            //    Console.WriteLine("New record updated sucessfully.");
            //}
            //else
            //{
            //    Console.WriteLine("New record was not updated sucessfully.");
            //}
            Thread.Sleep(2000);
        }
        public void DeleteTM(IWebDriver driver)

        {
            //4.Check if a user is able to delete an existing time/material record successfully


            //click on go to the last page button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);

            //click on the delete option

            IWebElement deleteARow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteARow.Click();
            Thread.Sleep(2000);

            //click ok button
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Delete button clicked");
            Thread.Sleep(1000);


            //click on go to the last page button to confirm that the record has been deleted

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);

            IWebElement Deleted = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(Deleted.Text != "Team1", "Time and Record hasn't been deleted sucessfully");
            
        }
    }
}
 