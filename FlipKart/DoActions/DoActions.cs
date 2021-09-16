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
    class DoActions
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Flipkart";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public void LoginToFaceBook(IWebDriver driver)
        {
            Debug.WriteLine("**");
            //Storing the data in the excel and run in it various dataset
            driver.FindElement(By.XPath("//input[@class='_2IX_2- VJZDxU']")).SendKeys(ExcelDataReader.ReadData(1, "email"));
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@class='_2IX_2- _3mctLh VJZDxU']")).SendKeys(ExcelDataReader.ReadData(1, "password"));
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2HKlqd _3AWRsL']//form//button[@type='submit']")).Click();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
