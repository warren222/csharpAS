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
    class CallinTableClass
    {  

        Form1 frm1;
        public CallinTableClass(Form1 frm1val)
        {
            frm1 = frm1val;
        }

        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource callintbbs = new BindingSource();

        public string callintbcolumns = "[AUTONUM]"+
                                          ",[STATUS]"+
                                          ",[CDATE] AS[DATE]"+
                                          ",[CIN]"+
                                          ",[PROJECT]"+
                                          ",[ADDRESS]"+
                                          ",[RECIPIENT]"+
                                          ",[CONTACT]"+
                                          ",[EMAIL]"+
                                          ",[FOIL]"+
                                          ",[SCREEN]"+
                                          ",[WINDOWS]"+
                                          ",[DOORS]"+
                                          ",[OTHER]"+
                                          ",[DATEVISITED] AS [DATE VISITED]"+
                                          ",[ASSIGNEDPERSONNEL] as [ASSIGNED PERSONNEL]";
        //STORE DATA INTO CALLIN TABLE
        public void loadcallintb()
        {
            try
            {
                sql.sqlcon.Open();
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                frm1.callinGRID.Columns.Clear();
       
                DataSet ds = new DataSet();
                ds.Clear();
                string query = "Select " + frm1.rowcounter(frm1.rownumber1.Text) + " " + callintbcolumns + " from callintb order by autonum desc";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "callintb");
                callintbbs.DataSource = ds;
                callintbbs.DataMember = "callintb";
                frm1.callinGRID.DataSource = null;
                frm1.callinGRID.DataSource = callintbbs;
                addcolumnbutton();
                manageCALLINGRIDcolumns();

                callloggrid();
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

        public void findcallin(string query)
        {
            try
            {
                sql.sqlcon.Open();
                DataSet ds = new DataSet();
                ds.Clear();
                BindingSource bs = new BindingSource();
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "callintb");
                callintbbs.DataSource = ds;
                callintbbs.DataMember = "callintb";
                frm1.callinGRID.Columns.Clear();
                frm1.callinGRID.DataSource = null;
                frm1.callinGRID.DataSource = callintbbs;
                addcolumnbutton();
                manageCALLINGRIDcolumns();
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
        public void addcolumnbutton()
        {
            DataGridViewButtonColumn serbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn scrbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn wdwbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dorbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn otrbtn = new DataGridViewButtonColumn();

            scrbtn.Name = "scrbtn";
            scrbtn.HeaderText = "";
            scrbtn.Text = "...";
            scrbtn.UseColumnTextForButtonValue = true;
            frm1.callinGRID.Columns.Insert(11, scrbtn);

            wdwbtn.Name = "wdwbtn";
            wdwbtn.HeaderText = "";
            wdwbtn.Text = "...";
            wdwbtn.UseColumnTextForButtonValue = true;
            frm1.callinGRID.Columns.Insert(13, wdwbtn);

            dorbtn.Name = "dorbtn";
            dorbtn.HeaderText = "";
            dorbtn.Text = "...";
            dorbtn.UseColumnTextForButtonValue = true;
            frm1.callinGRID.Columns.Insert(15, dorbtn);

            otrbtn.Name = "othbtn";
            otrbtn.HeaderText = "";
            otrbtn.Text = "...";
            otrbtn.UseColumnTextForButtonValue = true;
            frm1.callinGRID.Columns.Insert(17, otrbtn);

            serbtn.Name = "serbtn";
            serbtn.HeaderText = "";
            serbtn.Text = "View Servicing Schedule";
            serbtn.UseColumnTextForButtonValue = true;
            frm1.callinGRID.Columns.Insert(20, serbtn);
        }
        public void manageCALLINGRIDcolumns()
        {
            for(int i = 0; i <= frm1.callinGRID.RowCount-1; i++)
            {
                string a = frm1.callinGRID.Rows[i].Cells["STATUS"].Value.ToString();
                if (a == "Done")
                {
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.BackColor = System.Drawing.Color.Blue;
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.ForeColor = Color.White;
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.SelectionForeColor = Color.White;
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.SelectionBackColor = System.Drawing.Color.Blue;
                }
                else if (((a == "FOR COSTING")||(a=="FOR RE SCHEDULE")||(a=="FOR COSTING AND RE SCHEDULE")))
                {
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.BackColor = System.Drawing.Color.LimeGreen;
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.ForeColor = Color.White;
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.SelectionBackColor = System.Drawing.Color.LimeGreen;
                    frm1.callinGRID.Rows[i].Cells["STATUS"].Style.SelectionForeColor = Color.White;

                }
            }


            frm1.callinGRID.Columns["AUTONUM"].Visible = false;
            frm1.callinGRID.Columns["AUTONUM"].Frozen = true;
            frm1.callinGRID.Columns["CIn"].Frozen = true;
            frm1.callinGRID.Columns["STATUS"].Frozen = true;


            frm1.callinGRID.Columns["AUTONUM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["STATUS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["CIN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["PROJECT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["ADDRESS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["RECIPIENT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["CONTACT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["EMAIL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["FOIL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["Screen"].Width = 100;
            frm1.callinGRID.Columns["scrbtn"].Width = 30;
            frm1.callinGRID.Columns["Windows"].Width = 100;
            frm1.callinGRID.Columns["wdwbtn"].Width = 30;
            frm1.callinGRID.Columns["DOORS"].Width = 100;
            frm1.callinGRID.Columns["dorbtn"].Width = 30;
            frm1.callinGRID.Columns["OTHER"].Width = 100;
            frm1.callinGRID.Columns["othbtn"].Width = 30;
            frm1.callinGRID.Columns["DATE VISITED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["ASSIGNED PERSONNEL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.callinGRID.Columns["serbtn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void callloggrid()
        {
            try
            {
              
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                string mydate = DateTime.Now.ToString("yyyy-MMM-dd");
                string query = "Select * from callintb where CDate = '" + mydate + "' order by autonum desc";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "callintb");
                bs.DataSource = ds;
                bs.DataMember = "callintb";
                frm1.CallLogGrid.DataSource = null;
                frm1.CallLogGrid.DataSource = bs;
                frm1.CallLogGrid.ClearSelection();
                frm1.CallLogGrid.Columns["AUTONUM"].Visible = false;
                frm1.CallLogGrid.Columns["STATUS"].Visible = false;
                frm1.CallLogGrid.Columns["CIN"].Visible = false;
                frm1.CallLogGrid.Columns["CDate"].Visible = false;
                frm1.CallLogGrid.Columns["PROJECT"].Visible = true;
                frm1.CallLogGrid.Columns["ADDRESS"].Visible = false;
                frm1.CallLogGrid.Columns["RECIPIENT"].Visible = false;
                frm1.CallLogGrid.Columns["CONTACT"].Visible = false;
                frm1.CallLogGrid.Columns["EMAIL"].Visible = false;
                frm1.CallLogGrid.Columns["FOIL"].Visible = false;
                frm1.CallLogGrid.Columns["Screen"].Visible = false; 
                frm1.CallLogGrid.Columns["Windows"].Visible = false;
                frm1.CallLogGrid.Columns["DOORS"].Visible = false;
                frm1.CallLogGrid.Columns["OTHER"].Visible = false;
                frm1.CallLogGrid.Columns["DATEVISITED"].Visible = false;
                frm1.CallLogGrid.Columns["ASSIGNEDPERSONNEL"].Visible = false;
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
        public void loadsuggestions()
        {
            try
            {
                sql.sqlcon.Open();
                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                DataSet ds4 = new DataSet();
                DataSet ds5 = new DataSet();
                DataSet ds6 = new DataSet();

                ds1.Clear();
                ds2.Clear();
                ds3.Clear();
                ds4.Clear();
                ds5.Clear();
                ds6.Clear();

                BindingSource bs1 = new BindingSource();
                BindingSource bs2 = new BindingSource();
                BindingSource bs3 = new BindingSource();
                BindingSource bs4 = new BindingSource();
                BindingSource bs5 = new BindingSource();
                BindingSource bs6 = new BindingSource();

                string str1 = "select distinct status from callintb";
                string str2 = "select distinct cdate from callintb";
                string str3 = "select distinct cin from callintb";
                string str4 = "select distinct project from callintb";
                string str5 = "select distinct address from callintb";
                string str6 = "select distinct recipient from callintb";

                sqlcmd = new SqlCommand(str1, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds1, "callintb");
                bs1.DataSource = ds1;
                bs1.DataMember = "callintb";
                frm1.statusSearch.DataSource = bs1;
                frm1.statusSearch.DisplayMember = "status";

                sqlcmd = new SqlCommand(str2, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds2, "callintb");
                bs2.DataSource = ds2;
                bs2.DataMember = "callintb";
                frm1.dateSearch.DataSource = bs2;
                frm1.dateSearch.DisplayMember = "cdate";

                sqlcmd = new SqlCommand(str3, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds3, "callintb");
                bs3.DataSource = ds3;
                bs3.DataMember = "callintb";
                frm1.cinSearch.DataSource = bs3;
                frm1.cinSearch.DisplayMember = "cin";

                sqlcmd = new SqlCommand(str4, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds4, "callintb");
                bs4.DataSource = ds4;
                bs4.DataMember = "callintb";
                frm1.projectSearch.DataSource = bs4;
                frm1.projectSearch.DisplayMember = "project";

                sqlcmd = new SqlCommand(str5, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds5, "callintb");
                bs5.DataSource = ds5;
                bs5.DataMember = "callintb";
                frm1.addressSearch.DataSource = bs5;
                frm1.addressSearch.DisplayMember = "address";

                sqlcmd = new SqlCommand(str6, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds6, "callintb");
                bs6.DataSource = ds6;
                bs6.DataMember = "callintb";
                frm1.recipientSearch.DataSource = bs6;
                frm1.recipientSearch.DisplayMember = "recipient";

                frm1.statusSearch.SelectedIndex = -1;
                frm1.dateSearch.SelectedIndex = -1;
                frm1.cinSearch.SelectedIndex = -1;
                frm1.projectSearch.SelectedIndex = -1;
                frm1.addressSearch.SelectedIndex = -1;
                frm1.recipientSearch.SelectedIndex = -1;
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
