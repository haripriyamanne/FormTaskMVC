using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithDatabaseADO.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestEmp;Data Source=DESKTOP-DNBQPIJ\\SQLEXPRESS";

        //To View all employees details  
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> lstemployee = new List<Employee>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();

                    employee.ID = Convert.ToInt32(rdr["Id"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.PhoneNumber = rdr["PhoneNumber"].ToString();
                    employee.Gender = (Gender)Enum.Parse(typeof(Gender), rdr["Gender"].ToString());
                    employee.CompanyName = rdr["CompanyName"].ToString();
                    employee.CompanyType = (CompanyType)Enum.Parse(typeof(CompanyType), rdr["CompanyType"].ToString());
                    employee.CompanyLimited = rdr["CompanyLimited"].ToString();
                    employee.CompanyWebsite = rdr["CompanyWebsite"].ToString();
                    employee.Busineess = rdr["Busineess"].ToString();
                    employee.Benifits = rdr["Benifits"].ToString();
                    employee.ListProducts = rdr["ListProducts"].ToString();
                    //employee.ServiceAreas= (List<CheckBoxModel>)rdr["ServiceAreas"];
                    employee.ImportantAreas = rdr["ImportantAreas"].ToString();
                    employee.WebsiteExample= rdr["WebsiteExample"].ToString();
                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
        }

        //To Add new employee record  
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@CompanyName", employee.CompanyName);
                cmd.Parameters.AddWithValue("@CompanyType", employee.CompanyType);
                cmd.Parameters.AddWithValue("@CompanyLimited", employee.CompanyLimited);
                cmd.Parameters.AddWithValue("@CompanyWebsite", employee.CompanyWebsite);
                cmd.Parameters.AddWithValue("@Busineess", employee.Busineess);
                cmd.Parameters.AddWithValue("@Benifits", employee.Benifits);
                cmd.Parameters.AddWithValue("@ListProducts", employee.ListProducts);
                cmd.Parameters.AddWithValue("@TrustElements", employee.TrustElements);
                //cmd.Parameters.AddWithValue("@ServiceAreas", employee.ServiceAreas);
                cmd.Parameters.AddWithValue("@ImportantAreas", employee.ImportantAreas);
                cmd.Parameters.AddWithValue("@WebsiteExample", employee.WebsiteExample);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Get the details of a particular employee
        public Employee GetEmployeeData(int? id)
        {
            Employee employee = new Employee();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Employees WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    employee.ID = Convert.ToInt32(rdr["Id"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.PhoneNumber = rdr["PhoneNumber"].ToString();
                    employee.Gender = (Gender)Enum.Parse(typeof(Gender), rdr["Gender"].ToString());
                    employee.CompanyName = rdr["CompanyName"].ToString();
                    employee.CompanyType = (CompanyType)Enum.Parse(typeof(CompanyType), rdr["CompanyType"].ToString()); 
                    employee.CompanyLimited = rdr["CompanyLimited"].ToString();
                    employee.CompanyWebsite = rdr["CompanyWebsite"].ToString();
                    employee.Busineess = rdr["Busineess"].ToString();
                    employee.Benifits = rdr["Benifits"].ToString();
                    employee.ListProducts = rdr["ListProducts"].ToString();
                    //employee.ServiceAreas = (List<CheckBoxModel>)rdr["ServiceAreas"];
                    employee.ImportantAreas = rdr["ImportantAreas"].ToString();
                    employee.WebsiteExample = rdr["WebsiteExample"].ToString();
                }
            }
            return employee;
        }

    
    }
}
