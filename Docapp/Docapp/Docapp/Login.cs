using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Docapp
{
    class Login
    {
        private kevin kv=new kevin();
        public void div(String pusr, String ppsw)
        {

            string json = "\"{pusr:'" + pusr + "',ppsw:'" + ppsw + "'}\"";
            kv.SetPost(json, "login");
            credenciales.Cred = kv.GetPost();
           
        }
    }

    }
