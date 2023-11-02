using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace API.Entities
{
    public class Utilitarios
    {

        public void EnviarCorreo(string destino, string asunto, string contenido)
        {
                        MailMessage emailMessage = new MailMessage();
                        emailMessage.From = new MailAddress("jhernandez30256@ufide.ac.cr");
                        emailMessage.To.Add(new MailAddress(destino));
                        emailMessage.Subject = asunto;
                        emailMessage.Body = contenido;
                        emailMessage.Priority = MailPriority.Normal;
                        SmtpClient MailClient = new SmtpClient("smtp.office365.com", 587);
                        MailClient.Credentials = new System.Net.NetworkCredential("proyectoprograweb@outlook.com", "Fidelitas.123");
                        MailClient.EnableSsl = true;
                        MailClient.Send(emailMessage);
        }
    }
}