namespace WindowsFormsApp1
{
    partial class frmLTH
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.box = new System.Windows.Forms.ComboBox();
            this.txttimkiem = new System.Windows.Forms.Button();
            this.CT_THUCHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataLTH = new WindowsFormsApp1.DataLTH();
            this.CT_THUCHANHTableAdapter = new WindowsFormsApp1.DataLTHTableAdapters.CT_THUCHANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CT_THUCHANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLTH)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CT_THUCHANHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReporLTH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 431);
            this.reportViewer1.TabIndex = 0;
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(12, 21);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 1;
            this.box.SelectedIndexChanged += new System.EventHandler(this.Txttimkiem_SelectedIndexChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.AllowDrop = true;
            this.txttimkiem.Location = new System.Drawing.Point(157, 21);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(75, 23);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.Text = "Tìm Kiếm";
            this.txttimkiem.UseVisualStyleBackColor = true;
            this.txttimkiem.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CT_THUCHANHBindingSource
            // 
            this.CT_THUCHANHBindingSource.DataMember = "CT_THUCHANH";
            this.CT_THUCHANHBindingSource.DataSource = this.DataLTH;
            // 
            // DataLTH
            // 
            this.DataLTH.DataSetName = "DataLTH";
            this.DataLTH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CT_THUCHANHTableAdapter
            // 
            this.CT_THUCHANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmLTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.box);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmLTH";
            this.Text = "frmLTH";
            this.Load += new System.EventHandler(this.FrmLTH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CT_THUCHANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLTH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.Button txttimkiem;
        private System.Windows.Forms.BindingSource CT_THUCHANHBindingSource;
        private DataLTH DataLTH;
        private DataLTHTableAdapters.CT_THUCHANHTableAdapter CT_THUCHANHTableAdapter;
    }
}