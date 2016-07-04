using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeesData _employees = new EmployeesData();

        // GET: Employees
        public ActionResult Index()
        {
            return View(_employees.GetList());
        }

        public ActionResult Create()
        {
            return View(new Employees());
        }

        [HttpPost]
        public ActionResult Create(Employees employees)
        {
            if (ModelState.IsValid)
            {
                _employees.Add(employees);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var employees = _employees.GetEmployeesById(id);

            if (employees == null)
                RedirectToAction("Index");
            return View(employees);

        }

        [HttpPost]
        public ActionResult Edit(Employees employees)
        {
            if (ModelState.IsValid)
            {
                _employees.Update(employees);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int? id = 0)
        {

            var employees = _employees.GetEmployeesById(id);

            if (employees == null)
                RedirectToAction("Index");
            return View(employees);


        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var employees = _employees.GetEmployeesById(id);

            if (_employees.Delete(employees) > 0)
                return RedirectToAction("Index");
            return View(employees);

        }


    }
}