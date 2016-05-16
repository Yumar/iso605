using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ISO605.Models.ApiClients
{
    public abstract class AbstractClient<T>
    {
        private HttpClient client;
        private string API_URL;
        public AbstractClient(string API_URL) {
            this.API_URL = API_URL;

            this.client = new HttpClient();
            this.client.BaseAddress = new Uri(ClientUtil.BASE_URL);
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public IEnumerable<T> getAll() {
            IEnumerable<T> items = null;
            try
            {
                HttpResponseMessage response = this.client.GetAsync(this.API_URL).Result;
                if (response.IsSuccessStatusCode)
                    items = (IEnumerable<T>)response.Content.ReadAsStreamAsync().Result;

            }
            catch {
            }
            return items;
        }
        public abstract T get(Guid id);
        public abstract T save(T item);
        public abstract T update(Guid id, T item);
        public abstract void delete(Guid id);
    }
}
