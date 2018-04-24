using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using MetroFramework;
using MetroFramework.Forms;

namespace AfterSalesCSharp
{
    public partial class quREPORTfrm : MetroForm
    {
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public quREPORTfrm()
        {
            InitializeComponent();
        }

        private void quREPORTfrm_Load(object sender, EventArgs e)
        {
            loadreport(Form1.aseno);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }
        public void loadreport(string ase)
        {
            try
            {
                sql.sqlcon.Open();
                string qutb = "select * from quotationtb where aseno = '" + ase + "'";
                string itemtb = "select * from itemstb where aseno = '" + ase + "'";
                asDS ds = new asDS();
                ds.Clear();
                sqlcmd = new SqlCommand(qutb, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds.QUOTATIONTB);
                QUOTATIONTBBindingSource.DataSource = ds.QUOTATIONTB.DefaultView;

                asDS ds1 = new asDS();
                ds1.Clear();
                sqlcmd = new SqlCommand(itemtb, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds1.ITEMSTB);
                ITEMSTBBindingSource.DataSource = ds1.ITEMSTB.DefaultView;
            }
            catch(SqlException e)
            {
                MetroMessageBox.Show(this, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
       
    }
}
