using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MetroFramework;

namespace AfterSalesCSharp
{
    class quClass
    {
        Form1 frm1;
        newQUform qufrm;
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public quClass(Form1 frm1val,newQUform qu)
        {
            frm1 = frm1val;
            qufrm = qu;
        }
        public void loadquotaiontb()
        {
            try
            {
                sql.sqlcon.Open();
                frm1.quGridView.Columns.Clear();
                DataSet ds = new DataSet();
                ds.Clear();
                BindingSource bs = new BindingSource();
                string str = "select * from quotationtb";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "quotationtb");
                bs.DataSource = ds;
                bs.DataMember = "quotationtb";
                frm1.quGridView.DataSource = bs;
                addbtn();
            }
            catch(SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm,"" + e + "","Sql Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void addbtn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btn";
            btn.HeaderText = "";
            btn.Text = "quotation";
            btn.UseColumnTextForButtonValue = true;
            frm1.quGridView.Columns.Insert(1, btn);
        }
        public void addase(string ASE)
        {
            try
            {
                sql.sqlcon.Open();
                string checkdata = "select * from quotationtb where ASENO = '" + ASE + "'";
                sqlcmd = new SqlCommand(checkdata,sql.sqlcon);
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    string str = "insert into quotationtb (ASENO)values('" + ASE + "')";
                    sqlcmd = new SqlCommand(str, sql.sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    MetroMessageBox.Show(newQUform.ActiveForm, "Data Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    qufrm.panel1.Enabled = true;
                    qufrm.aseno.Enabled = false;
                }
            }
            catch(SqlException e)
            {
                MetroMessageBox.Show(newQUform.ActiveForm, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
    }
}
