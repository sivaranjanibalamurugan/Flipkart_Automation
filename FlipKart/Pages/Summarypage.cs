using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public class Summarypage:Base.BaseClass
    {
        public Summarypage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[1]/div[3]/div/div/div/div/div[5]/span[1]/form/input")]
        [CacheLookup]
        public IWebElement Mail;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[1]/div[3]/div/div/div/div/div[5]/span[2]/button")]
        [CacheLookup]
        public IWebElement Next;


    }
}
