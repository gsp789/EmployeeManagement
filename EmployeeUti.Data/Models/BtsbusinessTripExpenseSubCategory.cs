using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class BtsbusinessTripExpenseSubCategory
    {
        public BtsbusinessTripExpenseSubCategory()
        {
            Btsexpenses = new HashSet<Btsexpenses>();
        }

        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string Description { get; set; }
        public int Limit { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ValidFrom { get; set; }

        public BtsbusinessTripExpenseCategory Category { get; set; }
        public ICollection<Btsexpenses> Btsexpenses { get; set; }
    }
}
