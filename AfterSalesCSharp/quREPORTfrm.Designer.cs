﻿namespace AfterSalesCSharp
{
    partial class quREPORTfrm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.QUOTATIONTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asDS = new AfterSalesCSharp.asDS();
            this.ITEMSTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.QUOTATIONTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMSTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // QUOTATIONTBBindingSource
            // 
            this.QUOTATIONTBBindingSource.DataMember = "QUOTATIONTB";
            this.QUOTATIONTBBindingSource.DataSource = this.asDS;
            // 
            // asDS
            // 
            this.asDS.DataSetName = "asDS";
            this.asDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ITEMSTBBindingSource
            // 
            this.ITEMSTBBindingSource.DataMember = "ITEMSTB";
            this.ITEMSTBBindingSource.DataSource = this.asDS;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.QUOTATIONTBBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ITEMSTBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AfterSalesCSharp.quREPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(556, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // quREPORTfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 479);
            this.Controls.Add(this.reportViewer1);
            this.Name = "quREPORTfrm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.quREPORTfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUOTATIONTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMSTBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource QUOTATIONTBBindingSource;
        private asDS asDS;
        private System.Windows.Forms.BindingSource ITEMSTBBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}