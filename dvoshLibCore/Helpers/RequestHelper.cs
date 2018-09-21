using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;


namespace dvoshLibCore.Helpers
{
    class RequestHelper
    {
        internal static T MakeRequest<T>(string url) where T : class
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "text/json";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
            }
        }
    }
}
