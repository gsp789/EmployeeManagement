using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeUtil.Models;

namespace EmployeeUtil.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            SampleUser u = new SampleUser();
            u.EmployeeId = 12345;
            return View(u);
        }
    }
}