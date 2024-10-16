using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Application_HocSinh
{
    class Modify
    {
        public Modify()
        {
        }

        SqlCommand sqlCommand; // dùng để truy vấn các câu lệnh
        SqlDataReader sqlDataReader; //dùng để đọc dữ liệu trong bảng

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Conection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(sqlDataReader.GetString(0), sqlDataReader.GetString(1))); //doc tung cot trong table
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }

        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Conection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); // Thực thi câu truy vấn
                sqlConnection.Close();
            }

        }


    }
}
