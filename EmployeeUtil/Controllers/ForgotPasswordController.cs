using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeUti.Data.Models;
using EmployeeUti.Data;
using EmployeeUtil.Models;

namespace EmployeeUtil.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private OMTIDBContext _context;
        private EmailSender _emailSender;
        public ForgotPasswordController(OMTIDBContext context)
        {
            _context = context;
            _emailSender = new EmailSender();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ForgotPasswordModel model)
        {
            
            Guid g = Guid.NewGuid();
            Email e = new Email();
            e.fromAddress = "ramireddy760@gmail.com";
            e.body = "Please use this code to reset your Password " + g.ToString();
            e.toAddress = new List<string> { model.Email };
            e.subject = "Reset your Password";
            _emailSender.SendEmail(e);
            

            return View();
        }
    }
}