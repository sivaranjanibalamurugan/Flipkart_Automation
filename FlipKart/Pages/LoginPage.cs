/* Project = Automating Flipkart using DDT and POM
 * Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //To locate the webelement 
        [FindsBy(How = How.XPath, Using = "(//input[@class='_2IX_2- VJZDxU'])")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.XPath, Using = "(//input[@class='_2IX_2- _3mctLh VJZDxU'])")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "(//button[@class='_2KpZ6l _2HKlqd _3AWRsL'])")]
        [CacheLookup]
        public IWebElement submit;
    }
}
      