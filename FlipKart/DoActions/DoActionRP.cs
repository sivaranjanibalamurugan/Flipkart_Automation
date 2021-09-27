using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.DoActions
{
   public class DoActionRP:Base.BaseClass
    {
        
        public static void Result_Page(IWebDriver driver)
        {
            //creating instance
            Pages.ResultPage result = new Pages.ResultPage(driver);

            result.mail.SendKeys("8667361462");
            System.Threading.Thread.Sleep(3000);


            result.pass.SendKeys("sivabalaan10");
            System.Threading.Thread.Sleep(3000);


            //To click on submit 
            result.login.Click();
            System.Threading.Thread.Sleep(2000);

            //  search.searchkey.SendKeys(ExcelOperation.ReadData(1, "search"));
            //To click on the search bar
            result.searchkey.Click();
            System.Threading.Thread.Sleep(2000);


            //To add the neede product to the search bar 
            result.searchkey.SendKeys(Keys.ArrowDown);
            result.searchkey.SendKeys(Keys.Enter);
            Base.BaseClass.Takescreenshot();
            System.Threading.Thread.Sleep(2000);
            result.product.Click();
            System.Threading.Thread.Sleep(2000);
            // Assert.AreEqual(driver.Url, "https://www.flipkart.com/search?q=mobiles&as=on&as-show=on&otracker=AS_Query_TrendingAutoSuggest_1_0_na_na_na&otracker1=AS_Query_TrendingAutoSuggest_1_0_na_na_na&as-pos=1&as-type=TRENDING&suggestionId=mobiles&requestId=1852842a-f8db-4d4e-b781-0ea872f35c21&as-backfill=on");
            try
            {
                Console.WriteLine("successful");
            }
            catch
            {
                Console.WriteLine("Failed");
            }

             result.fav.Click();
             System.Threading.Thread.Sleep(4000);

            /* result.addtocart.Click();
             System.Threading.Thread.Sleep(2000);*/
          /*  result.addcart.Click();
            System.Threading.Thread.Sleep(2000);*/




        }
    }
}
