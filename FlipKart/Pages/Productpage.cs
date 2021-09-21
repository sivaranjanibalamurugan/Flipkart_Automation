using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public class Productpage:Base.BaseClass
    {
        public static void Products(IWebDriver driver)
        {
            IList<IWebElement> productbrand = driver.FindElements(By.XPath("(//div[@class ='_4rR01T'])"));
            foreach (IWebElement productbrandname in productbrand)
            {
                string brandname = productbrandname.Text;
                Console.WriteLine(brandname);
            }
        }
        public static void Products_price(IWebDriver driver)
        {
            IList<IWebElement> productprice = driver.FindElements(By.XPath("(//div[@class ='_30jeq3 _1_WHN1'])"));
            foreach (IWebElement productbrandname in productprice)
            {
                string brandprice = productbrandname.Text;
                Console.WriteLine(brandprice);
            }
        }
    }
}

