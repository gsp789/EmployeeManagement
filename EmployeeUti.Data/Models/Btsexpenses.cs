using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class Btsexpenses
    {
        public int ExpenseId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int ExpenseSubCategoryId { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime ExpenseStartDate { get; set; }
        public DateTime ExpenseEndDate { get; set; }
        public int ClaimId { get; set; }
        public int StatusId { get; set; }
        public DateTime LastModifiedBy { get; set; }
        public int CurrencyType { get; set; }
        public int ApproverCount { get; set; }
        public int ApprovedCount { get; set; }

        public TravelClaims Claim { get; set; }
        public BtsbusinessTripExpenseCategory ExpenseCategory { get; set; }
        public BtsbusinessTripExpenseSubCategory ExpenseSubCategory { get; set; }
        public BtsclaimStatus Status { get; set; }
    }
}
