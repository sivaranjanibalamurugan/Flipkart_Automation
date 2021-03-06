/*
*Project = Automating Flipkart using DDT and POM
* Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
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
        public  void Products()
        {
            Console.WriteLine("****************Products************************");
            IList<IWebElement> productbrand = driver.FindElements(By.XPath("(//div[@class ='_4rR01T'])"));
            foreach (IWebElement productbrandname in productbrand)
            {
                string brandname = productbrandname.Text;
                Console.WriteLine(brandname);
            }
            
        }
        public  void Products_price()
        {
            Console.WriteLine("****************Products_Price************************");
            IList<IWebElement> productprice = driver.FindElements(By.XPath("(//div[@class ='_30jeq3 _1_WHN1'])"));
            foreach (IWebElement productbrandname in productprice)
            {
                string brandprice = productbrandname.Text;
                Console.WriteLine(brandprice);
            }
        }

        public  void Products_rating()
        {
            Console.WriteLine("****************Products_rating************************");
            IList<IWebElement> productrating = driver.FindElements(By.XPath("(//div[@class ='_3LWZlK'])"));
            foreach (IWebElement productbrandname in productrating)
            {
                string brandrating = productbrandname.Text;
                Console.WriteLine(brandrating);
            }
        }
    }
}

