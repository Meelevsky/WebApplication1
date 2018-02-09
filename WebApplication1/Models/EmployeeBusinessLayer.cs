﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "Lukasz";
            emp.LastName = "Walenciak";
            emp.Salary = 14000;
            employees.Add(emp);


            emp = new Employee();
            emp.FirstName = "Pawel";
            emp.LastName = "Garuski";
            emp.Salary = 20000;
            employees.Add(emp);


            emp = new Employee();
            emp.FirstName = "Maciej";
            emp.LastName = "Milewski";
            emp.Salary = 6210;
            employees.Add(emp);

            return employees;
        }
    }
}