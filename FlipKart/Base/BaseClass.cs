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
using OpenQA.Selenium.Firefox;
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

        protected string browser;
        //default constructor
        public BaseClass()
        {

        }
        //parameterized constructor
        public BaseClass(string browser)
        {
            this.browser = browser;
        }
        [SetUp]
        public void SetUp()
        {
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            try
            {
                switch (browser)
                {

                    case "chrome":
                        //Creating an instance of chrome webdriver
                        ChromeOptions options = new ChromeOptions();
                        options.AddArguments("--disable-notifications");
                        
                        driver = new ChromeDriver(options);
                        break;
                    case "firefox":
                        //Creating an instance of firefox webdriver
                        driver = new FirefoxDriver();
                        break;
                    default:
                        driver = new ChromeDriver();
                        break;
                }

                //print which browser is started
                Console.WriteLine(browser + " Started");
                log.Debug("navigating to url");
                log.Info("Entering Setup");

                //local selenium webdriver
              //  driver = new ChromeDriver();
               //To maximize the window
               driver.Manage().Window.Maximize();

                driver.Url = "https://www.flipkart.com/";
                //driver.Url = "https://accounts.google.com/ServiceLogin/identifier?";
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
            screenshot.SaveAsFile(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Screenshot\f_k.png");
        }

    }
}
