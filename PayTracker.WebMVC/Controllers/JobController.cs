﻿using JobTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayTracker.WebMVC.Controllers
{
    [Authorize]
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            var model = new JobListItem[0];
            return View(model);
        }

    }
}