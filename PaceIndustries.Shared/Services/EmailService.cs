using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PaceIndustries.Shared.Abstractions;
using System.Net;
using System.Net.Mail;

namespace PaceIndustries.Shared.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUser;
        private readonly string _smtpPass;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
   
            _smtpServer = _configuration["Smtp:Server"];
            _smtpPort = int.Parse(_configuration["Smtp:Port"]);
            _smtpUser = _configuration["Smtp:User"];
            _smtpPass = _configuration["Smtp:Password"];
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body, bool isBodyHtml = false)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(_smtpUser),
                Subject = subject,
                Body = body,
                IsBodyHtml = isBodyHtml,
            };

            mailMessage.To.Add(toEmail);

            using (var smtpClient = new SmtpClient(_smtpServer, _smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpUser, _smtpPass);
                smtpClient.EnableSsl = true;

                await smtpClient.SendMailAsync(mailMessage);
            }
        }

        public async Task SendPasswordEmailAsync(string toEmail, string userName, string password)
        {
            const string Subject = "Important: Your Password Has Been Reset for Security Reasons";

            string body = $@"<html>
                      <body>
                        <h2>Dear {userName},</h2>
                        <p>We hope this message finds you well.</p>
                        <p>Visit <a href='https://paceind.com'>Paceind Portal</a>
                        </p>
                        <p>Please use new, secure password: <strong>{password}</strong>
                        </p>
                        <p>If you need help or have any questions, please don't hesitate to contact our support team at <a href='mailto:helpportal@paceind.com'>helpportal@paceind.com</a>
                        </p>
                        <br>
                        <p>Thank you for your cooperation.</p>
                        <p>Best regards, <br>Pace Industries <br>Customer Support Team </p>
                      </body>
                    </html>";

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_smtpUser),
                Subject = Subject,
                Body = body,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(toEmail);

            using (var smtpClient = new SmtpClient(_smtpServer, _smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpUser, _smtpPass);
                smtpClient.EnableSsl = true;

                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}
