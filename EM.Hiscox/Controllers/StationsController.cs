using EM.Hiscox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EM.Hiscox.Controllers
{
    public class StationsController : ApiController
    {
        IRepository _repository;

        public StationsController(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<string> GetSations(string searchTerm)
        {
            // TODO: handle nulls and exception handling
            
            return _repository.GetSations(searchTerm);
        }

        public IEnumerable<string> GetAll()
        {
            // TODO: exception handling

            return _repository.GetAll();
        }

        
    }
}
