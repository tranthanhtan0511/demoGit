using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_HocSinh
{
    class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoan() { }

        public TaiKhoan(string tk, string mk)
        {
            tenTaiKhoan = tk;
            matKhau = mk;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
