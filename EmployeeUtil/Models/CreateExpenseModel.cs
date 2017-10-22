using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeUti.Data.Models;

namespace EmployeeUtil.Models
{
    public class CreateExpenseModel
    {
        public List<BtsbusinessTripExpenseCategory> CategoryList;
        public List<BtsbusinessTripExpenseSubCategory> SubCategorList;
        public List<TravelClaims> ApprovedTravelClaimList;
        public List<Btsexpenses> Expenses;
    }
}
