using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
namespace Parthas.PostAgent
{
    /// <summary>
    /// PostAgent class support posts
    /// </summary>
    public class PostAgent
    {
        private CookieContainer _CookieContainer;
        public PostAgent() { }
        
        public string Post(string aUrl, string aContent)
        {
            string lRetResponse = string.Empty;
            HttpWebRequest lRequest = WebRequest.Create(aUrl) as HttpWebRequest;
            byte[] lContentBuffer = System.Text.Encoding.UTF8.GetBytes(aContent);
            lRequest.Method = "POST";
            lRequest.ContentType = "application/x-www-form-urlencoded";
            lRequest.ContentLength = lContentBuffer.Length;
            if (_CookieContainer == null)
                _CookieContainer = new CookieContainer();
            lRequest.CookieContainer = _CookieContainer;
            using (Stream lRequestStream = lRequest.GetRequestStream()) 
            {
                lRequestStream.Write(lContentBuffer, 0, lContentBuffer.Length);
            }

            using (var lResponse = lRequest.GetResponse()) 
            {
                using (StreamReader lResponseStreamReader = new StreamReader(lResponse.GetResponseStream()))
                {
                    lRetResponse = lResponseStreamReader.ReadToEnd();
                }
            }
            return lRetResponse;
        }
        public void ResetCookie() 
        {
            _CookieContainer = null;
        }
    }

    
}
