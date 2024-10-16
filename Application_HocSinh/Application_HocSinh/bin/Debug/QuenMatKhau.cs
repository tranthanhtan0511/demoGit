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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label_KQ.Text = "";
        }

        Modify modify = new Modify();
        private void button_LLMK_Click(object sender, EventArgs e)
        {
            string em = textBox_EmailDDK.Text;

            if(em.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí!");
            }
            else
            {
                string query = "select * from TaiKhoan where email = '" + em + "')";
                if (modify.TaiKhoans(query).Count() != 0)
                {
                    label_KQ.ForeColor = Color.Blue;
                    label_KQ.Text = "Mật khẩu: + "+ modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label_KQ.ForeColor = Color.Red;
                    MessageBox.Show("Không tìm thấy email mà bạn đăng ký");
                }
            }
        }
    }
}
