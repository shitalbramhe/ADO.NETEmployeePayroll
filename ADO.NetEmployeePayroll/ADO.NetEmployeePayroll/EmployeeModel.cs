using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetEmployeePayroll
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime Startdate { get; set; }
        public char gender { get; set; }
        public double phoneNo { get; set; }
        public string department { get; set; }
        public string officeAddress { get; set; }
        public double Basic_Pay { get; set; }
        public double deductions { get; set; }
        public double taxable_pay { get; set; }
        public double income_tax { get; set; }
        public double net_pay { get; set; }
        public int dept_id { get; set; }
    }
}
