using Company.BLL.Interfaces;
using Company.DaL.Contexts;
using Company.DaL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>,IDepartmentRepository
    {
        

        public DepartmentRepository(MvcDbContext dbContext):base(dbContext)
        {
            
        }
      
    }
}
