using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CategoriesData: BaseDataAccess<Categories>
    {
        public Categories GetCategoriesById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Categorie.FirstOrDefault(s => s.CategoryID == id);
                //return dbContext.Categories.Find(id);
            }

        }
    }
}
