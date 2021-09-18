using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart
{
    class ReportClass
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;

        public static ExtentReports report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Report\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "SivaRanjani");
                extent.AddSystemInfo("ProviderName", "SivaRanjani");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "FaceBook Automation");

                string conifgPath = @"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Report.xml";
                htmlReporter.LoadConfig(conifgPath);


            }
            return extent;
        }
    }
}
