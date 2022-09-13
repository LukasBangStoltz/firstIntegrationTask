using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MiniProject1
{
    public class utils
    {

        public static HttpClient ApiClient { get; set; }

        public static HttpClient GetClient(string baseUrl)
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri(baseUrl);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return ApiClient;
        }
    }



}

