using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class CustomersController : Controller
    {
        private CustomersData _customers = new CustomersData();
        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers.GetList());
        }

        public ActionResult Create()
        {
            return View(new Customers());
        }

        [HttpPost]
        public ActionResult Create(Customers customers)
        {
            if (ModelState.IsValid)
            {
                _customers.Add(customers);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var customers = _customers.GetCustomersById(id);

            if (customers == null)
                RedirectToAction("Index");
            return View(customers);

        }

        [HttpPost]
        public ActionResult Edit(Customers customers)
        {
            if (ModelState.IsValid)
            {
                _customers.Update(customers);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int? id = 0)
        {

            var customers = _customers.GetCustomersById(id);

            if (customers == null)
                RedirectToAction("Index");
            return View(customers);


        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var customers = _customers.GetCustomersById(id);

            if (customers == null) return View();

            if (_customers.Delete(customers) > 0)
                return RedirectToAction("Index");
            return View(customers);

        }


    }
}