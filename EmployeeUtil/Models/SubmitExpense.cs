using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EmployeeUtil.Models
{
    public class SubmitExpense
    {
        public int ApprovedClaimId { get; set; }
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public IFormFile Attachment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CurrencyId { get; set; }
    }
}
