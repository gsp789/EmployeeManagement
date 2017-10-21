using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeUtil.Models;
using EmployeeUti.Data.Models;
using System.Security.Cryptography;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeUtil
{
    public class UserLoginController : Controller
    {
        private OMTIDBContext _context;
        public UserLoginController(OMTIDBContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult Index( LoginViewModel model )
        {
            if(string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
            {
                return View();
            }
            string sha1password = model.Password;
            var userDetails = from user in _context.AdmUser
                              where user.UserName == model.UserName 
                              select user;
            AdmUser user1 = (AdmUser)userDetails.ToList()[0];
            byte[] EmployeeId = BitConverter.GetBytes(user1.EmployeeId);
            byte[] userId = BitConverter.GetBytes(user1.EmployeeId);

            HttpContext.Session.Set("EmployeeId", EmployeeId);
            HttpContext.Session.Set("UserId", userId);

            if (user1.Password == model.Password)
            {
                ViewData["UserId"] = user1.UserId;
                ViewData["EmployeeId"] = user1.EmployeeId;
                return RedirectToAction("Index", "PretravelClaim");
                //return RedirectToAction("Index", "PretravelClaim");
            }

            ViewData["errorMessage"] = "Please make sure your password is correct";
            return View();
        }

        public IActionResult Forgot()
        {
            return View();
        }
    }
}
