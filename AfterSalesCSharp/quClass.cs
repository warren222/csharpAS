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

        string columns = "ASENO" +
                        ",QDATE as DATE" +
                        ",PROJECT" +
                        ",ADDRESS" +
                        ",TELNO" +
                        ",FAXNO" +
                        ",PREPAREDBY AS [PREPARED BY]" +
                        ",APPROVEDBY AS [APPROVED BY]" +
                        ",ACCEPTEDBY AS [ACCEPTED BY]";
        public quClass(Form1 frm1val, newQUform qu)
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
                string str = "select "+ frm1.rowcounter(frm1.qurownumber.Text) + columns + " from quotationtb";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "quotationtb");
                bs.DataSource = ds;
                bs.DataMember = "quotationtb";
                frm1.quGridView.DataSource = bs;
                addbtn();
                managecolumns();
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
        public void addbtn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btn";
            btn.HeaderText = "";
            btn.Text = "quotation";
            btn.UseColumnTextForButtonValue = true;
            frm1.quGridView.Columns.Insert(1, btn);
        }
        public void managecolumns()
        {
            frm1.quGridView.Columns["ASENO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["PROJECT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["ADDRESS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["TELNO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["FAXNO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["PREPARED BY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["APPROVED BY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            frm1.quGridView.Columns["ACCEPTED BY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void addase(string ASE)
        {
            try
            {
                sql.sqlcon.Open();
                string checkdata = "select * from quotationtb where ASENO = '" + ASE + "'";
                sqlcmd = new SqlCommand(checkdata, sql.sqlcon);
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
            catch (SqlException e)
            {
                MetroMessageBox.Show(newQUform.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void savequotation(string ase, string qdate, string project,
                                  string address, string telno,
                                  string faxno, string prepared,
                                  string approved, string accepted)
        {
            try
            {
                sql.sqlcon.Open();
                string str = "update quotationtb set " +
                                "QDATE ='" + qdate + "'" +
                                ",PROJECT ='" + project + "'" +
                                ",ADDRESS ='" + address + "'" +
                                ",TELNO ='" + telno + "'" +
                                ",FAXNO ='" + faxno + "'" +
                                ",PREPAREDBY ='" + prepared + "'" +
                                ",APPROVEDBY ='" + approved + "'" +
                                ",ACCEPTEDBY ='" + accepted + "'" +
                                " where aseno = '" + ase + "'";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
                MetroMessageBox.Show(newQUform.ActiveForm, "Data Saved Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newQUform.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void loaditems(string ase)
        {
            try
            {
                sql.sqlcon.Open();
                DataSet ds = new DataSet();
                ds.Clear();
                BindingSource bs = new BindingSource();
                string columns = "ID" +
                                ",ASENO" +
                                ",ITEMNO as ITEM" +
                                ",WDWLOC as [WINDOW / DOOR LOCATION]" +
                                ",PARTS as [PARTS / ACCESSORIES USED]" +
                                ",UNITPRICE as [UNIT PRICE]" +
                                ",QTY as [QTY]" +
                                ",NETPRICE as [NET PRICE]";
                string str = "select " + columns + " from itemstb where aseno = '" + ase + "'";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                da.SelectCommand = sqlcmd;
                da.Fill(ds, "itemstb");
                bs.DataSource = ds;
                bs.DataMember = "itemstb";
                qufrm.itemGRID.DataSource = bs;
                manageitemcolumns();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newQUform.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void manageitemcolumns()
        {
            qufrm.itemGRID.Columns["ID"].Visible = false;
            qufrm.itemGRID.Columns["ASENO"].Visible = false;
            qufrm.itemGRID.Columns["ITEM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qufrm.itemGRID.Columns["WINDOW / DOOR LOCATION"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qufrm.itemGRID.Columns["PARTS / ACCESSORIES USED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qufrm.itemGRID.Columns["UNIT PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qufrm.itemGRID.Columns["QTY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qufrm.itemGRID.Columns["NET PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void addnewitem(string ase, string item, string wdw,
                               string parts, string unit, string qty,
                               string netamount)
        {
            try
            {
                sql.sqlcon.Open();
                if (unit == "")
                {
                    unit = "0";
                }
                if (qty == "")
                {
                    qty = "0";
                }
                if (netamount == "")
                {
                    netamount = "0";
                }
                string str = "declare @id as integer = (select max(id)+1 from itemstb)" +
                            "insert into itemstb (ID" +
                            ",ASENO" +
                            ",ITEMNO" +
                            ",WDWLOC" +
                            ",PARTS" +
                            ",UNITPRICE" +
                            ",QTY" +
                            ",NETPRICE)values" +
                            "(@id," +
                            "'" + ase + "'," +
                            "'" + item + "'," +
                            "'" + wdw + "'," +
                            "'" + parts + "'," +
                            "'" + unit + "'," +
                            "'" + qty + "'," +
                            "'" + netamount + "')";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newQUform.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void updateitem(string id, string item, string wdw,
                               string parts, string unit, string qty,
                               string netamount)
        {
            try
            {
                sql.sqlcon.Open();
                string str = "update itemstb set " +
                              "itemno='" + item + "'," +
                              "wdwloc='" + wdw + "'," +
                              "parts='" + parts + "'," +
                              "unitprice='" + unit + "'," +
                              "qty='" + qty + "'," +
                              "netprice='" + netamount + "'" +
                              " where id = '" + id + "'";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newQUform.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void deleteitem(string id)
        {
            try
            {
                sql.sqlcon.Open();
                string str = "delete from itemstb where id = '" + id + "'";
                sqlcmd = new SqlCommand(str, sql.sqlcon);
                sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(newQUform.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }

        }
    }
}
