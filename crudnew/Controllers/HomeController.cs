using crudnew.Data;
using crudnew.Models;
using crudnew.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace crudnew.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
       
        private readonly IStudentRepo student;
       
        public HomeController(ILogger<HomeController> logger, IStudentRepo student)
        {
            _logger = logger;
            this.student = student;
        }
        [Authorize]
        public IActionResult Index()
         {

            return View();
        }
        public IActionResult IndexGrid()
        {
            var d = student.GetAllStudents();

            return PartialView(d.AsQueryable());
        }


       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
