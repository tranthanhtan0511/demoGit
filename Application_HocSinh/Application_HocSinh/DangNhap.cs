using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_HocSinh
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }


        Modify modify = new Modify();
        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string tk = textBox_TK.Text;
            string mk = textBox_MK.Text;
            if(tk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!!!");}
            else if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!!!");}
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tk + "' and MatKhau = '" + mk +"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MK.UseSystemPasswordChar = !textBox_MK.UseSystemPasswordChar;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
