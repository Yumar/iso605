using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ISO605.Models.ApiClients
{
    public abstract class AbstractClient<T>
    {
        private string BASE_URL;
        public AbstractClient(string url) {
            this.BASE_URL = url;
        }
        public IEnumerable<T> getAll() {
            HttpClient client = new HttpClient();
        }
        public abstract T get(Guid id);
        public abstract T save(T item);
        public abstract T update(Guid id, T item);
        public abstract void delete(Guid id);
    }
}
