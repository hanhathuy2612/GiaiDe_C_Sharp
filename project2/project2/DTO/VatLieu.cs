using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.DTO
{
    class VatLieu
    {
        private int maVl;
        private string tenVl;
        private string donVi;
        private decimal giaNhap;
        private decimal giaBan;
        private string fileAnh;
        private string ghiChu;
        private int soLuong;

        public VatLieu(string tenVl, string donVi, decimal giaNhap, decimal giaBan, string fileAnh, string ghiChu, int soLuong)
        {
            this.tenVl = tenVl;
            this.donVi = donVi;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
            this.fileAnh = fileAnh;
            this.ghiChu = ghiChu;
            this.soLuong = soLuong;
        }

        public VatLieu(int maVl, string tenVl, string donVi, decimal giaNhap, decimal giaBan, string fileAnh, string ghiChu, int soLuong) : this(maVl)
        {
            this.tenVl = tenVl;
            this.donVi = donVi;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
            this.fileAnh = fileAnh;
            this.ghiChu = ghiChu;
            this.soLuong = soLuong;
        }

        public VatLieu(int maVl)
        {
            this.maVl = maVl;
        }

        public int MaVl { get => maVl; set => maVl = value; }
        public string TenVl { get => tenVl; set => tenVl = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public decimal GiaNhap { get => giaNhap; set => giaNhap = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public string FileAnh { get => fileAnh; set => fileAnh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
