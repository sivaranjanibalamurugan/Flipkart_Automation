/* Project = Automating Flipkart using DDT and POM
 * Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace FlipKart.Resources
{
    public class Tests:Base.BaseClass
    {
        ExtentReports reports = ReportClass.report();
        ExtentTest test;
        [Test]
        //Reading the data from the Excel file
        public void ReadingDataFromExcelFile()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation Flipkart");
            DoActions.DoActions.LoginToFlipkart(driver);            
            System.Threading.Thread.Sleep(200);
          
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            Takescreenshot();
        }
        [Test]
        public void search_products()
        {

            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation Flipkart");
            //DoActions.DoActions.LoginToFlipkart(driver);
            DoActions.DoActions_search.search_product(driver);
            System.Threading.Thread.Sleep(3000);
            Takescreenshot();
        }
        
    }
}