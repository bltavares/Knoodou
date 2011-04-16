using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace Knoodou.Internet
{
    class Mail
    {
        bool testarConexao()
        {
            Ping a = new Ping();
            return a.Send("http://google.com").Status == IPStatus.Success;
        }

        public bool enviarEmail(string email,string assunto,string msg)
        {
            string[] configs = buscarConfigs();
            if (configs[0] != "")
            {
                SmtpClient cliente = new SmtpClient(configs[2],Convert.ToInt32(configs[3]) );
                cliente.UseDefaultCredentials = false;
                cliente.EnableSsl = configs[4] == "TLS";
                cliente.Credentials = new System.Net.NetworkCredential(configs[0], configs[1]);

                MailMessage mensagem = new MailMessage(configs[0], email);
                mensagem.Body = msg;
                mensagem.Subject = assunto;
                try
                {
                    cliente.Send(mensagem);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        string[] buscarConfigs()
        {
            Banco.Config cf = new Banco.Config();
            cf.conectar();
            return cf.buscarEmail();
        }

        string buscarEmail()
        {
            return "a";
        }

    }
}
