using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetEmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADO.Net Employee Payroll");
            Operation payroll = new Operation();
            int option;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Program number to get executed \n1.Add Data to Table \n2.Delete from Data Table\n3.Update Data  of Table\n4.View Data \n5.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmployeeModel obj = new EmployeeModel();
                        obj.Name = "Sneha";
                        obj.Salary = 20000.00;
                        obj.Startdate = DateTime.Now;
                        obj.gender = 'F';
                        obj.phoneNo = 9124234334;
                        obj.department = "Account";
                        obj.officeAddress = "Pune";
                        obj.Basic_Pay = 5000.00;
                        obj.deductions = 1000.00;
                        obj.taxable_pay = 300.00;
                        obj.income_tax = 400.00;
                        obj.net_pay = 25000;
                        obj.dept_id = 3;
                        var result = payroll.AddEmployee(obj);
                        if (result != null)
                        {
                            Console.WriteLine("Successfully Added");
                        }
                        else
                        {
                            Console.WriteLine("Not Added");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter id to Delete Data");
                        int num = Convert.ToInt32(Console.ReadLine());
                        payroll.DeleteEmployee(num);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}