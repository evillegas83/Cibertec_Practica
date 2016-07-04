using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Helpers
{
    public static class CustomeHelper
    {
        private static string GetHtmlPicture(byte[] picture)
        {
            return (picture == null) ? "<span>No picture available</span>" : $"<span>{picture}</span>";
        }

        public static IHtmlString DisplayPictureExtension(this HtmlHelper helper, byte[] picture)
        {
            return new HtmlString(GetHtmlPicture(picture));
        }

        public static List<Categories> DisplayCategoriesExtension(this HtmlHelper helper)
        {
            return new CategoriesData().GetList();
        }

        public static List<Employees> DisplayEmployeesExtension(this HtmlHelper helper)
        {
            return new EmployeesData().GetList();
        }

        public static List<Customers> DisplayCustomersExtension(this HtmlHelper helper)
        {
            return new CustomersData().GetList();
        }
    }
}