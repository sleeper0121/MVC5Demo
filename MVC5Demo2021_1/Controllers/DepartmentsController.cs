using MVC5Demo2021_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo2021_1.Controllers
{
    public class DepartmentsController : Controller
    {
        private ContosoUniversityEntities db = new ContosoUniversityEntities();
        // GET: Departments
        public ActionResult Index()
        {
            return View(db.Department);
        }

        public ActionResult Create()
        {
            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                db.Department.Add(department);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName");
            return View(department);
        }

        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpNotFoundResult();
            }
            var deaprement = db.Department.Find(id);
            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName");
            return View(deaprement);
        }

        [HttpPost]
        public ActionResult Edit(int id , Department department)
        {
            if (ModelState.IsValid)
            {
                var originalDate = db.Department.Find(id);
                originalDate.Name = department.Name;
                originalDate.Budget = department.Budget;
                originalDate.Person = department.Person;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName");
            return View(department);
        }
    }
}