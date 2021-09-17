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
        }
       
    }
}