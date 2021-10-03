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
            try
            {
                Pages.LoginPage login = new Pages.LoginPage(driver);
                ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\Flipkart_DDT.xlsx");
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
                //validation using url
                Assert.AreEqual(driver.Url, "https://www.flipkart.com/");

                Console.WriteLine("Successful");
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Failed");
            }

            /*  login.cart.Click();
              System.Threading.Thread.Sleep(2000);*/
        }
       public static void search_product(IWebDriver driver)
        {
            try
            {
                DoActions.LoginToFlipkart(driver);
                //creating instance
                Pages.Search_Page search = new Pages.Search_Page(driver);

                search.searchkey.Click();
                System.Threading.Thread.Sleep(2000);


                //To add the neede product to the search bar 
                search.searchkey.SendKeys(Keys.ArrowDown);
                search.searchkey.SendKeys(Keys.Enter);
                Base.BaseClass.Takescreenshot();
                System.Threading.Thread.Sleep(2000);
                search.product.Click();
                System.Threading.Thread.Sleep(2000);

                //Validation 
                string expected = "Filters";
                string actual = driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/section[1]/div/div/span")).Text;
                Console.WriteLine(" Meassage: {0}", actual);
                Assert.AreEqual(expected, actual);
                Console.WriteLine("Successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }


        }
           public static void Result_Page(IWebDriver driver)
           {
               DoActions.search_product(driver);

               //creating instance
               Pages.ResultPage result = new Pages.ResultPage(driver);

               result.product.Click();
               driver.SwitchTo().Window(driver.WindowHandles[1]);
               System.Threading.Thread.Sleep(8000);

               result.fav.Click();
               //driver.SwitchTo().Window(driver.WindowHandles[2]);
               System.Threading.Thread.Sleep(8000);

              result.addtobag.Click();
              System.Threading.Thread.Sleep(4000);

            //Validation using text
            string expected = "My Cart (8)";
            string actual = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[1]/div/div[1]/div[1]/div/div[1]")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
             try
             {
                   Console.WriteLine("successful");
             }
               catch
             {
                   Console.WriteLine("Failed");
             }
           }
         public static void PlaceOrder(IWebDriver driver)
          {
              DoActions.Result_Page(driver);
              Pages.Placeorderpage place = new Pages.Placeorderpage(driver);
              place.buynow.Click();
              System.Threading.Thread.Sleep(8000);

            //validation using text 
            string expected = "LOGIN";
            string actual = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[1]/div/div/div/div[1]")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            try
            {
                Console.WriteLine("successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
         }
        public static void Address_Page(IWebDriver driver)
         {
             DoActions.PlaceOrder(driver);

             Pages.Addresspage address = new Pages.Addresspage(driver);

             address.newaddress.Click();
             System.Threading.Thread.Sleep(4000);

             ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\Flipkart_Address.xlsx");
             Debug.WriteLine("***");

             address.name.SendKeys(ExcelOperation.ReadData(1, "name"));
             System.Threading.Thread.Sleep(8000);

             address.phone.SendKeys(ExcelOperation.ReadData(1, "phone"));
             System.Threading.Thread.Sleep(8000);

             address.pincode.SendKeys(ExcelOperation.ReadData(1, "pincode"));
             System.Threading.Thread.Sleep(8000);

             address.address1.SendKeys(ExcelOperation.ReadData(1, "address1"));

             address.address.SendKeys(ExcelOperation.ReadData(1, "address"));
             System.Threading.Thread.Sleep(8000);

            /* address.city.SendKeys(ExcelOperation.ReadData(1, "city"));
             System.Threading.Thread.Sleep(8000);

             address.state.SendKeys(ExcelOperation.ReadData(1, "state"));
              System.Threading.Thread.Sleep(8000);*/

             address.landmark.SendKeys(ExcelOperation.ReadData(1, "landmark"));
             System.Threading.Thread.Sleep(8000);

             address.Home.Click();
              System.Threading.Thread.Sleep(8000);

             address.save.Click();
             System.Threading.Thread.Sleep(8000);

            //Validation
            string expected = "PRICE DETAILS";
            string actual = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/span")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            try
            {
                Console.WriteLine("successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }

        }
         public static void Summary(IWebDriver driver)
          {
              DoActions.Address_Page(driver);
              Pages.Summarypage summary = new Pages.Summarypage(driver);
            /*  ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\Flipkart_summary.xlsx");
              Debug.WriteLine("***");

              summary.Mail.SendKeys(ExcelOperation.ReadData(1, "Mail"));
              System.Threading.Thread.Sleep(4000);*/

              summary.Next.Click();
              System.Threading.Thread.Sleep(4000);

            //Validation
            string expected = "PRICE DETAILS";
            string actual = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/span")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            try
            {
                Console.WriteLine("successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
        }
         public static void Payment(IWebDriver driver)
          {
              DoActions.Summary(driver);
              Pages.PaymentPage payment = new Pages.PaymentPage(driver);

              payment.COD.Click();
              System.Threading.Thread.Sleep(8000);

            //Validation
            string expected = "PRICE DETAILS";
            string actual = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/span")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            try
            {
                Console.WriteLine("successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
        }
        public static void LoginToFk(IWebDriver driver)
          {
              try
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

                //Validation
                  Assert.AreEqual(driver.Url, "https://www.flipkart.com/");

                  Console.WriteLine("Successful");
              }
              catch
              {
                  Console.WriteLine("Failed");
              }

            }
        }
    }
