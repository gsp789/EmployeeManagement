using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class BtsbusinessTripExpenseCategory
    {
        public BtsbusinessTripExpenseCategory()
        {
            BtsbusinessTripExpenseSubCategory = new HashSet<BtsbusinessTripExpenseSubCategory>();
            Btsexpenses = new HashSet<Btsexpenses>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public ICollection<BtsbusinessTripExpenseSubCategory> BtsbusinessTripExpenseSubCategory { get; set; }
        public ICollection<Btsexpenses> Btsexpenses { get; set; }
    }
}
