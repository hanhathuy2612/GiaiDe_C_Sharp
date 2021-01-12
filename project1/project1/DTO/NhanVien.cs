using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DTO
{
    public class NhanVien
    {
        private int maNv;
        private string hoTen;
        private string phongBan;
        private string chucVu;
        private double luong;

        public int MaNv { get => maNv; set => maNv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double Luong { get => luong; set => luong = value; }

        public NhanVien() { }

        public NhanVien(string hoTen, string phongBan, string chucVu, double luong)
        {
            this.hoTen = hoTen;
            this.phongBan = phongBan;
            this.chucVu = chucVu;
            this.Luong = luong;
        }

        public NhanVien(int maNv)
        {
            this.maNv = maNv;
        }
    }
}
