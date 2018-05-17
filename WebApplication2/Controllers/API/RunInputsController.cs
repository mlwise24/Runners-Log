using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers.API
{
    public class RunInputsController : ApiController
    {

        private ApplicationDbContext _context;

        public RunInputsController()
        {
            _context = new ApplicationDbContext();
        }
    
        public IEnumerable<RunInput> GetRunInputs()
        {
            return _context.RunInputs.ToList();
        }
    }
}
