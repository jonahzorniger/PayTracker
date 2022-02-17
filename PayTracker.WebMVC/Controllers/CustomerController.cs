using JobTracker.Models;
using PayTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayTracker.WebMVC.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var model = new CustomerListItem[0];
            return View(model);
        }

        //Get Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}