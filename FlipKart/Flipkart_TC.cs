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
    public class Tests : Base.BaseClass
    {
        ExtentReports reports = ReportClass.report();
        ExtentTest test;/*
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
        }*/
        [Test, Order(0)]
        public void search_products()
        {

            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation Flipkart");
            //DoActions.DoActions.LoginToFlipkart(driver);
            DoActions.DoActions_search.search_product(driver);
            System.Threading.Thread.Sleep(3000);
            Takescreenshot();
        }
        [Test, Order(1)]
        public void Product_list()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation Flipkart");
            DoActions.DoActions_search.search_product(driver);
            Pages.Productpage.Products(driver);
            test.Log(Status.Pass, "ProductBrand tescases Passed");
            reports.Flush();
            System.Threading.Thread.Sleep(3000);
            Takescreenshot();
        }
        [Test, Order(2)]
        public void Product_price()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation Flipkart");
            DoActions.DoActions_search.search_product(driver);
            Pages.Productpage.Products_price(driver);
            test.Log(Status.Pass, "ProductPrice tescases passed");
            reports.Flush();
            System.Threading.Thread.Sleep(200);
            Takescreenshot();

        }
        [Test, Order(3)]
        public void Product_rating()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation Flipkart");
            DoActions.DoActions_search.search_product(driver);
            Pages.Productpage.Products_rating(driver);
            test.Log(Status.Pass, "ProductPrice tescases passed");
            reports.Flush();
            System.Threading.Thread.Sleep(200);
            Takescreenshot();
        }
    }
}