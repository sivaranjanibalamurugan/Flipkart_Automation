/*
*Project = Automating Flipkart using DDT and POM
* Created by = SIVA RANJANI B
 * created on = 16/09/21
 */
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart.Pages
{
    public class MailPage:Base.BaseClass
    {
           public static ExcelOperation excel;
            //Here we are reading the data from excel
            public static void ReadDataFromExcel(IWebDriver driver)
            {
                excel = new ExcelOperation();
                ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Resources\fK_GM.xlsx");
            }



            public static void email_send(IWebDriver driver)
            {
                excel = new ExcelOperation();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //we are sending our from mail id
                mail.From = new MailAddress(ExcelOperation.ReadData(1, "FromMail"));
                //we are adding to mail id
                mail.To.Add(ExcelOperation.ReadData(1, "ToMail"));
                //Subject of the mail is added
                mail.Subject = "Flipkart test mail";
                //Body of the mail is added
                mail.Body = "mail with Flipkart report using config attachmement";
                Attachment attachment;
                attachment = new Attachment(@"C:\Users\sivaranjani.b\source\repos\FlipKart\FlipKart\Report\index.html");
                Assert.NotNull(attachment);
                //here we attach the report of the automation
                mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential(ExcelOperation.ReadData(1, "FromMail"), ExcelOperation.ReadData(1, "Password"));
                SmtpServer.EnableSsl = true;
                //Here we click send mail 
                SmtpServer.Send(mail);
            try
            {
                Console.WriteLine("Successfull");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
       }
        
    }
}
