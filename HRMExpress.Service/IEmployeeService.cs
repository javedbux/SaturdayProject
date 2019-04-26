using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;

namespace HRMExpress.Service
{
    public interface IEmployeeService
    {
        IQueryable<Employee> GetEmployees();
        Employee GetUser(long id);
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee umployee);
        void DeleteEmployee(Employee umployee);
    }
}
