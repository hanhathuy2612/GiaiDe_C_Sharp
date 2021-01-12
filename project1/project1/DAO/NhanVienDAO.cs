using project1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance 
        { 
            get { if (instance == null) instance = new NhanVienDAO(); return instance; } 
            private set => instance = value; 
        }
        public DataTable getAllNhanVien()
        {
            string query = "Select * from NHANVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int addNhanVien(NhanVien nv)
        {
            string query = "insert into NHANVIEN values( @ten , @phongBan , @chucVu , @luong )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { nv.HoTen, nv.PhongBan, nv.ChucVu, nv.Luong });
        }
        public int tongNhanVien()
        {
            string query = "exec TongNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return Convert.ToInt32(data.Rows[0].ItemArray[0].ToString());
        }
        public int deleteNhanVien(NhanVien nv)
        {
            string query = "delete NHANVIEN where MaNv = @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { nv.MaNv });
        }
        public DataTable sapXepHoTenTangDan()
        {
            string query = "Exec SapXep_HoTenTangDan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable sapXepLuongTangDan()
        {
            string query = "Exec SapXep_LuongTangDan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable sapXepLuongGiamDan()
        {
            string query = "Exec SapXep_LuongGiamDan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
