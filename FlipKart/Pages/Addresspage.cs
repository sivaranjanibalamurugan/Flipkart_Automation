using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public class Addresspage
    {
        public Addresspage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[2]/div[2]")]
        [CacheLookup]
        public IWebElement newaddress;

        [FindsBy(How = How.Name, Using = "name")]
        [CacheLookup]
        public IWebElement name;

        [FindsBy(How = How.Name, Using = "phone")]
        [CacheLookup]
        public IWebElement phone;

        [FindsBy(How = How.Name, Using = "pincode")]
        [CacheLookup]
        public IWebElement pincode;

        [FindsBy(How = How.Name, Using = "addressLine2")]
        [CacheLookup]
        public IWebElement address1;

        [FindsBy(How = How.Name, Using = "addressLine1")]
        [CacheLookup]
        public IWebElement address;

        [FindsBy(How = How.Name, Using = "city")]
        [CacheLookup]
        public IWebElement city;

        [FindsBy(How = How.Name, Using = "state")]
        [CacheLookup]
        public IWebElement state;

        [FindsBy(How = How.Name, Using = "landmark")]
        [CacheLookup]
        public IWebElement landmark;


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div[1]/div[2]/div/div/div/div/div/label/div[2]/div/form/div/div[7]/div/div/label[1]/div[1]")]
        [CacheLookup]
        public IWebElement Home;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div[1]/div[2]/div/div/div/div/div/label/div[2]/div/form/div/div[8]/button")]
        [CacheLookup]
        public IWebElement save;




    }
}
