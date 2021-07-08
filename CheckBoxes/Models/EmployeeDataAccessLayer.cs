using CheckBoxes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxes.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestEmp;Data Source=DESKTOP-DNBQPIJ\\SQLEXPRESS";

      
        //To Add new employee record  
        public void AddEmployee(RegistrationModel employee)
        {
            string checkboxselect = "";
            for (int i = 0; i < employee.ServiceAreas.Count; i++)
            {
                if(employee.ServiceAreas[i].IsChecked)
                {
                    if(checkboxselect=="")
                    {
                        checkboxselect = employee.ServiceAreas[i].Text;
                    }
                    else
                    {
                        checkboxselect += "," + employee.ServiceAreas[i].Text;
                    }
                }
            }
            //string value = "";

            //for (int i = 0; i < CheckBoxModel.items.Count; i++)
            //{
            //    if (value != "")
            //    {
            //        value += ",";
            //    }
            //    value += CheckBoxModel.ServiceAreas[i].Text;
            //}
            //// Now you have all the values in comma (,) separated string.

            //string[] arr = value.Split(',');

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlquery = "Insert into [dbo].[Emp] (ServiceAreas) values('" + checkboxselect + "')";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                    con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Get the details of a particular employee
        public RegistrationModel GetEmployeeData(int? id)
        {
            RegistrationModel employee = new RegistrationModel();
           

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Emp WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    employee.ServiceAreas = rdr["ServiceAreas"] as List<CheckBoxModel>;

                    //employee.CompanyType = (CompanyType)Enum.Parse(typeof(CompanyType), rdr["CompanyType"].ToString());


                }
            }
            return employee;
        }

    
    }
}
