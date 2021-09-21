using FlipKart.Pages;
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
            
        }
    }
}
