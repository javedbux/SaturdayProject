using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;
using HRMExpress.Data;

namespace HRMExpress.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> employeeRepository;
        private IRepository<Department> departmentRepository;

        
        public EmployeeService(IRepository<Employee> employeeRepository, IRepository<Department> departmentRepository)
        {
            this.employeeRepository = employeeRepository;
            this.departmentRepository = departmentRepository;
        }
        public IQueryable<Employee> GetEmployees()
        {
           return employeeRepository.Table;
        }

        public Employee GetUser(long id)
        {
            return employeeRepository.GetById(id);
        }

        public void InsertEmployee(Employee employee)
        {
            employeeRepository.Insert(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeRepository.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            employeeRepository.Delete(employee);
        }
    }
}
