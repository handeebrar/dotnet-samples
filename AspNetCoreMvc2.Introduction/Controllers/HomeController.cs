using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class HomeController : Controller
    {
        //controller'ı direk çalıştırma
        public string Index()
        {
            return "Hello from first application";
        }

        //controller'dan view çalıştırma
        public ViewResult Index2()
        {
            return View();
        }

        //controller'dan model çağırarak view çalıştırma
        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName="A", LastName="B", CityId=6 },
                new Employee{Id=1, FirstName="C", LastName="D", CityId=6 },
                new Employee{Id=1, FirstName="E", LastName="F", CityId=45 }
            };

            List<string> cities = new List<string> {"İstanbul","Ankara"};

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                cities = cities
            };

            return View(model);
        }
    }
}