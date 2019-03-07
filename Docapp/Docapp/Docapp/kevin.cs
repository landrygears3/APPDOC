using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Docapp
{
    class kevin
    {
        String dat="";
        public void SetPost(String json, String url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.0.101:49346/" + url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                dat = streamReader.ReadToEnd();


            }


        }

        public String GetPost() {
            return dat;
        }
    }
}
