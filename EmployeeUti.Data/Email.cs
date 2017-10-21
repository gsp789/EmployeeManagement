using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeUti.Data
{
    public class Email
    {
        public string subject { get; set; }
        public List<String> toAddress { get; set; }
        public string body { get; set; }
        public string fromAddress { get; set; }
    }
}
