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
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace FlipKart.Resources
{
    public class Tests : Base.BaseClass
    {
        ExtentReports reports = ReportClass.report();
        ExtentTest test;
        /*     [Test,Order(0)]
               //Reading the data from the Excel file
               public void ReadingDataFromExcelFile()
               {
                   test = reports.CreateTest("Tests");
                   test.Log(Status.Info, "Automation Flipkart");
                   DoActions.DoActions.LoginToFlipkart(driver);            
                   System.Threading.Thread.Sleep(200);
               //calling the screenshot method
                   Takescreenshot();
                //adding screenshot to the report
                   test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Screenshot\test.png").Build());
                   test.Log(Status.Pass, "Test Passes");
                   reports.Flush();
            }
           [Test, Order(1)]
            public void search_products()
            {

                test = reports.CreateTest("Tests");
                test.Log(Status.Info, "Automation Flipkart");
                //DoActions.DoActions.LoginToFlipkart(driver);
                DoActions.DoActions_search.search_product(driver);
                System.Threading.Thread.Sleep(3000);
               //calling the screenshot method
                  Takescreenshot();
               //adding screenshot to the report
               test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Screenshot\test2.png").Build());
                test.Log(Status.Pass, "Test Passes");
                reports.Flush();
            }
            [Test, Order(2)]
            public void Product_list()
            {
                test = reports.CreateTest("Tests");
                test.Log(Status.Info, "Automation Flipkart");
                DoActions.DoActions_search.search_product(driver);
                Pages.Productpage.Products(driver);
               System.Threading.Thread.Sleep(3000);
               //calling the screenshot method
               Takescreenshot();
               test.Log(Status.Pass, "ProductBrand tescases Passed");
                reports.Flush();

            }
            [Test, Order(3)]
            public void Product_price()
            {
                test = reports.CreateTest("Tests");
                test.Log(Status.Info, "Automation Flipkart");
                DoActions.DoActions_search.search_product(driver);
                Pages.Productpage.Products_price(driver);
               System.Threading.Thread.Sleep(200);
               //calling the screenshot method
               Takescreenshot();
               test.Log(Status.Pass, "ProductPrice tescases passed");
                reports.Flush();


            }
            [Test, Order(4)]
            public void Product_rating()
            {
                test = reports.CreateTest("Tests");
                test.Log(Status.Info, "Automation Flipkart");
                DoActions.DoActions_search.search_product(driver);
                Pages.Productpage.Products_rating(driver);
               System.Threading.Thread.Sleep(200);
               //Calling the screenshot method
               Takescreenshot();
               test.Log(Status.Pass, "ProductPrice tescases passed");
                reports.Flush();

            }
                 [Test, Order(5)]
                 public void sendmail()
                 {
                     //driver.Url ="https://accounts.google.com/ServiceLogin/identifier?";
                     Pages.MailPage.ReadDataFromExcel(driver);
                     Pages.MailPage.email_send(driver);
                     //Calling the screenshot method
                      Takescreenshot();
                 }

                 [Test, Order(6)]
                 public void Sendingmail()
                 {
                     try
                     {
                         // driver.Url = "https://accounts.google.com/ServiceLogin/identifier?";
                         MailMessage mail = new MailMessage();
                         string fromEmail = ConfigurationManager.AppSettings["Email"];
                         string password = ConfigurationManager.AppSettings["password"];
                         String ToEmail = ConfigurationManager.AppSettings["ToReportEmail"];
                         mail.From = new MailAddress(fromEmail);
                         mail.Subject = "Automating the Report";
                         mail.To.Add(ToEmail);
                         mail.Priority = MailPriority.High;
                         mail.IsBodyHtml = true;
                         mail.Attachments.Add(new Attachment(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Report\index.html"));
                         SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                         smtp.Port = 587;
                         smtp.UseDefaultCredentials = false;
                         object fromMail = null;
                         smtp.Credentials = new NetworkCredential((string)fromMail, (string)password);
                         smtp.EnableSsl = true;
                         smtp.Send(mail);
                     }
                     catch
                     {
                           Console.WriteLine("Failed");
                     }
                 }*/
        /*      [Test,Order(7)]
              public void Addtofav()
              {
                  DoActions.DoActionRP.Result_Page(driver);
                 //call screenshot method
                  Takescreenshot();
              }
        
            [Test,Order(8)]
            public void Cart()
            {
             DoActions.DoActionRP.Result_Page(driver);
            System.Threading.Thread.Sleep(2000);
                //call screenshot method
                 Takescreenshot();
      }*/
        /*  [Test,Order(9)]
            public void buynow()
            {
            DoActions.DoActionPlaceOrder.PlaceOrder(driver);
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();

            }*/
        [Test]
        public void AddressDetails()
        {
            DoActions.AddressPage.Address_Page(driver);
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
        }
         /*[Test,Order(11)]
            //Negative testcase
            public void Test_InvalidLogin()
            {
                DoActions.DoActionNg.LoginToFlipkart(driver);
                 string expected = "+91";
                string actual = driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/span[2]")).Text;
               //string actual = driver.FindElement(By.ClassName("_2YULOR")).Text;
                Console.WriteLine("Error Meassage: {0}", actual);
                 Assert.AreEqual(expected, actual);
                 //call screenshot method
                 Takescreenshot();
        }*/
    }
}

    
