using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using System.Data;
using System.Drawing;

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

        public string columns = "a.[ID]"+
                          ",a.[DONE]" +
                          ",b.[PROJECT]" +
                          ",a.[CIN]" +
                          ",a.[SERVICING]"+
                          ",a.[SDATE] as DATE"+
                          ",a.[ASSIGNEDPERSONNEL] AS[ASSIGNED PERSONNEL]"+
                          ",a.[REPORT]"+
                          ",a.[NEEDEDMATERIALSREMARKS] AS[NEEDED MATERIALS / REMARKS]"+
                          ",a.[FORSCHED] AS[FOR RESCHED]"+
                          ",a.[FORCOSTING] AS[FOR COSTING]"+
                          ",a.[FORQUOTATIONORADDITIONAL] AS[FOR QUOTATION / ADDITIONAL]";
        public void loadservicingtb(string condition)
        {
            try
            {
                sql.sqlcon.Open();            

                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                frm1.servicingGridView.Columns.Clear();
                DataSet ds = new DataSet();
                ds.Clear();
              
                string query = "select " + frm1.rowcounter(frm1.servicingrownumber.Text) + columns + " from servicingtb as a  inner join callintb as b on a.cin = b.cin "+condition+ " order by a.cin desc,a.servicing asc";
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
            vs.Text = "servicing";
            vs.UseColumnTextForButtonValue = true;

            frm1.servicingGridView.Columns.Insert(4, vs);
            frm1.servicingGridView.Columns.Insert(9, btn);

        }
        public void managecolumn()
        {
            for (int i = 0; i <= frm1.servicingGridView.RowCount - 1; i++)
            {
                string a = frm1.servicingGridView.Rows[i].Cells["DONE"].Value.ToString();
                if (a != "")
                {
                    frm1.servicingGridView.Rows[i].Cells["DONE"].Style.ForeColor = Color.White;
                    frm1.servicingGridView.Rows[i].Cells["DONE"].Style.BackColor = Color.Blue;
                    frm1.servicingGridView.Rows[i].Cells["DONE"].Style.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                }
            }

            frm1.servicingGridView.Columns["PROJECT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.servicingGridView.Columns["ID"].Visible = false;
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
                string query = "select " + columns.Replace(",b.[PROJECT]","") + " from servicingtb as a where a.cin = '" + cin + "'";
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
            DataGridViewButtonColumn sbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn cbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn adlbtn = new DataGridViewButtonColumn();

            btn.Name = "VIEW";
            btn.HeaderText = "";
            btn.Text = "...";
            btn.UseColumnTextForButtonValue = true;
            nsf.servicingGRID.Columns.Insert(7, btn);

            mbtn.Name = "mbtn";
            mbtn.HeaderText = "";
            mbtn.Text = "...";
            mbtn.UseColumnTextForButtonValue = true;
            nsf.servicingGRID.Columns.Insert(9, mbtn);

            sbtn.Name = "sbtn";
            sbtn.HeaderText = "";
            sbtn.Text = "...";
            sbtn.UseColumnTextForButtonValue = true;
            nsf.servicingGRID.Columns.Insert(11, sbtn);

            cbtn.Name = "cbtn";
            cbtn.HeaderText = "";
            cbtn.Text = "...";
            cbtn.UseColumnTextForButtonValue = true;
            nsf.servicingGRID.Columns.Insert(13, cbtn);

            adlbtn.Name = "adlbtn";
            adlbtn.HeaderText = "";
            adlbtn.Text = "...";
            adlbtn.UseColumnTextForButtonValue = true;
            nsf.servicingGRID.Columns.Insert(15, adlbtn);
        }
        public void manageservicingGridViewcolumns()
        {

            for (int i = 0; i <= nsf.servicingGRID.RowCount - 1; i++)
            {
                string a = nsf.servicingGRID.Rows[i].Cells["DONE"].Value.ToString();
                if (a != "")
                {
                    nsf.servicingGRID.Rows[i].Cells["DONE"].Style.ForeColor = Color.White;
                    nsf.servicingGRID.Rows[i].Cells["DONE"].Style.BackColor = Color.Blue;
                    nsf.servicingGRID.Rows[i].Cells["DONE"].Style.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                }
            }

            nsf.servicingGRID.Columns["ID"].Visible = false;
            nsf.servicingGRID.Columns["CIN"].Visible = false;
            nsf.servicingGRID.Columns["SERVICING"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["ASSIGNED PERSONNEL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["REPORT"].Width = 200;
            nsf.servicingGRID.Columns["VIEW"].Width = 30;
            nsf.servicingGRID.Columns["DONE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nsf.servicingGRID.Columns["NEEDED MATERIALS / REMARKS"].Width = 200;
            nsf.servicingGRID.Columns["mbtn"].Width = 30;
            nsf.servicingGRID.Columns["FOR RESCHED"].Width = 200;
            nsf.servicingGRID.Columns["sbtn"].Width = 30;
            nsf.servicingGRID.Columns["FOR COSTING"].Width = 200;
            nsf.servicingGRID.Columns["cbtn"].Width = 30;
            nsf.servicingGRID.Columns["FOR QUOTATION / ADDITIONAL"].Width = 200;
            nsf.servicingGRID.Columns["adlbtn"].Width = 30;
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
                updatestatus(cin);
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
                updatestatus(cin);
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

        public void updatestatus(string cin)
        {
            try
            {
                string x = "declare @maxid as integer = (select max(id) from servicingtb where cin = '" + cin + "')"+
                            "select case when FORCOSTING='' and not FORSCHED ='' then '1' else '0' end as forresched, "+
                            "case when FORSCHED = '' and not FORCOSTING = '' then '1' else '0' end as forcosting, "+
                            "case when not FORSCHED = '' and not FORCOSTING = '' then '1' else '0' end as forcostingresched "+
                            "from SERVICINGTB where id=@maxid";
                sqlcmd = new SqlCommand(x, sql.sqlcon);
                string s="",d="",f="";
                string query="";
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                while (rdr.Read())
                {
                    s = rdr.GetString(0);
                    d = rdr.GetString(1);
                    f = rdr.GetString(2);
                }
                rdr.Close();
                if (s == "1")
                {
                    query = "update callintb set status = 'FOR RE SCHEDULE' where cin = '" + cin + "'";
                }
                else if (d=="1")
                {
                    query = "update callintb set status = 'FOR COSTING' where cin = '" + cin + "'";
                }
                else if (f=="1")
                {
                    query = "update callintb set status = 'FOR COSTING AND RE SCHEDULE' where cin = '" + cin + "'";
                }
                else
                {
                    query = "update callintb set status = '' where cin = '" + cin + "'";
                }
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();

                string getstatus = "declare @maxid as integer = (select max(id) from servicingtb where cin = '" + cin + "')" +
                                   "select done from servicingtb where not done = '' and cin = '" + cin + "' and id = @maxid";
                sqlcmd = new SqlCommand(getstatus, sql.sqlcon);
                SqlDataReader read = sqlcmd.ExecuteReader();
                if (read.HasRows == true)
                {
                    read.Close();
                    string str = "update callintb set status = 'Done' where cin = '" + cin + "'";
                    sqlcmd = new SqlCommand(str, sql.sqlcon);
                    sqlcmd.ExecuteNonQuery();
                }
                read.Close();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newSrevicingFRM.ActiveForm, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                updatestatus(cin);
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
