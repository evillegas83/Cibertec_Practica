using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class EmployeesData : BaseDataAccess<Employees>
    {
        public Employees GetEmployeesById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Employee.Find(id);
            }

        }

    }
}
