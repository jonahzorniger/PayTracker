﻿using JobTracker.Models;
using JobTracker.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayTracker.WebMVC.Controllers
{
    [Authorize]
    public class WorkTypeController : Controller
    {
        // GET: WorkType
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkTypeService(userId);
            var model = service.GetWorkTypes();

            return View(model);
        }

        //Get the create view
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkTypeCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateWorkTypeService();

            if (service.CreateWorkType(model))
            {
                TempData["SaveResult"] = "Your Work Type was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Work Type could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateWorkTypeService();
            var model = svc.GetWorkTypeById(id);

            return View(model);
        }

        private WorkTypeService CreateWorkTypeService()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkTypeService(userid);
            return service;
        }
    }
}