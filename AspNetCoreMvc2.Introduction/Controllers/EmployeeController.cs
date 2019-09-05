using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee()
            };
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }
    }
}