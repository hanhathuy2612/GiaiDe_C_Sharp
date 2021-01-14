using Microsoft.Reporting.WinForms;
using project2.DAO;
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
    public partial class fXuatFileExcel : Form
    {
        public fXuatFileExcel()
        {
            InitializeComponent();
        }

        private void fXuatFileExcel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VATLIEUDATADataSet.VatLieu' table. You can move, or remove it, as needed.
            this.VatLieuTableAdapter.Fill(this.VATLIEUDATADataSet.VatLieu);
            DataTable data = VatLieuDAO.Instance.getAllVatLieu();
            ReportDataSource rds = new ReportDataSource("DataSet1", data);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
