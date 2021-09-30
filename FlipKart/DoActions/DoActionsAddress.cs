using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.DoActions
{
    public class AddressPage:Base.BaseClass
    {
        public static void Address_Page(IWebDriver driver)
        {
            DoActionPlaceOrder.PlaceOrder(driver);

            Pages.Addresspage address = new Pages.Addresspage(driver);
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

 /*           address.city.SendKeys(ExcelOperation.ReadData(1, "city"));
            System.Threading.Thread.Sleep(8000);

            address.state.SendKeys(ExcelOperation.ReadData(1, "state"));
            System.Threading.Thread.Sleep(8000);*/

            address.landmark.SendKeys(ExcelOperation.ReadData(1, "landmark"));
            System.Threading.Thread.Sleep(8000);

            address.Home.Click();
            System.Threading.Thread.Sleep(8000);

            address.save.Click();
            System.Threading.Thread.Sleep(8000);

        }
    }
}
