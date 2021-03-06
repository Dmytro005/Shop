﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly SmtpClient _smtpClient;
        public NetworkCredential Credential { get; set; }

        public EmailSender(NetworkCredential credential, string host, int port)
        {
            _smtpClient = new SmtpClient(host, port)
            {
                EnableSsl = true
            };
            Credential = credential;
            _smtpClient.Credentials = Credential;
        }
        public async Task<bool> SendEmailAsync(string from, string email, string subject, string message)
        {
            try
            {
                await _smtpClient.SendMailAsync(new MailMessage(from, email, subject, message));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
