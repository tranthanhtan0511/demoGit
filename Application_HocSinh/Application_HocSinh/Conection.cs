using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Application_HocSinh
{
    class Conection
    {
        private static string stringConection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\hoc_tap\c++\OOP\giaodien\QuanLyHocSinh\Application_HocSinh\Application_HocSinh\Database1.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConection);
        }
    }
}
