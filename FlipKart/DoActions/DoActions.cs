/* Project = Automating Flipkart using DDT and POM
 * Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
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
        public static void LoginToFlipkart(IWebDriver driver)
        {
           //ExcelDataReader.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\Flipkart_DDT.xlsx");
            Debug.WriteLine("**");
            System.Threading.Thread.Sleep(4000);
            //Storing the data in the excel and run in it various dataset
            driver.FindElement(By.ClassName("email")).SendKeys(ExcelDataReader.ReadData(1, "email"));
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.ClassName("password")).SendKeys(ExcelDataReader.ReadData(1, "password"));
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.ClassName("submit")).Click();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.ClassName("searchkey")).Click();
            System.Threading.Thread.Sleep(4000);
        }
        public static void SearchKey(IWebDriver driver)
        {
            IWebElement MyElement = driver.FindElement(By.Name("q"));
            MyElement.SendKeys(Keys.F10);MyElement.SendKeys(Keys.Down);
            MyElement.SendKeys(Keys.Enter);
        }
    }
}
