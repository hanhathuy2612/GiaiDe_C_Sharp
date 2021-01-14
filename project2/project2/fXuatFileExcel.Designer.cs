
namespace project2
{
    partial class fXuatFileExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VATLIEUDATADataSet = new project2.VATLIEUDATADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VatLieuTableAdapter = new project2.VATLIEUDATADataSetTableAdapters.VatLieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VatLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATLIEUDATADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VatLieuBindingSource
            // 
            this.VatLieuBindingSource.DataMember = "VatLieu";
            this.VatLieuBindingSource.DataSource = this.VATLIEUDATADataSet;
            // 
            // VATLIEUDATADataSet
            // 
            this.VATLIEUDATADataSet.DataSetName = "VATLIEUDATADataSet";
            this.VATLIEUDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VatLieuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1169, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VatLieuTableAdapter
            // 
            this.VatLieuTableAdapter.ClearBeforeFill = true;
            // 
            // fXuatFileExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fXuatFileExcel";
            this.Text = "fXuatFileExcel";
            this.Load += new System.EventHandler(this.fXuatFileExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VatLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATLIEUDATADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VatLieuBindingSource;
        private VATLIEUDATADataSet VATLIEUDATADataSet;
        private VATLIEUDATADataSetTableAdapters.VatLieuTableAdapter VatLieuTableAdapter;
    }
}