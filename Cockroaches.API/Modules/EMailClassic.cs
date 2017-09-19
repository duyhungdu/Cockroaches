﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using Cockroaches.Repository;
using Cockroaches.Repository.Queries;

namespace Cockroaches.API.Modules
{
    public class EMail: IIdentityMessageService
    {
        /// <summary>
        /// send email forgot password
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendAsync(IdentityMessage message)
        {
            await configSendGridasync(message);
        }
        /// <summary>
        /// Config email
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task configSendGridasync(IdentityMessage message)
        {
            string fromEmail = "suminshop.net@gmail.com";
            string fromEmailPassword = "duyhung6";
            dynamic MailMessage = new MailMessage();
            MailMessage.From = new MailAddress(fromEmail);
            MailMessage.To.Add(message.Destination);
            MailMessage.Subject = message.Subject;
            MailMessage.IsBodyHtml = true;
            MailMessage.Body = message.Body;

            SmtpClient SmtpClient = new SmtpClient();
            SmtpClient.Host = "smtp.gmail.com";
            SmtpClient.EnableSsl = true;
            SmtpClient.Port = 587;
            SmtpClient.Credentials = new System.Net.NetworkCredential(fromEmail, fromEmailPassword);

            try
            {
                try
                {
                    SmtpClient.Send(MailMessage);

                }
                catch (Exception ex)
                {

                }
            }
            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i <= ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.StatusCode;
                    if ((status == SmtpStatusCode.MailboxBusy) | (status == SmtpStatusCode.MailboxUnavailable))
                    {
                        System.Threading.Thread.Sleep(5000);
                        SmtpClient.Send(MailMessage);
                    }
                }
            }

        }

    }
}