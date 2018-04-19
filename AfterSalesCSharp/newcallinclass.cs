using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MetroFramework;
using System.Windows.Forms;
using System.Data;

namespace AfterSalesCSharp
{
    class newcallinclass
    {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand sqlcmd = new SqlCommand();

        Form1 frm1;
        public newcallinclass(Form1 frm1val)
        {
            frm1 = frm1val;
        }
        public void loadsearchresult(string query)
        {
            try
            {
                sql.sqlcon.Open();
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                ds.Clear();
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "callintb");
                bs.DataSource = ds;
                bs.DataMember = "callintb";
                frm1.searchResultGridview.DataSource = null;
                frm1.searchResultGridview.DataSource = bs;
                //add column button
                manageCALLINGRIDcolumns();
                frm1.searchresultLBL.Text = frm1.searchResultGridview.RowCount.ToString() + " Search result...";
                frm1.CLEARSEARCHRESULTbtn.Visible = true;
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void manageCALLINGRIDcolumns()
        {
            frm1.searchResultGridview.Columns["AUTONUM"].Visible = false;
            frm1.searchResultGridview.Columns["AUTONUM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["STATUS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["CIN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["PROJECT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["ADDRESS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["RECIPIENT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["CONTACT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["EMAIL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["FOIL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["Screen"].Width = 100;
            frm1.searchResultGridview.Columns["Windows"].Width = 100;
            frm1.searchResultGridview.Columns["DOORS"].Width = 100;
            frm1.searchResultGridview.Columns["OTHER"].Width = 100;
            frm1.searchResultGridview.Columns["DATE VISITED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.searchResultGridview.Columns["ASSIGNED PERSONNEL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //ADD NEW RECORD INTO CALLIN TABLE
        public void addcallin(string calldate , string project ,
                        string address , string recipient ,
                        string contact , string email ,
                        string foil , string screen ,
                        string windows , string doors ,
                        string others , string datevisited ,
                        string assignedpersonnel )
        {
            try
            {
                sql.sqlcon.Open();
                string query = "Declare @autonum as integer = (select max(autonum)+1 from callintb)" +
                                "insert into callintb" +
                                "(AUTONUM," +
                                "CDATE," +
                                "PROJECT," +
                                "ADDRESS," +
                                "RECIPIENT," +
                                "CONTACT," +
                                "EMAIL," +
                                "FOIL," +
                                "SCREEN," +
                                "WINDOWS," +
                                "DOORS," +
                                "OTHER," +
                                "DATEVISITED," +
                                "ASSIGNEDPERSONNEL)" +
                                "values" +
                                "(@autonum, " +
                                "'" + calldate + "' , " +
                                "'" + project + "' , " +
                                "'" + address + "' , " +
                                "'" + recipient + "' , " +
                                "'" + contact + "' , " +
                                "'" + email + "' , " +
                                "'" + foil + "' , " +
                                "'" + screen + "' , " +
                                "'" + windows + "' , " +
                                "'" + doors + "' , " +
                                "'" + others + "' , " +
                                "'" + datevisited + "' , " +
                                "'" + assignedpersonnel + "')";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
                MetroMessageBox.Show(Form1.ActiveForm, "Data Added Successfully", "SQL Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql.sqlcon.Close();
                CallinTableClass b = new CallinTableClass(frm1);
                b.loadcallintb();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void updatecallin(string tempcin , string calldate , string project ,
                       string address , string recipient ,
                       string contact , string email ,
                       string foil , string screen ,
                       string windows , string doors ,
                       string others , string datevisited ,
                       string assignedpersonnel )
        {
            try
            {
                sql.sqlcon.Open();
                string query = "update callintb set "+
                                "CDATE = '" + calldate + "', "+
                                "PROJECT = '" + project + "', "+
                                "ADDRESS = '" + address + "', "+
                                "RECIPIENT = '" + recipient + "', "+
                                "CONTACT = '" + contact + "', "+
                                "EMAIL = '" + email + "', "+
                                "FOIL = '" + foil + "', "+
                                "SCREEN = '" + screen + "', "+
                                "WINDOWS = '" + windows + "', "+
                                "DOORS = '" + doors + "', "+
                                "OTHER = '" + others + "', "+
                                "DATEVISITED = '" + datevisited + "', "+
                                "ASSIGNEDPERSONNEL = '" + assignedpersonnel + "' "+
                                "where cin = '" + tempcin + "'";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
                MetroMessageBox.Show(Form1.ActiveForm, "Data Updated Successfully", "SQL Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql.sqlcon.Close();
                CallinTableClass b = new CallinTableClass(frm1);
                b.loadcallintb();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void deletecallin(string cin)
        {
            try
            {
                sql.sqlcon.Open();
                string str = "delete from callintb where cin = '" + cin + "'";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
                sql.sqlcon.Close();
                CallinTableClass b = new CallinTableClass(frm1);
                b.loadcallintb();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
    }
}
