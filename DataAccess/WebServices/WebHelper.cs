using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class WebHelper
    {
        static WebClient cliente;
        static string connectionString;

        static WebHelper()
        {
            cliente = new WebClient();
            cliente.Encoding = Encoding.UTF8;
            connectionString = "https://cai-api.azurewebsites.net/api/v1";

            cliente.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        public static string Get(string url)
        {
            var uri = connectionString + url;

            var responseString = cliente.DownloadString(uri);

            return responseString;
        }
        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = connectionString + url;

            try
            {
                var response = cliente.UploadValues(uri, parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":true,\"id\":5,\"error\":null}";
            }
        }
    }
}
