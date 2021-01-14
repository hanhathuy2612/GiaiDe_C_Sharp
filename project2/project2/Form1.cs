using project2.DAO;
using project2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDataGrid();
        }
        bool isNumBer(string chuoi)
        {
            foreach(Char c in chuoi)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        bool kiemTraFeild()
        {
            
            if (txbTenVatLieu.Text == "")
            {
                MessageBox.Show("Ten vat lieu trong");
                txbTenVatLieu.Focus();
                return false;
            }
            if (txbDonViTinh.Text == "")
            {
                MessageBox.Show("Don vi tinh trong");
                txbDonViTinh.Focus();
                return false;
            }
            if (txbGiaNhap.Text == "")
            {
                MessageBox.Show("Gia nhap trong");
                txbGiaNhap.Focus();
                return false;
            }
            if (txbGiaBan.Text == "")
            {
                MessageBox.Show("Gia ban trong");
                txbGiaBan.Focus();
                return false;
            }
            if (txbGhiChu.Text == "")
            {
                MessageBox.Show("Ghi chu trong");
                txbGhiChu.Focus();
                return false;
            }
            if (txbSoLuong.Text == "")
            {
                MessageBox.Show("So luong trong");
                txbSoLuong.Focus();
                return false;
            }
            if (!isNumBer(txbGiaNhap.Text))
            {
                MessageBox.Show("Giá nhập phải là số");
                txbGiaNhap.Focus();
                return false;
            }
            if (!isNumBer(txbGiaBan.Text))
            {
                MessageBox.Show("Giá Bán phải là số");
                txbGiaBan.Focus();
                return false;
            }
            if (!isNumBer(txbSoLuong.Text))
            {
                MessageBox.Show("Số lượng phải là số");
                txbSoLuong.Focus();
                return false;
            }
            return true;
        }
        void loadDataGrid()
        {
            dgvVatLieu.DataSource = VatLieuDAO.Instance.getAllVatLieu();
        }

        private void dgvVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txbMaVatLieu.Text = dgvVatLieu.Rows[index].Cells["MaVL"].Value.ToString();
                txbTenVatLieu.Text = dgvVatLieu.Rows[index].Cells["TenVL"].Value.ToString();
                txbDonViTinh.Text = dgvVatLieu.Rows[index].Cells["DonVi"].Value.ToString();
                txbGiaNhap.Text = dgvVatLieu.Rows[index].Cells["GiaNhap"].Value.ToString();
                txbGiaBan.Text = dgvVatLieu.Rows[index].Cells["GiaBan"].Value.ToString();
                txbSoLuong.Text = dgvVatLieu.Rows[index].Cells["SoLuong"].Value.ToString();
                txbGhiChu.Text = dgvVatLieu.Rows[index].Cells["GhiChu"].Value.ToString();
                try
                {
                    if (dgvVatLieu.Rows[index].Cells["FileAnh"].Value.ToString() == "")
                    {
                        ptbxFileAnh.Image = null;
                    }
                    else
                    {

                        ptbxFileAnh.Image = new Bitmap(dgvVatLieu.Rows[index].Cells["FileAnh"].Value.ToString());
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        OpenFileDialog open = new OpenFileDialog();
        private void btnFileAnh_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            if (DialogResult.OK == open.ShowDialog())
            {
                open.Filter = "insert image(*)|*";
                ptbxFileAnh.Image = new Bitmap(open.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraFeild())
            {
                string tenVl = txbTenVatLieu.Text;
                string donVi = txbDonViTinh.Text;
                decimal giaNhap = decimal.Parse(txbGiaNhap.Text);
                decimal giaBan = decimal.Parse(txbGiaBan.Text);
                string ghiChu = txbGhiChu.Text;
                int soLuong = Convert.ToInt32(txbSoLuong.Text);
                string fileAnh = "";
                if (open.FileName == null)
                {
                    fileAnh = "";
                }
                else
                {
                    fileAnh = open.FileName;
                }


                VatLieu vl = new VatLieu(tenVl, donVi, giaNhap, giaBan, fileAnh, ghiChu, soLuong);

                if (VatLieuDAO.Instance.themVatLieu(vl) != 0)
                {
                    loadDataGrid();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            VatLieu vl = new VatLieu(Convert.ToInt32(txbMaVatLieu.Text));
            if (VatLieuDAO.Instance.xoaVatLieu(vl) != 0)
            {
                loadDataGrid();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fXuatFileExcel f = new fXuatFileExcel();
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kiemTraFeild())
            {
                int maVl = Convert.ToInt32(txbMaVatLieu.Text);
                string tenVl = txbTenVatLieu.Text;
                string donVi = txbDonViTinh.Text;
                decimal giaNhap = decimal.Parse(txbGiaNhap.Text);
                decimal giaBan = decimal.Parse(txbGiaBan.Text);
                string ghiChu = txbGhiChu.Text;
                int soLuong = Convert.ToInt32(txbSoLuong.Text);
                string fileAnh = open.FileName;
               /* MessageBox.Show(open.FileName);
                if (open.FileName == null || open.FileName == "")
                {
                    fileAnh = "";
                }
                else
                {
                    fileAnh = open.FileName;
                }*/

                VatLieu vl = new VatLieu(maVl, tenVl, donVi, giaNhap, giaBan, fileAnh, ghiChu, soLuong);

                if (VatLieuDAO.Instance.suaVatLieu(vl) != 0)
                {
                    loadDataGrid();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
    }
}
