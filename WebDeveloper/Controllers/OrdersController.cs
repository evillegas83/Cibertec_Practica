using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class OrdersController : Controller
    {
        private OrdersData _orders = new OrdersData();
        // GET: Orders
        public ActionResult Index()
        {
            return View(_orders.GetList());
        }

        public ActionResult Create()
        {
            return View(new Orders());
        }

        [HttpPost]
        public ActionResult Create(Orders orders)
        {
            if (ModelState.IsValid)
            {
                _orders.Add(orders);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var orders = _orders.GetOrdersById(id);

            if (orders == null)
                RedirectToAction("Index");
            return View(orders);

        }

        [HttpPost]
        public ActionResult Edit(Orders orders)
        {
            if (ModelState.IsValid)
            {
                _orders.Update(orders);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int? id = 0)
        {

            var orders = _orders.GetOrdersById(id);

            if (orders == null)
                RedirectToAction("Index");
            return View(orders);


        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var orders = _orders.GetOrdersById(id);
            if (orders == null) return View();

            if (_orders.Delete(orders) > 0)
                return RedirectToAction("Index");
            return View(orders);

        }


    }
}