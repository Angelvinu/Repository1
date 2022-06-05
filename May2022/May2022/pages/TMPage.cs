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

            //select Material from the type code drop down 
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(1000);

            //identify code text box and enter the code
            driver.FindElement(By.Id("Code")).SendKeys("visual1");
            Thread.Sleep(1000);

            //identify description and enter the content inside the text box
            driver.FindElement(By.Id("Description")).SendKeys("sample 1");
            Thread.Sleep(1000);

            //identify price text box and enter the price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            driver.FindElement(By.Id("Price")).SendKeys("60");

            //identify the save button and click on save
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);

            //click on go to the last page button   //check if the material record was created sucessfully
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            IWebElement materialRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            if (materialRecord.Text == "visual1")
            {
                Console.WriteLine("Material record sucessfully created.");
            }
            else
            {
                Console.WriteLine("Material record was not created sucessfully.");
            }
        }
        public void EditTM(IWebDriver driver)

        {

            //3.Check if a user is able to update an existing time/material record successfully

            //click on the edit option to update data
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editCode.Click();
            Thread.Sleep(1000);

            //select the code text box,remove the existing content and update 
            IWebElement newCode = driver.FindElement(By.Id("Code"));
            newCode.Clear();
            newCode.SendKeys("Team1");

            //select the description text box,remove the existing content and update in the textbox
            IWebElement describe = driver.FindElement(By.Id("Description"));
            describe.Clear();
            describe.SendKeys("sams2");
            Thread.Sleep(2000);

            //select the price inthe text box,remove the existing content and update in the textbox
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            newPrice.Click();
            IWebElement priceInput = driver.FindElement(By.Id("Price"));
            priceInput.SendKeys("20");

            //save the updated information
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);

            //go to the last page of the table
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);

            //check that the material record has been created sucessfully
            IWebElement newMaterial = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newMaterial.Text == "Team1")
            {
                Console.WriteLine("New record updated sucessfully.");
            }
            else
            {
                Console.WriteLine("New record was not updated sucessfully.");
            }
            Thread.Sleep(2000);
        }
        public void DeleteTM(IWebDriver driver)

        {
            //4.Check if a user is able to delete an existing time/material record successfully

            //click on the delete option
            IWebElement deleteARow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteARow.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Delete button clicked");

            //click ok button
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
        }
    }
}
 