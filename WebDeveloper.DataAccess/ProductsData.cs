using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductsData : BaseDataAccess<Products>
    {
        public Products GetProductsById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Product.Find(id);
            }

        }

    }
}
