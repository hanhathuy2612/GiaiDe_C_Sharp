using project1.DAO;
using project1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
       /* private int maNv;*/
        public Form1()
        {
            InitializeComponent();
            loadDataGrid();
            setDeFaultButton();
        }
        void loadDataGrid()
        {
            dgvNhanVien.DataSource = NhanVienDAO.Instance.sapXepHoTenTangDan();
            lbTongNhanVien.Text = NhanVienDAO.Instance.tongNhanVien().ToString();
            cbxSapXep.Text = "Học tên tăng dần";
        }
        void setDeFaultButton()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
        }
        
        bool checkField()
        {
            if(txbTenNhanVien.Text == "")
            {
                txbTenNhanVien.Focus();
                return false;
            }
            if (cbxPhongBan.Text == "")
            {
                return false;
            }
            if (cbxChucVu.Text == "")
            {
                return false;
            }
            return true;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            /*maNv = e.RowIndex;*/
            if(index >= 0)
            {
                txbTenNhanVien.Text = dgvNhanVien.Rows[index].Cells["HoTen"].Value.ToString();
                cbxChucVu.Text = dgvNhanVien.Rows[index].Cells["ChucVu"].Value.ToString();
                cbxPhongBan.Text = dgvNhanVien.Rows[index].Cells["PhongBan"].Value.ToString();
                btnDelete.Enabled = true;
            }
        }

        private void cbxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            string sapXep = com.Text;
            if(sapXep == "Họ tên tăng dần")
            {
                /*dgvNhanVien.DataSource = NhanVienDAO.Instance.sapXepHoTenTangDan();*/
                dgvNhanVien.Sort(this.dgvNhanVien.Columns["Hoten"], ListSortDirection.Ascending);
            }
            if (sapXep == "Lương tăng dần")
            {
                dgvNhanVien.Sort(this.dgvNhanVien.Columns["Luong"], ListSortDirection.Ascending);
            }
            if (sapXep == "Lương giảm dần")
            {
                dgvNhanVien.Sort(this.dgvNhanVien.Columns["Luong"], ListSortDirection.Descending);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkField())
            {
                string ten = txbTenNhanVien.Text;
                string phongBan = cbxPhongBan.Text;
                string chucVu = cbxChucVu.Text;
                double luong = 0;
                if (chucVu == "Nhân viên")
                {
                    luong = 4600000;
                }
                if (chucVu == "Chuyên viên")
                {
                    luong = 4600000 * 1.3;
                }
                if (chucVu == "Phó phòng")
                {
                    luong = 4600000 * 1.6;
                }
                if (chucVu == "Trưởng phòng")
                {
                    luong = 4600000 * 2;
                }

                NhanVien nv = new NhanVien(ten, phongBan, chucVu, luong);

                if (NhanVienDAO.Instance.addNhanVien(nv) != 0)
                {
                    loadDataGrid();
                    setDeFaultButton();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maNv;
            foreach(DataGridViewRow row in dgvNhanVien.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Selected == true)
                    {
                        maNv = Convert.ToInt32(dgvNhanVien.Rows[cell.RowIndex].Cells["MaNv"].Value.ToString());
                        NhanVien nv = new NhanVien(maNv);
                        if (NhanVienDAO.Instance.deleteNhanVien(nv) != 0)
                        {
                            loadDataGrid();
                            setDeFaultButton();
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                }
            }
            
        }
    }
}
