﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using MonolegalTest.Models;

namespace MonolegalTest.Services
{
    public class EmailSender: IEmailSender
    {
        private SmtpClient Cliente { get; }
        private EmailSenderOptions Options { get; }

        public EmailSender(IOptions<EmailSenderOptions> options)
        {
            Options = options.Value;
            Cliente = new SmtpClient()
            {
                Host = Options.Host,
                Port = Options.Port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Options.Email, Options.Password),
                EnableSsl = Options.EnableSsl,
            };
        }
            public Task SendEmailAsync(string email, string subject, string message)
            {
                var correo = new MailMessage(from: Options.Email, to: email, subject: subject, body: message);
                correo.IsBodyHtml = true;
                return Cliente.SendMailAsync(correo);
            }
        }
        public interface IEmailSender
        {
            Task SendEmailAsync(string email, string subject, string message);
        }
    }
