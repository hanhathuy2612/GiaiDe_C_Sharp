using project2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.DAO
{
    class VatLieuDAO
    {
        // Singlethon
        private static VatLieuDAO instance;

        internal static VatLieuDAO Instance
        {
            get
            {
                if (instance == null) instance = new VatLieuDAO();
                return instance;
            }
            private set => instance = value;
        }

        // Chuc nang

        public DataTable getAllVatLieu()
        {
            string query = "select * from VatLieu";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int themVatLieu(VatLieu vl)
        {
            string query = "insert into VatLieu values( @tenvl , @donvi , @gianhap , @giaban , @fileanh , @ghichu , @soluong )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { vl.TenVl, vl.DonVi, vl.GiaNhap, vl.GiaBan, vl.FileAnh, vl.GhiChu, vl.SoLuong });
        }
        public int suaVatLieu(VatLieu vl)
        {
            string query = "update VatLieu set Tenvl = @tenvl , DonVi = @donvi , GiaNhap = @gianhap , GiaBan = @giaban , FileAnh = @fileAnh , GhiChu = @GhiChu , soluong = @soluong where MaVl = @mavl";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { vl.TenVl, vl.DonVi, vl.GiaNhap, vl.GiaBan, vl.FileAnh, vl.GhiChu, vl.SoLuong , vl.MaVl});
        }

        public int xoaVatLieu(VatLieu vl)
        {
            string query = "delete VatLieu where MaVl = @mavl";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { vl.MaVl});
        }
    }
}
