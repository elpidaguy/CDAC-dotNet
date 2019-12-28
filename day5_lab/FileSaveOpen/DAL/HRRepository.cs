using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class HRRepository
    {
        public static List<Employee> GetAll()
        { 
            List<Employee> EmpList = new List<Employee>();
            String sql = "Select * from Employees";
            string conn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dac\Documents\Visual Studio 2015\Projects\FileSaveOpen\GothamOnline\App_Data\GothamOnlineDB.mdf; Integrated Security = True";
            IDbConnection ic = new SqlConnection();
            ic.ConnectionString = conn;

            IDbCommand idbCommand = new SqlCommand(sql, ic as SqlConnection);

            try {
                ic.Open();
                IDataReader reader = idbCommand.ExecuteReader();
                while (reader.Read())
                {
                    EmpList.Add(new Employee { Id= int.Parse(reader["id"].ToString()), FirstName = reader["FirstName"].ToString(), LastName = reader["LastName"].ToString(), Email=reader["Email"].ToString(), ContactNumber=reader["ContactNumber"].ToString(), City=reader["City"].ToString() });
                }

                reader.Close();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally {
                if (ic.State == ConnectionState.Open)
                {
                    ic.Close();
                }
            }
            return EmpList;
        }

        public static Employee Get(int id)
        {
            Employee emp = null;
            String sql = "Select * from Employees where Id="+ id;
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\Documents\Visual Studio 2015\Projects\FileSaveOpen\GothamOnline\App_Data\GothamOnlineDB.mdf;Integrated Security=True";
            IDbConnection ic = new SqlConnection();
            ic.ConnectionString = conn;

            IDbCommand idbCommand = new SqlCommand(sql, ic as SqlConnection);

            try
            {
                ic.Open();
                IDataReader reader = idbCommand.ExecuteReader();
                while (reader.Read())
                {
                    emp = new Employee { Id = int.Parse(reader["id"].ToString()), FirstName = reader["FirstName"].ToString(), LastName = reader["LastName"].ToString(), Email = reader["Email"].ToString(), ContactNumber = reader["ContactNumber"].ToString(), City = reader["City"].ToString() };
                }

                reader.Close();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (ic.State == ConnectionState.Open)
                {
                    ic.Close();
                }
            }

            return emp;

        }
    }
}
