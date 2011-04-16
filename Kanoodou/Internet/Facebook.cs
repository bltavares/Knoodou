using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Knoodou.Internet
{
    class Facebook
    {
        public void postarNoFB(string msg)
        {
            WebRequest fb = WebRequest.Create("https://graph.facebook.com/me/feed");
            fb.Method = "POST";
            fb.ContentType = "application/x-www-form-urlencoded";
            Banco.Config conf = new Banco.Config();
            conf.conectar();
            string accesstoken = conf.buscarFacebookToken()[0];

            byte[] byteArray = Encoding.UTF8.GetBytes("access_token=" + accesstoken + "&message="+msg);
            fb.ContentLength = byteArray.Length;
            System.IO.Stream dataStream = fb.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            fb.GetResponse();
        }
    }
}
