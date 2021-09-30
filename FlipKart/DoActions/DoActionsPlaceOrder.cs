using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.DoActions
{
   public class DoActionPlaceOrder:Base.BaseClass
    {
        public static void PlaceOrder(IWebDriver driver)
        {
            DoActionRP.Result_Page(driver);
            Pages.Placeorderpage place = new Pages.Placeorderpage(driver);
            place.buynow.Click();
        }
    }
}
