using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Knoodou
{
    public partial class tlaConfigFacebook : Form
    {
        bool configurado = false;
        int speed = 20;
        Banco.Config banco = new Banco.Config();

        public tlaConfigFacebook()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !configurado)
            {
                while (this.Height < 395)
                {
                    this.Height += speed;
                    Application.DoEvents();
                }
                webBrowser1.Visible = true;

                webBrowser1.Url = new Uri("https://graph.facebook.com/oauth/authorize?client_id=<app_id>&redirect_uri=http://www.facebook.com/connect/login_success.html&type=user_agent&display=popup&scope=publish_stream");
                configurado = true;

            }
            else
            {
                while (this.Height > 95)
                {
                    this.Height -= speed;
                    Application.DoEvents();
                }
                webBrowser1.Visible = false;
                configurado = false;
                banco.salvarFacebookConfig("", "");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Regex pagina = new Regex("^http://www.facebook.com/connect/login_success.html");
            if (pagina.Match(webBrowser1.Url.AbsoluteUri).Success)
            {
                pagina = new Regex("access_token=(?'pin'.+)&");
                string acesstoken = pagina.Match(webBrowser1.Url.AbsoluteUri).Groups["pin"].Value;
                pagina = new Regex("&expires_in=(.+)");
                string limit = pagina.Match(webBrowser1.Url.AbsoluteUri).Groups[0].Value;
                    
                banco.salvarFacebookConfig(acesstoken,limit);

                while (this.Height > 95)
                {
                    this.Height -= speed;
                    Application.DoEvents();
                }
                webBrowser1.Visible = false;
                configurado = false;
                webBrowser1.Navigate("javascript:void((function(){var a,b,c,e,f;f=0;a=document.cookie.split('; ');for(e=0;e<a.length&&a[e];e++){f++;for(b='.'+location.host;b;b=b.replace(/^(?:%5C.|[^%5C.]+)/,'')){for(c=location.pathname;c;c=c.replace(/.$/,'')){document.cookie=(a[e]+'; domain='+b+'; path='+c+'; expires='+new Date((new Date()).getTime()-1e11).toGMTString());}}}})())");

            }
        }

        private void tlaConfigFacebook_Load(object sender, EventArgs e)
        {
            if (banco.conectar())
            {
                configurado = banco.buscarFacebookToken()[0] != "";
                checkBox1.Checked = configurado;
            }
            else
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Alerta | knoodou");
                this.Close();
            }

        }
    }
}
