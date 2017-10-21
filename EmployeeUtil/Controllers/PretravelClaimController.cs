using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeUtil.Models;
using EmployeeUti.Data.Models;
using EmployeeUti.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeUtil.Controllers
{
    public class PretravelClaimController : Controller
    {
        public OMTIDBContext _context;
        public PretravelClaimController(OMTIDBContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(TravelClaimRequestViewModel model)
        {

            TravelClaims claim = new TravelClaims();
            
            
            claim.EmployeeId = 1567;
            claim.Destination = model.Destination;
            claim.StartDate = model.StartDate;
            claim.EndDate = model.EndDate;
            claim.BusinessPurpose = model.Purpose.Trim();
            claim.CreatedBy = "Hemanth";
            claim.EnterTime = DateTime.Now;
            claim.ModifieTime = DateTime.Now;
            _context.TravelClaims.Add(claim);
            _context.SaveChanges();
            var x = from user in _context.AdmUser
                    join userGroup in _context.AdmUserLevel on user.UserGroupId equals userGroup.UserGroupId
                    select userGroup;
            short xi = x.ToList()[0].ForwardUserGroupId;
            var Manager = from user in _context.AdmUser
                        where user.UserGroupId == xi
                        select user;
            foreach(AdmUser us in Manager)
            {
                EmailSender s = new EmailSender();

            }

            return View();    
        }
    }
}
