using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace WebApplication1
{
    public class Correo
    {
        Boolean estado = true;
        string merror;
        public Correo(string destinatario, string Asunto, string mensaje)
        {
            MailMessage Correo = new MailMessage();
            SmtpClient protocolo = new SmtpClient();

            Correo.To.Add(destinatario);
            Correo.From = new MailAddress("elccoco1995@hotmail.com", "rosa elena", System.Text.Encoding.UTF8);
            Correo.Subject = Asunto;
            Correo.SubjectEncoding = System.Text.Encoding.UTF8;
            Correo.Body = mensaje;
            Correo.BodyEncoding = System.Text.Encoding.UTF8;
            Correo.IsBodyHtml = false;
            protocolo.Credentials = new System.Net.NetworkCredential("elccoco1995@hotmail.com", "santander");
            protocolo.Port = 587;
            protocolo.Host = "smtp.gmail.com";
            protocolo.EnableSsl = true;
            try
            {
                protocolo.Send(Correo);
            }
            catch(SmtpException error)
            {
                estado = false;
                merror = error.Message.ToString();
            }

          

        }

        
        public Boolean Estado
        {
            get { return estado; }
        }

        public string mensade_error
        {
            get { return merror; }
        }
    }

}