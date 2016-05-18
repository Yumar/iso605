using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using ISO605.Models.ApiClients;

namespace ISO605.Models
{
    class CompetenciasClient : IClient<Competencias>
    {
        public void delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Competencias get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Competencias> getAll()
        {
            throw new NotImplementedException();
        }

        public Competencias save(Competencias item)
        {
            throw new NotImplementedException();
        }

        public Competencias update(Guid id, Competencias item)
        {
            throw new NotImplementedException();
        }
    }
}
