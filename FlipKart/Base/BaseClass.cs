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

        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));
        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        [SetUp]
        public void SetUp()
        {
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            try
            {
                log.Info("Entering Setup");

                //local selenium webdriver
                driver = new ChromeDriver();
               //To maximize the window
               driver.Manage().Window.Maximize();

               driver.Url = "https://www.flipkart.com/";
                log.Debug("navigating to url");

                log.Info("Exiting setup");

            }

            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
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
