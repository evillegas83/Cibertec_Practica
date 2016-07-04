using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CustomersData : BaseDataAccess<Customers>
    {
        public Customers GetCustomersById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Customer.Find(id);
            }

        }
    }
}
