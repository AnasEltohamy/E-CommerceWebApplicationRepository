﻿using Company.DaL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Interfaces
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
       IQueryable<Employee>GetEmployeeByAddress(string Address);
        IQueryable<Employee> SearchEmployeeByName(string SearchValue);
    }
}
