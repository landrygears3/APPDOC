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
        Boolean dat;
        public Boolean div(String pusr, String ppsw)
        {

            string json = "\"{pusr:'" + pusr + "',ppsw:'" + ppsw + "'}\"";
            kv.SetPost(json, "login");
            dat = Convert.ToBoolean(kv.GetPost());
            

            return dat;
        }
    }

    }
