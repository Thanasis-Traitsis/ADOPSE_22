using ExamGate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace ExamGate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Privacy & ContactUs
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(SendMailDto sendMailDto)
        {
            if(!ModelState.IsValid) return View();
            try
            {
                MailMessage mail = new MailMessage();
                //my mail address, i will use a fake email "user@gmail.com"
                mail.From = new MailAddress("user@gmail.com");
                //to email address
                mail.To.Add("user@gmail.com");

                mail.Subject = sendMailDto.Subject;

                mail.IsBodyHtml = true;
                string content = "Name : " + sendMailDto.Name;
                content += "<br/> Message : " + sendMailDto.Message;

                mail.Body = content;

                //create SMTP instant
                //my email server
                SmtpClient smtpClient = new SmtpClient("mail.gmail.com");

                //the account and password that stored in local host in order to visit network resource
                NetworkCredential networkCredential = new NetworkCredential("user@gmail.com", "Password123");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                //a random port number
                smtpClient.Port = 25; 
                //if ssl required, you need to enable it
                smtpClient.EnableSsl = false;
                smtpClient.Send(mail);

                ModelState.Clear();

            }
            catch (Exception ex)
            {
                //Error message
                ViewBag.Message = ex.Message.ToString();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}