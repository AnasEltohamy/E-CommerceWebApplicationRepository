using Company.BLL.Interfaces;
using Company.DaL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MvcDbContext _dbContext;

        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }
        public UnitOfWork(MvcDbContext dbContext)
        {
            EmployeeRepository=new EmployeeRepository(dbContext);
            DepartmentRepository=new DepartmentRepository(dbContext);
            _dbContext = dbContext;
        }

        public async Task<int> complete()
        {
            return await _dbContext.SaveChangesAsync();
        }

      

        public void Dispose()
        => _dbContext.Dispose();
    }
}
