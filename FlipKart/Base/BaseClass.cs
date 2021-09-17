/* Project = Automating Flipkart using DDT and POM
 * Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
using FlipKart.Resources;
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;


        [SetUp]
        public void SetUp()
        {

            //local selenium webdriver
            driver = new ChromeDriver();
            //To maximize the window
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.flipkart.com/";
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Screenshot\test2.png");
        }

    }
}
