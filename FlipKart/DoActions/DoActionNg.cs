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
    public class DoActionNg : Base.BaseClass
    {
        public static void LoginToFlipkart(IWebDriver driver)
        {
            Pages.LoginNgPage login = new Pages.LoginNgPage(driver);
            ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\FK_Negative.xlsx");
            Debug.WriteLine("***");
            //Entering mailid from resource
            login.email.SendKeys(ExcelOperation.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);


            //entering the password from resource
            login.password.SendKeys(ExcelOperation.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            //To click on submit 
            login.submit.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreEqual(driver.Url, "https://www.flipkart.com/");
            try
            {
                Console.WriteLine("Successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
