/* Project = Automating Flipkart using DDT and POM
 * Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
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
            test.Log(Status.Info, "Automation FaceBook");
            DoActions.DoActions.LoginToFlipkart(driver);
            
            System.Threading.Thread.Sleep(2000);
            //Takescreenshot();
            try
            {
                Console.WriteLine("Login sucessful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            Takescreenshot();
        }
       
    }
}