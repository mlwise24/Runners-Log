using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class RunInputController : Controller
    {
        private ApplicationDbContext _context;

        public RunInputController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: RunInput
       public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(RunInput runInput)
        {
           
            
            _context.RunInputs.Add(runInput);
            _context.SaveChanges();

            return RedirectToAction("Index", "RunInput");
        }
    }
}