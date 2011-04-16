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
    public partial class tlaConfigTwitter : Form
    {
        int speed = 30;
        bool configurado;
        Banco.Config config = new Banco.Config();

        public tlaConfigTwitter()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !configurado)
            {
                while (this.Height < 580)
                {
                    this.Height += speed;
                    Application.DoEvents();
                }
                navegador();
                configurado = true;
            }
            else
            {
                config.salvarTwitter("", "");
                while (this.Height > 95)
                {
                    this.Height -= speed;
                    Application.DoEvents();
                }
                webBrowser1.Visible = false;
                configurado = false;
            }
        }

        void navegador()
        {
            Internet.Twitter tw = new Internet.Twitter();
            webBrowser1.Visible = true;
            webBrowser1.Url = tw.autorizar();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //string html = webBrowser1.DocumentText;
            if(webBrowser1.Url.ToString() == "https://twitter.com/oauth/authorize")
            {
                Regex re = new Regex("  ([0-9]{7})");
                string pin = re.Match(webBrowser1.DocumentText).Value.Trim();
                if (pin != "")
                {
                    Internet.Twitter tw = new Internet.Twitter();
                    webBrowser1.Visible = false;
                    while (this.Height > 95)
                    {
                        this.Height -= speed;
                        Application.DoEvents();
                    }
                    tw.conectar(pin);
                }
            }

        }

        private void tlaConfigTwitter_Load(object sender, EventArgs e)
        {
            
            if (config.conectar())
            {
                configurado = config.twitterToken()[0] != "";
                checkBox1.Checked = configurado;
            }
            else
            {
                this.Close();
            }
        }
    }
}
