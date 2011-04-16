using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twitterizer;

namespace Knoodou.Internet
{
    class Twitter
    {

        string ConsumerKey = "CYLO8z7VdEdNfq5Y8p6WA";
        string ConsumerSecret = "2mXLnmwoC5NfAnHgs1wgEUP5LvJnTU3gvZLtb9s";
        static OAuthTokenResponse tk;

        public Uri autorizar()
        {
            tk = OAuthUtility.GetRequestToken(ConsumerKey, ConsumerSecret, "oob");
            return OAuthUtility.BuildAuthorizationUri(tk.Token);
        }

        public bool conectar(string pin)
        {
            OAuthTokenResponse accessToken = OAuthUtility.GetAccessToken(ConsumerKey, ConsumerSecret,tk.Token, pin);
            salvarToken(accessToken.Token,accessToken.TokenSecret);
            return accessToken.ScreenName != "";
        }

        void salvarToken(string token,string secret)
        {
            Banco.Config config = new Banco.Config();
            if (config.conectar())
            {
                config.salvarTwitter(token,secret);
            }
        }

        string[] buscarToken()
        {
            Banco.Config config = new Banco.Config();
            if (config.conectar())
            {
                return config.twitterToken();
            }
            return new string[2];
        }

        public void novaMensagem(string msg)
        {
            if (buscarToken()[0] != "")
            {
                OAuthTokens token = new OAuthTokens();
                token.AccessToken = buscarToken()[0];
                token.AccessTokenSecret = buscarToken()[1];
                token.ConsumerKey = ConsumerKey;
                token.ConsumerSecret = ConsumerSecret;
                TwitterStatus.Update(token, msg);
            }
        }
    }
}
