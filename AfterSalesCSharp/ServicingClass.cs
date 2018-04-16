using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using System.Data;

namespace AfterSalesCSharp
{
    
    class ServicingClass
    {
        Form1 frm1;
        newSrevicingFRM nsf;
        public ServicingClass(Form1 frm1val,newSrevicingFRM nsfval)
        {
            frm1 = frm1val;
            nsf = nsfval;
        }

        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource servicingbs = new BindingSource();
        BindingSource newservicingbs = new BindingSource();

        string columns = "[ID]"+
                          ",[CIN]"+
                          ",[SERVICING]"+
                          ",[SDATE] as DATE"+
                          ",[ASSIGNEDPERSONNEL] AS[ASSIGNED PERSONNEL]"+
                          ",[REPORT]"+
                          ",[DONE]"+
                          ",[NEEDEDMATERIALSREMARKS] AS[NEEDED MATERIALS / REMARKS]"+
                          ",[FORSCHED] AS[FOR RESCHED]"+
                          ",[FORCOSTING] AS[FOR COSTING]"+
                          ",[FORQUOTATIONORADDITIONAL] AS[FOR QUOTATION / ADDITIONAL]";
        public void loadservicingtb()
        {
            try
            {
                sql.sqlcon.Open();
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                frm1.servicingGridView.Columns.Clear();
                DataSet ds = new DataSet();
                ds.Clear();
                string query = "select " + columns + " from servicingtb";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "servicingtb");
                servicingbs.DataSource = ds;
                servicingbs.DataMember = "servicingtb";
                frm1.servicingGridView.DataSource = null;
                frm1.servicingGridView.DataSource = servicingbs;
                addbtnserviving();
                managecolumn();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void addbtnserviving()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn vs = new DataGridViewButtonColumn();

            btn.Name ="btn";
            btn.HeaderText ="";
            btn.Text = "...";
            btn.UseColumnTextForButtonValue = true;

            vs.Name = "vs";
            vs.HeaderText = "";
            vs.Text = "group";
            vs.UseColumnTextForButtonValue = true;

            frm1.servicingGridView.Columns.Insert(2, vs);
            frm1.servicingGridView.Columns.Insert(7, btn);

        }
        public void managecolumn()
        {

            frm1.servicingGridView.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["CIN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["SERVICING"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["ASSIGNED PERSONNEL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["DONE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["NEEDED MATERIALS / REMARKS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["FOR RESCHED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["FOR COSTING"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["FOR QUOTATION / ADDITIONAL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            frm1.servicingGridView.Columns["report"].Width=100;
            frm1.servicingGridView.Columns["btn"].Width = 30;
        }
        //newservivingFRM load records as per cin
        public void loadnewservicing(string cin)
        {
            try
            {
                sql.sqlcon.Open();
                nsf.servicingGRID.Columns.Clear();
 
                DataSet ds = new DataSet();
                ds.Clear();
                string query = "select " + columns + " from servicingtb where cin = '" + cin + "'";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "servicingtb");
                newservicingbs.DataSource = ds;
                newservicingbs.DataMember = "servicingtb";
                nsf.servicingGRID.DataSource = null;
                nsf.servicingGRID.DataSource = newservicingbs;
                //column buttons added to gridview
                addcolumnsbtn();
                //manage columns properties
                manageservicingGridViewcolumns();
                //status autosuggest list
                comboboxautosuggest();


                string findpname = "select project from callintb where cin = '" + cin + "'";
                sqlcmd = new SqlCommand(findpname, sql.sqlcon);
                SqlDataReader read = sqlcmd.ExecuteReader();
                while (read.Read())
                {
                    nsf.Text = read.GetString(0);
                }
                read.Close();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void addcolumnsbtn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn mbtn = new DataGridViewButtonColumn();

            btn.Name = "VIEW";
            btn.HeaderText = "";
            btn.Text = "...";
            btn.UseColumnTextForButtonValue = true;
            nsf.servicingGRID.Columns.Insert(6, btn);

            mbtn.Name = "mbtn";
            mbtn.HeaderText = "";
            mbtn.Text = "...";
            mbtn.UseColumnTextForButtonValue = true;
            nsf.servicingGRID.Columns.Insert(9, mbtn);
        }
        public void manageservicingGridViewcolumns()
        {
            nsf.servicingGRID.Columns["ID"].Visible = false;
            nsf.servicingGRID.Columns["CIN"].Visible = false;
            nsf.servicingGRID.Columns["SERVICING"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["ASSIGNED PERSONNEL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["REPORT"].Width = 100;
            nsf.servicingGRID.Columns["VIEW"].Width = 30;
            nsf.servicingGRID.Columns["DONE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["NEEDED MATERIALS / REMARKS"].Width = 200;
            nsf.servicingGRID.Columns["mbtn"].Width = 30;
            nsf.servicingGRID.Columns["FOR RESCHED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["FOR COSTING"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["FOR QUOTATION / ADDITIONAL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void comboboxautosuggest()
        {
            BindingSource bs = new BindingSource();
            DataSet myds = new DataSet();
            myds.Clear();
            string str = "select distinct done from servicingtb";
            sqlcmd = new SqlCommand(str, sql.sqlcon);
            da.SelectCommand = sqlcmd;
            da.Fill(myds, "servicingtb");
            bs.DataSource = myds;
            bs.DataMember = "servicingtb";
            nsf.doneTXT.DataSource = bs;
            nsf.doneTXT.DisplayMember = "done";
        }
        public void newservicing(string cin, string servicing, string SDATE,
                            string assignedpersonnel, string assigneesreport,
                            string status, string remarks,
                            string resched, string forcosting,
                            string forquotation)
        {
            try
            {
                sql.sqlcon.Open();
                string query = "Declare @id as integer =(select max(id)+1 from servicingtb) "+
                                  "insert into servicingtb "+
                                  "(ID "+
                                  ", CIN "+
                                  ", SERVICING "+
                                  ", SDATE "+
                                  ", ASSIGNEDPERSONNEL "+
                                  ", REPORT "+
                                  ", DONE "+
                                  ", NEEDEDMATERIALSREMARKS "+
                                  ", FORSCHED "+
                                  ", FORCOSTING "+
                                  ", FORQUOTATIONORADDITIONAL)VALUES "+
                                  "(@id, " +
                                  "'" + cin + "', " +
                                  "'" + servicing + "', " +
                                  "'" + SDATE + "', " +
                                  "'" + assignedpersonnel + "', " +
                                  "'" + assigneesreport + "', " +
                                  "'" + status + "', " +
                                  "'" + remarks + "', " +
                                  "'" + resched + "', " +
                                  "'" + forcosting + "', " +
                                  "'" + forquotation + "')";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
                sql.sqlcon.Close();
                loadnewservicing(cin);
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "Data Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void updateservicing(string id , string cin , string servicingdate ,
                          string assignedpersonnel , string assigneesreport ,
                          string status , string remarks ,
                          string resched , string forcosting ,
                          string forquotation )
        {
            try
            {
                sql.sqlcon.Open();
                string query = "update servicingtb set "+
                                  "SDATE = '" + servicingdate + "', "+
                                  "ASSIGNEDPERSONNEL = '" + assignedpersonnel + "', "+
                                  "REPORT = '" + assigneesreport + "', "+
                                  "DONE = '" + status + "', "+
                                  "NEEDEDMATERIALSREMARKS = '" + remarks + "', "+
                                  "FORSCHED = '" + resched + "', "+
                                  "FORCOSTING = '" + forcosting + "', "+
                                  "FORQUOTATIONORADDITIONAL = '" + forquotation + "' where id = '" + id + "'";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
                sql.sqlcon.Close();
                loadnewservicing(cin);
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "Data Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void deleteservicingsched(string id, string cin)
        {
            try
            {
                sql.sqlcon.Open();
                string query = "delete from servicingtb where id = '" + id + "'";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
                sql.sqlcon.Close();
                loadnewservicing(cin);
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
    }
}
