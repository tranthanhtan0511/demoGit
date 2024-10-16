using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_HocSinh
{
    public class HocSinh
    {
        string m_mshs;
        string m_hoten;
        DateTime m_ngaysinh;
        string m_phai;
        string m_diachi;

        //Khởi tạo hàm không có tham số
        public HocSinh()
        {
            m_mshs = "";
            m_hoten= "";
            m_ngaysinh = DateTime.Now;
            m_phai = "";
            m_diachi = "";
        }

        //Khởi tạo hàm có tham số
        public HocSinh(string mshs, string hoten, DateTime ngaysinh, string phai, string diachi)
        {
            m_mshs = mshs;
            m_hoten= hoten;
            m_ngaysinh = ngaysinh;
            m_phai = phai;
            m_diachi = diachi;
        }

        //xây dựng các properties
        public string mshs
        {
            get { return m_mshs; }
            set { m_mshs = value; }
        }

        public string hoten
        {
            get { return m_hoten; }
            set { m_hoten = value; }
        }

        public DateTime ngaysinh
        {
            get { return m_ngaysinh; }
            set { m_ngaysinh = value; }
        }

        public string phai
        {
            get { return m_phai; }
            set { m_phai = value; }
        }

        public string diachi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }
    }
}
