using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public  class Placeorderpage : Base.BaseClass
    {
        public Placeorderpage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[1]/div[1]/div/div[10]/div/form/button")]
        [CacheLookup]
        public IWebElement buynow;
    }
}
