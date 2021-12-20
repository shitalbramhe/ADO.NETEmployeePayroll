using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetEmployeePayroll
{
    internal class Operation
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void Connection()
        {
            string constr = "Server=(localdb)\\MSSQLLocalDB;Database=payroll_service;Trusted_Connection=true";
            con = new SqlConnection(constr);

        }
        //To Add Employee details    
        public EmployeeModel AddEmployee(EmployeeModel obj)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("AddPayRoleServices", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", obj.Name);
                com.Parameters.AddWithValue("@Salary", obj.Salary);
                com.Parameters.AddWithValue("@gender", obj.gender);
                com.Parameters.AddWithValue("@Startdate", obj.Startdate);
                com.Parameters.AddWithValue("@phoneNo", obj.phoneNo);
                com.Parameters.AddWithValue("@department", obj.department);
                com.Parameters.AddWithValue("@officeaddress", obj.officeAddress);
                com.Parameters.AddWithValue("@Basic_Pay", obj.Basic_Pay);
                com.Parameters.AddWithValue("@deductions", obj.deductions);
                com.Parameters.AddWithValue("@taxable_pay", obj.taxable_pay);
                com.Parameters.AddWithValue("@income_tax", obj.income_tax);
                com.Parameters.AddWithValue("@net_pay", obj.net_pay);
                com.Parameters.AddWithValue("@dept_id", obj.dept_id);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();


                return obj;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //To Delete Employee details    
        public int DeleteEmployee(int id)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("DeletePayRoleService", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {

                    return id;

                }
                else
                {

                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //To Update Employee details 
        public bool UpdateEmployee(int id, string Name, string Salary)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("UpdatePayRoleServices", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Salary", Salary);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {

                    return true;

                }
                else
                {

                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
