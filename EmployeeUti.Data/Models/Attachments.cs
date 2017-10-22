using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class Attachments
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int ExpenseId { get; set; }

        public Btsexpenses Expense { get; set; }
    }
}
