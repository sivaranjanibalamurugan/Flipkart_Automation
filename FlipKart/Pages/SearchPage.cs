using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public class Search_Page 
    {
        public Search_Page(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//input[@class='_2IX_2- VJZDxU'])")]
        [CacheLookup]
        public IWebElement mail;

        [FindsBy(How = How.XPath, Using = "(//input[@class='_2IX_2- _3mctLh VJZDxU'])")]
        [CacheLookup]
        public IWebElement pass;

        [FindsBy(How = How.XPath, Using = "(//button[@class='_2KpZ6l _2HKlqd _3AWRsL'])")]
        [CacheLookup]
        public IWebElement login;

        [FindsBy(How = How.Name, Using = "q")]
        [CacheLookup]
        public IWebElement searchkey;

         [FindsBy(How = How.XPath, Using = "(//div[@class='_4rR01T'])")]
         [CacheLookup]
         public IWebElement product;
    }
}
