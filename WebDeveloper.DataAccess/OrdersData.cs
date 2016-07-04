using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class OrdersData : BaseDataAccess<Orders>
    {
        public Orders GetOrdersById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                //return dbContext.Categories.FirstOrDefault(s => s.CategoryID == id);
                return dbContext.Order.Find(id);
            }

        }
    }
}
