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
    class CompetenciasClient : AbstractClient<Competencias>
    {
        private static string BASE_URL = "http://localhost:14327/ISO605/api/";
        public CompetenciasClient() : base(BASE_URL)
        {
        }

        public override void delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Competencias get(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Competencias save(Competencias item)
        {
            throw new NotImplementedException();
        }

        public override Competencias update(Guid id, Competencias item)
        {
            throw new NotImplementedException();
        }
    }
}
