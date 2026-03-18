using System;
using System.Collections.Generic;
using System.Text;

namespace Telas.Platforms.Services
{
   public static class ApiService<T> where T: class
    {
        private static HttpClient client;

        public static HttpClient Client
        {
            get
            {
                if (client == null) 
                { 
                    client = new HttpClient();
                    client.BaseAddress = new url("http://127.0.0.1:5500/api/")
                }
                return client;
            }
            public async static Task<List<T>> GetList()
        }

    }
}
