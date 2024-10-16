using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Application_HocSinh
{

    public partial class Form1 : Form
    {
        SqlDataReader sqlReader;
        SqlCommand sqlCommand;
        private List<HocSinh> ds;
        public Form1()
        {
            InitializeComponent();
        }

        //Button Đăng xuất
        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
            }
        }

        Modify modify = new Modify();
        private void button_Them_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            if(TextMSSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo"); return;
            }
            if(TextHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên", "Thông báo"); return;
            }
            if(TextDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo"); return;
            }
            hs.mshs = TextMSSV.Text;
            hs.hoten = TextHoTen.Text;
            hs.ngaysinh = DateTimeNS.Value;
            hs.diachi = TextDiaChi.Text;
            foreach (RadioButton rd in panel1.Controls)
            {
                if (rd != null)
                {
                    if (rd.Checked)
                    {
                        hs.phai = rd.Text;
                        break;
                    }
                }
            }
            ds.Add(hs);
            BindingSource bd = new BindingSource();
            bd.DataSource = ds;
            dataView.DataSource = bd;
            string query = "Insert into DanhSachHS " +
                           "values ('" + hs.mshs + "', N'" + hs.hoten + "','" + hs.ngaysinh + "',N'" + hs.phai + "',N'" + hs.diachi + "')";
            modify.Command(query);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new List<HocSinh>();
            show();
        }

        private void button_Xoa_Click(object sender, EventArgs e)                       
        {
            dataView.Rows.Clear();
            string query = "delete from DanhSachHS where masv = '" + TextMSSV.Text + "'";
            modify.Command(query);
            show();
        }

        public void show()
        {
            string query = "select masv, hoten, ngaysinh, phai, diachi from DanhSachHS";
            using (SqlConnection sqlConnection = Conection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    ds.Add(new HocSinh(sqlReader.GetString(0), sqlReader.GetString(1),
                          sqlReader.GetDateTime(2), sqlReader.GetString(3), sqlReader.GetString(4)));

                }
                BindingSource bd = new BindingSource();
                bd.DataSource = ds;
                dataView.DataSource = bd;
                sqlConnection.Close();
            }

        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Kiểm tra xem cột có phải là cột "MSSV" (giả sử cột "MSSV" có chỉ số 0)
                if (e.ColumnIndex == 0) // Thay đổi chỉ số cột nếu cần
                {
                    // Lấy giá trị của ô "MSSV"
                    var mssvValue = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    var hoten = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value;
                    var ngaysinh = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value;
                    var diachi = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value;

                    // Gán giá trị vào TextBox
                    TextMSSV.Text = mssvValue?.ToString(); // Sử dụng toán tử null để tránh lỗi
                    TextHoTen.Text = hoten?.ToString();
                    DateTimeNS.Value = Convert.ToDateTime(ngaysinh?.ToString());
                    TextDiaChi.Text = diachi?.ToString();
                }
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            dataView.Rows.Clear();
            string query = "update DanhSachHS set " +
                "masv = '" + TextMSSV.Text + "',hoten = N'"+TextHoTen.Text+"',diachi = N'"+TextDiaChi.Text+"' where masv = '"+TextMSSV.Text+"'";
            modify.Command(query);
            show();
            
        }
    }


}
