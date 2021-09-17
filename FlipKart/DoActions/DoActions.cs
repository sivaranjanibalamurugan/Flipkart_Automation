/* Project = Automating Flipkart using DDT and POM
 * Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
using FlipKart.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.DoActions
{
    public class DoActions
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Flipkart";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFlipkart(IWebDriver driver)
        {
           Pages.LoginPage login = new Pages.LoginPage(driver);
            ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\Flipkart_DDT.xlsx");
            Debug.WriteLine("***");
            login.email.SendKeys(ExcelOperation.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);
            login.password.SendKeys(ExcelOperation.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);
            login.submit.Click();
            System.Threading.Thread.Sleep(2000);
            login.searchkey.Click();
            System.Threading.Thread.Sleep(2000);
            login.searchkey.SendKeys(Keys.ArrowDown);
            login.searchkey.SendKeys(Keys.Enter);
            Base.BaseClass.Takescreenshot();
            System.Threading.Thread.Sleep(2000);
            try 
            {
                Console.WriteLine("Product Searched");
            }
            catch 
            {
                Console.WriteLine("Error");
            }
        }
    }
}
