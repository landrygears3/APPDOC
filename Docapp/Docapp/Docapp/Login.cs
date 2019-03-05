using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Docapp
{
    class Login
    {
        Boolean dat;
        public Boolean div(String pusr, String ppsw)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.0.100:49346/values");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "\"{pusr:'" + pusr + "',ppsw:'" + ppsw + "'}\"";
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                dat = bool.Parse(streamReader.ReadToEnd());
                 
                if (!dat)
                {
                    throw new System.ArgumentException("Parameter cannot be null", "original");

                }
                
                return dat;
            }
        }



       /* public String Sum(String num1, String num2) {
            var url = "http://192.168.0.102:49346/values?Num1=" + num1 + "&Num2=" + num2;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                dat = reader.ReadToEnd().ToString();
            }
            
            return dat;
        }*/
        }

    }
