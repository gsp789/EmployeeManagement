using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeUtil.Models;
using EmployeeUti.Data.Models;
using EmployeeUti.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace EmployeeUtil.Controllers
{
    public class ExpenseCreationController : Controller
    {
        public OMTIDBContext _context;
        public ExpenseCreationController(OMTIDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CreateExpenseModel model = new CreateExpenseModel();
            model.CategoryList = _context.BtsbusinessTripExpenseCategory.ToList();
            model.ApprovedTravelClaimList = _context.TravelClaims.ToList();
            model.SubCategorList = _context.BtsbusinessTripExpenseSubCategory.ToList();
            model.Expenses = _context.Btsexpenses.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(SubmitExpense model)
        {
            Btsexpenses expenses = new Btsexpenses();
            expenses.ClaimId = model.ApprovedClaimId;
            expenses.ExpenseAmount = model.Amount;
            expenses.ExpenseCategoryId = model.CategoryId;
            expenses.ExpenseStartDate = model.StartDate;
            expenses.ExpenseEndDate = model.EndDate;
            expenses.ExpenseSubCategoryId = model.SubCategoryId;
            expenses.LastModifiedBy = DateTime.Now;
            expenses.StatusId = 1;
            expenses.CurrencyType = model.CurrencyId;
            _context.Btsexpenses.Add(expenses);
            _context.SaveChanges();
            if (model.Attachment.Length > 0)
            {
                var fileName = model.Attachment.FileName;
                var filePath = "wwwroot\\Files\\";
                using (var stream = new FileStream(filePath + fileName, FileMode.Create))
                {
                    model.Attachment.CopyTo(stream);
                    Attachments attachment = new Attachments();
                    attachment.FilePath = filePath;
                    attachment.FileName = fileName;
                    attachment.Expense = expenses;
                    _context.Attachments.Add(attachment);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}