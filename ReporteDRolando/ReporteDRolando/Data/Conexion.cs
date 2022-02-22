using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteDRolando.Data
{
    public class Conexion
    {
        public SqlConnection connect = new SqlConnection();

        public Conexion(String user, String pass)
        {
            try
            {

                connect = new SqlConnection("Server=CCBB20\\SQLSERVER2019;Database=CV;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {


            }
        }
    }
}