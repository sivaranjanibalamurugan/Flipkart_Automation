/* Project = Automating Flipkart using DDT and POM
 * Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace FlipKart.Resources
{
    public class Tests:Base.BaseClass
    {
        
        [Test]
        //Reading the data from the Excel file
        public void ReadingDataFromExcelFile()
        {
            //DoActions.DoActions.LoginToFlipkart(driver);
            ExcelDataReader.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\Flipkart_DDT.xlsx");
            System.Threading.Thread.Sleep(4000);
        }
        [Test]

        public void load_complete()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0,0,20));
            System.Threading.Thread.Sleep(4000);
            // Wait for the page to load
            if (wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")))
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Not Successfull");
            }
            Takescreenshot();
        }
        [Test]
        public void Search()
        {
            DoActions.DoActions.SearchKey(driver);
            Takescreenshot();
        }
        
    }
}