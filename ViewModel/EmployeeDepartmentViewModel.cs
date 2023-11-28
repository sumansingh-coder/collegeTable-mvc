using CollegeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeProject.ViewModel
{
    public class EmployeeDepartmentViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}