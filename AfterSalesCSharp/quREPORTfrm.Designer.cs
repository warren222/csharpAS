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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.asDS = new AfterSalesCSharp.asDS();
            this.QUOTATIONTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ITEMSTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.asDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUOTATIONTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMSTBBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(596, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // asDS
            // 
            this.asDS.DataSetName = "asDS";
            this.asDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QUOTATIONTBBindingSource
            // 
            this.QUOTATIONTBBindingSource.DataMember = "QUOTATIONTB";
            this.QUOTATIONTBBindingSource.DataSource = this.asDS;
            // 
            // ITEMSTBBindingSource
            // 
            this.ITEMSTBBindingSource.DataMember = "ITEMSTB";
            this.ITEMSTBBindingSource.DataSource = this.asDS;
            // 
            // quREPORTfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 479);
            this.Controls.Add(this.reportViewer1);
            this.Name = "quREPORTfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quREPORTfrm";
            this.Load += new System.EventHandler(this.quREPORTfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUOTATIONTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMSTBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QUOTATIONTBBindingSource;
        private asDS asDS;
        private System.Windows.Forms.BindingSource ITEMSTBBindingSource;
    }
}