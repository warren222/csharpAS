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
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public quClass(Form1 frm1val)
        {
            frm1 = frm1val;
        }
        public void loadquotaiontb()
        {
            try
            {
                sql.sqlcon.Open();
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

    }
}
