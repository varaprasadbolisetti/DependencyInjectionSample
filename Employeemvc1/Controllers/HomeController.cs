using Employeemvc1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemvc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

       // public HomeController(IEmployeeRepository employeeRepository)
        //{
            //employeeRepo = employeeRepository;
       // }
        public HomeController()
        {

        }
        public IActionResult index()
        {
            return View();

        }
        public JsonResult user([FromServices]IEmployeeRepository employeeRepository)
        {
            List<Employee> model = employeeRepository.GetEmployees();


            //connection to Database by using ADO.NET 

            //using (SqlConnection connection = new SqlConnection())
            //{
            //    connection.Open();
            //    connection.ConnectionString = "";
            //    SqlCommand command = new SqlCommand("SELECT * FROM TableName", connection);

            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //        }
            //    }
            //}
            

            return Json(model);


        }


    }
}
