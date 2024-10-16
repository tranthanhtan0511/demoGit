using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Application_HocSinh
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        public bool checkAccout(string ac)  //check mat khau va ten tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool checkEmail(string em) //Check email
        {
            return Regex.IsMatch(em, @"^[\w]{3,20}@gmail.com(.vn|)$"); // \w la giong a-zA-Z0-9 o tren
        }

        Modify modify = new Modify();
        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tk = textBox_TenTK.Text;
            string mk = textBox_MKDK.Text;
            string xnmk = textBox_XNMK.Text;
            string em = textBox_Email.Text;
            if (!checkAccout(tk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản dài 6-24 ký tự, bao gồm số và chữ hoa chữ thường");
                return;
            }
            if (!checkAccout(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, bao gồm số và chữ hoa chữ thường");
                return;
            }
            if(xnmk != mk)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }
            if (!checkEmail(em))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!");
                return;
            }
            if (modify.TaiKhoans("select * from TaiKhoan where Email = '" + em + "'").Count() != 0)
            {
                MessageBox.Show("Email đã tồn tại, Vui lòng nhập email khác!");
                return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tk + "', '" + mk + "','" + em + "')";
                modify.Command(query);
                
                if(MessageBox.Show("Bạn đã đăng ký thành công, bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
            }

        }
    }
}
