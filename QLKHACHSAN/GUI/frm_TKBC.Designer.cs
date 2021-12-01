namespace QLKHACHSAN.GUI
{
    partial class frm_TKBC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tKDTPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLKHACHSAN.DataSet1();
            this.tKDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_TKDV = new QLKHACHSAN.DataSet_TKDV();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_chonTK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tKDT_PhongTableAdapter = new QLKHACHSAN.DataSet1TableAdapters.TKDT_PhongTableAdapter();
            this.tKDVTableAdapter = new QLKHACHSAN.DataSet_TKDVTableAdapters.TKDVTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tKDTPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tKDTPhongBindingSource
            // 
            this.tKDTPhongBindingSource.DataMember = "TKDT_Phong";
            this.tKDTPhongBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKDVBindingSource
            // 
            this.tKDVBindingSource.DataMember = "TKDV";
            this.tKDVBindingSource.DataSource = this.dataSet_TKDV;
            // 
            // dataSet_TKDV
            // 
            this.dataSet_TKDV.DataSetName = "DataSet_TKDV";
            this.dataSet_TKDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(889, 11);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Tổng_Doanh_Thu_Phòng";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(80, 46);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cb_chonTK
            // 
            this.cb_chonTK.FormattingEnabled = true;
            this.cb_chonTK.Location = new System.Drawing.Point(119, 28);
            this.cb_chonTK.Margin = new System.Windows.Forms.Padding(4);
            this.cb_chonTK.Name = "cb_chonTK";
            this.cb_chonTK.Size = new System.Drawing.Size(194, 24);
            this.cb_chonTK.TabIndex = 1;
            this.cb_chonTK.TextChanged += new System.EventHandler(this.cb_chonTK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn thống kê";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource13.Name = "DataSet1";
            reportDataSource13.Value = this.tKDTPhongBindingSource;
            reportDataSource14.Name = "DataSet_TKDV";
            reportDataSource14.Value = this.tKDVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKHACHSAN.GUI.Report_TKDT_Phong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(969, 359);
            this.reportViewer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_chonTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 88);
            this.panel1.TabIndex = 4;
            // 
            // tKDT_PhongTableAdapter
            // 
            this.tKDT_PhongTableAdapter.ClearBeforeFill = true;
            // 
            // tKDVTableAdapter
            // 
            this.tKDVTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource15.Name = "DataSet_TKDV";
            reportDataSource15.Value = this.tKDVBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QLKHACHSAN.GUI.Report_TKDT_DV.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 85);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(969, 401);
            this.reportViewer2.TabIndex = 5;
            // 
            // frm_TKBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 444);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TKBC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê báo cáo";
            this.Load += new System.EventHandler(this.frm_TKBC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tKDTPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cb_chonTK;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tKDTPhongBindingSource;
        private DataSet1TableAdapters.TKDT_PhongTableAdapter tKDT_PhongTableAdapter;
        private DataSet_TKDV dataSet_TKDV;
        private System.Windows.Forms.BindingSource tKDVBindingSource;
        private DataSet_TKDVTableAdapters.TKDVTableAdapter tKDVTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}