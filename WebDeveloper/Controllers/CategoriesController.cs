using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class CategoriesController : Controller
    {
        private CategoriesData _category = new CategoriesData();

        public FileContentResult GetImage(int id)
        {
            var categories = _category.GetCategoriesById(id);
            if (categories != null) return File(categories.Picture, categories.PictureContentType);
            else return null;
        }

        // GET: Categories
        public ActionResult Index()
        {
            return View(_category.GetList());
        }

        public ActionResult Create()
        {
            return View(new Categories());
        }

        [HttpPost]
        public ActionResult Create(Categories categories, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    categories.PictureContentType = image.ContentType;
                    categories.PictureFileName = image.FileName;
                    categories.Picture = new byte[image.ContentLength];
                    image.InputStream.Read(categories.Picture, 0, image.ContentLength);
                }
                _category.Add(categories);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var categories = _category.GetCategoriesById(id);

            if (categories == null)
                RedirectToAction("Index");
            return View(categories);

        }

        [HttpPost]
        public ActionResult Edit(Categories category)
        {
            if (ModelState.IsValid)
            {
                _category.Update(category);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int? id=0)
        {

            var categories = _category.GetCategoriesById(id);

            if (categories == null)
                RedirectToAction("Index");
            return View(categories);


        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var categories = _category.GetCategoriesById(id);

            if (categories == null) return View();

            if (_category.Delete(categories) > 0)
                return RedirectToAction("Index");
            return View(categories);

        }


    }
}