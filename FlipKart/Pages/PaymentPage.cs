using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public class PaymentPage
    {
        public  PaymentPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[1]/div[4]/div/div/div[1]/div/label[6]/div[1]")]
        [CacheLookup]
        public IWebElement COD;
    }
}
