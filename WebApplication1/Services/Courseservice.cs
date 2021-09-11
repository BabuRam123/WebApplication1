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

        public IEnumerable<Course> GetCourses(string con)
        {
           List<Course> lst = new List<Course>();
                    Course cour = new Course()
                    {
                        CourseID = 1,
                        CourseName = "Hi",
                        Rating = 4,
                        connec=con
                    };
                    lst.Add(cour);

            
            return lst;


        }
    }
}
