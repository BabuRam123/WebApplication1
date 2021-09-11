using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class Courseservice
    {
        //private static string db_source = "azuresqlvm.database.windows.net";
        //private static string db_user = "azureuser1";
        //private static string db_pwd = "Zxcvb@123";
        //private static string db_name = "appdbb";
        ////azuresqlvm
        private SqlConnection GetConnection(string conn)
        {
            //var _builder = new SqlConnectionStringBuilder();
            //_builder.DataSource = db_source;
            //_builder.UserID = db_user;
            //_builder.Password = db_pwd;
            //_builder.InitialCatalog = db_name;
            return new SqlConnection(conn);

        }

        public IEnumerable<Course> GetCourses(string conn)
        {
            DataSet ds = new DataSet();
            List<Course> lst = new List<Course>();
            string sql = "select * from Course";
            SqlConnection connection = GetConnection(conn);
            connection.Open();
            SqlCommand sqlcmd = new SqlCommand(sql, connection);
            using (SqlDataReader reader = sqlcmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    Course cour = new Course()
                    {
                        CourseID = reader.GetInt32(0),
                        CourseName = reader.GetString(1),
                        Rating = reader.GetDecimal(2)
                    };
                    lst.Add(cour);

                }
                
            }
            connection.Close();
            return lst;

           


            
            

        }
    }
}
