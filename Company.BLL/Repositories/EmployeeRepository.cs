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
    public class EmployeeRepository : GenericRepository<Employee>,IEmployeeRepository
    {
        private readonly MvcDbContext _dbContext;

        public EmployeeRepository(MvcDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Employee> GetEmployeeByAddress(string Address)
        
            => _dbContext.Employees.Where(E=>E.Address == Address);
        

        public IQueryable<Employee> SearchEmployeeByName(string SearchValue)
        
           => _dbContext.Employees.Where(E=>E.Name.ToLower().Contains(SearchValue.ToLower()));
        
    }
}
