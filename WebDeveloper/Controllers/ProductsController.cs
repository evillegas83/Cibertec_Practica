using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductsController : Controller
    {
        private ProductsData _products = new ProductsData();

        // GET: Products
        public ActionResult Index()
        {
            return View(_products.GetList());
        }

        public ActionResult Create()
        {
            return View(new Products());
        }

        [HttpPost]
        public ActionResult Create(Products product)
        {
            if (ModelState.IsValid)
            {
                _products.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var products = _products.GetProductsById(id);

            if (products == null)
                RedirectToAction("Index");
            return View(products);

        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            if (ModelState.IsValid)
            {
                _products.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int? id = 0)
        {

            var products = _products.GetProductsById(id);

            if (products == null)
                RedirectToAction("Index");
            return View(products);


        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var products = _products.GetProductsById(id);

            if (products == null) return View();

                if (_products.Delete(products) > 0)
                return RedirectToAction("Index");
            return View(products);

        }

    }
}