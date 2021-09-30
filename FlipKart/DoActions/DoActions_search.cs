/*
*Project = Automating Flipkart using DDT and POM
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
    public class DoActions_search:Base.BaseClass
    {
        public static void search_product(IWebDriver driver)
        {
            try
            {
                //creating instance
                Pages.Search_Page search = new Pages.Search_Page(driver);

            search.mail.SendKeys("8667361462");
            System.Threading.Thread.Sleep(3000);
           

            search.pass.SendKeys("sivabalaan10");
            System.Threading.Thread.Sleep(3000);
           

            //To click on submit 
            search.login.Click();
            System.Threading.Thread.Sleep(2000);
          
            //  search.searchkey.SendKeys(ExcelOperation.ReadData(1, "search"));
            //To click on the search bar
            search.searchkey.Click();
            System.Threading.Thread.Sleep(2000);
          

            //To add the neede product to the search bar 
            search.searchkey.SendKeys(Keys.ArrowDown);
            search.searchkey.SendKeys(Keys.Enter);
            Base.BaseClass.Takescreenshot();
            System.Threading.Thread.Sleep(2000);
            search.product.Click();
            System.Threading.Thread.Sleep(2000);

          // Assert.AreEqual(driver.Url , "https://www.flipkart.com/search?q=mobiles&as=on&as-show=on&otracker=AS_Query_TrendingAutoSuggest_1_0_na_na_na&otracker1=AS_Query_TrendingAutoSuggest_1_0_na_na_na&as-pos=1&as-type=TRENDING&suggestionId=mobiles&requestId=6d716191-7bca-4fa9-9b64-379e2fb0a0e5&as-backfill=on");
            
            // Assert.AreEqual(actualUrl, expectedUrl);
           
                Console.WriteLine("successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
            
        }
       
    }
}
