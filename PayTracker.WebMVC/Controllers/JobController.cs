using PayTracker.Models;
using PayTracker.Services;
using Microsoft.AspNet.Identity;
using PayTracker.WebMVC.Models;
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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var jobService = new JobService(userId);
            var model = jobService.GetJobs();

            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());

            var workTypeService = new WorkTypeService(userId);
            ViewBag.WorkTypeList = new SelectList(workTypeService.GetWorkTypes(), "WorkTypeId","WorkTypeName");

            
            var customerService = new CustomerService(userId);
            ViewBag.CustomerList = new SelectList(customerService.GetCustomers(), "CustomerId", "FullName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JobCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateJobService();

            if (service.CreateJob(model))
            {
               TempData["SaveResult"] = "Your job was created.";
               return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Job could not be created.");

            return View(model);
        }

        private JobService CreateJobService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new JobService(userId);
            return service;
        }

        public ActionResult Details (int id)
        {
            var svc = CreateJobService();
            var model = svc.GetJobById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateJobService();
            var detail = service.GetJobById(id);

            var model =
                new JobEdit
                {
                    JobId = detail.JobId,
                    WorkType = detail.WorkType,
                    Customer = detail.Customer,
                    Description = detail.Description,
                    SoldAmount = detail.SoldAmount,
                    Earnings = detail.Earnings
                };

            var userId = Guid.Parse(User.Identity.GetUserId());

            var workTypeService = new WorkTypeService(userId);
            ViewBag.WorkTypeList = new SelectList(workTypeService.GetWorkTypes(), "WorkTypeId", "WorkTypeName");


            var customerService = new CustomerService(userId);
            ViewBag.CustomerList = new SelectList(customerService.GetCustomers(), "CustomerId", "FullName");

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (int id, JobEdit model)
        {
            if(!ModelState.IsValid) return View(model);

            if(model.JobId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateJobService();

            if (service.UpdateJob(model))
            {
                TempData["SaveResult"] = "Your Job was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Job could not be updated");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateJobService();
            var model = svc.GetJobById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateJobService();

            service.DeleteJob(id);

            TempData["SaveResult"] = " Your Job was deleted";

            return RedirectToAction("Index");
        }
    }
}