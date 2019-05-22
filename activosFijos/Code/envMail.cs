using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activosFijos.Code
{
    public class envMail
    {
        static MailMessage mail = new MailMessage();
        static string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public string sendPass(int tipo, string email, string contrasena, string codigo, string nombre)
        {

            string asunto = "", Msj = "", mailout = "fijos.activos01@gmail.com", pass = "fijos.act01";
            if (tipo == 1)
            {
                asunto = "ENVIO DE CREDENCIALES";
                Msj = nombre + ", por este medio se le envian sus credenciales para la aplicacion Activos Fijos\n\rUsuario: " + codigo + "\n\rContraseña: " + contrasena + "\n\rSaludos";
            }
            else
            {
                asunto = "RESET DE CONTRASEÑA";
                Msj = nombre + ", por este medio se le envian sus credenciales por reset de Contraseña para la aplicacion Activos Fijos\n\rUsuario: " + codigo + "\n\rContraseña: " + contrasena + "\n\rSaludos";
            }
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential(mailout, pass);

            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            mail = new MailMessage();
            try
            {
                mail.From = new MailAddress(mailout, "Activos Fijos", Encoding.UTF8);
                mail.To.Add(email);
                mail.Subject = asunto;
                mail.Body = Msj.ToString();
                //mail.Attachments.Add(new Attachment(ListBox1.Items[i].ToString()));
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //mail.ReplyTo = new MailAddress(correo);
                SmtpServer.Send(mail);
                return "Email enviado.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}