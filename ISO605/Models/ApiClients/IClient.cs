using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace ISO605.Models.ApiClients
{
    public abstract class AbstractClient<T>
    {
        private RestClient client;
        private string API_URL;
        public AbstractClient(string API_URL)
        {
            this.API_URL = API_URL;
            this.client = new RestClient(ClientUtil.BASE_URL);
        }
        public IEnumerable<T> getAll()
        {
            IEnumerable<T> items = null;
            
            try
            {
                var request = new RestRequest(this.API_URL, Method.GET);
                RestResponse<T> response = client.Execute<T>(request);
            }
            catch
            {
            }
            return items;
        }
        public T get(Guid id)
        {
            try
            {
                HttpResponseMessage response = this.client.GetAsync(this.API_URL).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsStreamAsync().Result.;

            }
            catch
            {
                return null;
            }

        }
        public abstract T save(T item);
        public abstract T update(Guid id, T item);
        public abstract void delete(Guid id);
    }
}
