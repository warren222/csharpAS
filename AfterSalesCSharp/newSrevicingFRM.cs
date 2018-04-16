using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;

namespace AfterSalesCSharp
{
    public partial class newSrevicingFRM : MetroFramework.Forms.MetroForm
    {
        Form1 frm1;
        public newSrevicingFRM()
        {
            InitializeComponent();
        }


        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        string tempcin = Form1.tempcin;
        int counter  = 0;
        string suffix = "";

        bool bol = true;
        string tempid;
        string tempsdate;
        string tempassignedpersonnel;
        string tempassigneesreport;
        string tempdone;
        string tempremarks;
        string tempforsched;
        string tempforcosting;
        string tempforquotation;

        private void newSrevicingFRM_Load(object sender, EventArgs e)
        {
            ServicingClass c = new ServicingClass(frm1,this);
            c.loadnewservicing(tempcin);
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            cleanentry();
            countervalue(tempcin);
            ServicingClass c = new ServicingClass(frm1, this);
            c.newservicing(tempcin, suffix, servicingdate.Text,
                                     assignedpersonnelTXT.Text, assigneesreportTXT.Text,
                                  doneTXT.Text, remarksTXT.Text,
                                      forschedTXT.Text, forcostingTXT.Text,
                                    forquotationTXT.Text);
        }
        public void cleanentry()
        {
            servicingdate.Text = servicingdate.Text.Replace("'", "`");
            servicingdate.Text = servicingdate.Text.Replace("\"", "``");
            assignedpersonnelTXT.Text = assignedpersonnelTXT.Text.Replace("'", "`");
            assignedpersonnelTXT.Text = assignedpersonnelTXT.Text.Replace("\"", "``");
            assigneesreportTXT.Text = assigneesreportTXT.Text.Replace("'", "`");
            assigneesreportTXT.Text = assigneesreportTXT.Text.Replace("\"", "``");
            doneTXT.Text = doneTXT.Text.Replace("'", "`");
            doneTXT.Text = doneTXT.Text.Replace("\"", "``");
            remarksTXT.Text = remarksTXT.Text.Replace("'", "`");
            remarksTXT.Text = remarksTXT.Text.Replace("\"", "``");
            forschedTXT.Text = forschedTXT.Text.Replace("'", "`");
            forschedTXT.Text = forschedTXT.Text.Replace("\"", "``");
            forcostingTXT.Text = forcostingTXT.Text.Replace("'", "`"); 
            forcostingTXT.Text = forcostingTXT.Text.Replace("\"", "``");
            forquotationTXT.Text = forquotationTXT.Text.Replace("'", "`");
            forquotationTXT.Text = forquotationTXT.Text.Replace("\"", "``");
        }
        public void countervalue(string cin)
        {
            try
            {
                sql.sqlcon.Open();
                string query = " select count(cin)+1 from servicingtb where cin = '" + cin + "'";
                sqlcmd = new SqlCommand(query, sql.sqlcon);
                SqlDataReader read = sqlcmd.ExecuteReader();
                while(read.Read())
                {
                    counter = int.Parse(read[0].ToString());
                }
                read.Close();
                suffixvalue();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(this, "" + e + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlcon.Close();
            }
        }
        public void suffixvalue()
        {
            string x;
            switch(counter)
            {
                case 1:
                    x = "st";
                    break;
                case 2:
                    x = "nd";
                    break;
                case 3:
                    x = "rd";
                    break;
                default:
                    x = "th";
                    break;

            }
            suffix = "" + counter + "" + "" + x + " Servicing Schedule";
        }

        private void servicingGRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = servicingGRID.Rows[e.RowIndex];
            if ((servicingGRID.RowCount >= 0) && (e.RowIndex >= 0))
            {

                if (e.ColumnIndex == 7)
                {
                    MetroMessageBox.Show(this, "" + row.Cells[6].Value.ToString() + "", "Assignee's Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (e.ColumnIndex == 9)
                {
                    MetroMessageBox.Show(this, "" + row.Cells[8].Value.ToString() + "", "Needed Materials / Remarks", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                savetotemp();

                tempid = row.Cells[0].Value.ToString();
                servicingdate.Text = row.Cells[4].Value.ToString();
                assignedpersonnelTXT.Text = row.Cells[5].Value.ToString();
                assigneesreportTXT.Text = row.Cells[6].Value.ToString();
                doneTXT.Text = row.Cells[1].Value.ToString();
                remarksTXT.Text = row.Cells[8].Value.ToString();
                forschedTXT.Text = row.Cells[10].Value.ToString();
                forcostingTXT.Text = row.Cells[11].Value.ToString();
                forquotationTXT.Text = row.Cells[12].Value.ToString();

                cancelBTN.Visible = true;
                deleteBTN.Visible = true;
                updateBTN.Visible = true;
                addBTN.Visible = false;

                Color x = Color.Red;
                editmode(x);
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            cancelBTN.Visible = false;
            deleteBTN.Visible = false;
            updateBTN.Visible = false;
            addBTN.Visible = true;
            storetemp();
            bol = true;
            Color x = Color.Black;
            editmode(x);
        }
        public void savetotemp()
        {
            if(bol == true)
            {
                tempsdate = servicingdate.Text;
                tempassignedpersonnel = assignedpersonnelTXT.Text;
                tempassigneesreport = assigneesreportTXT.Text;
                tempdone = doneTXT.Text;
                tempremarks = remarksTXT.Text;
                tempforsched = forschedTXT.Text;
                tempforcosting = forcostingTXT.Text;
                tempforquotation = forquotationTXT.Text;
                bol = false;
            }
        }
        public void storetemp()
        {
            servicingdate.Text = tempsdate;
            assignedpersonnelTXT.Text = tempassignedpersonnel;
            assigneesreportTXT.Text = tempassigneesreport;
            doneTXT.Text = tempdone;
            remarksTXT.Text = tempremarks;
            forschedTXT.Text = tempforsched;
            forcostingTXT.Text = tempforcosting;
            forquotationTXT.Text = tempforquotation;
        }
        public void editmode(Color x)
        {
            servicingdate.ForeColor = x;
            assignedpersonnelTXT.ForeColor = x;
            assigneesreportTXT.ForeColor = x;
            doneTXT.ForeColor = x;
            remarksTXT.ForeColor = x;
            forschedTXT.ForeColor = x;
            forcostingTXT.ForeColor = x;
            forquotationTXT.ForeColor = x;
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            cleanentry();
            ServicingClass c = new ServicingClass(frm1,this);
            c.updateservicing(tempid, tempcin, servicingdate.Text,
                                           assignedpersonnelTXT.Text, assigneesreportTXT.Text,
                                  doneTXT.Text, remarksTXT.Text,
                                      forschedTXT.Text, forcostingTXT.Text,
                                    forquotationTXT.Text);
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if(MetroMessageBox.Show(this, "Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ServicingClass c = new ServicingClass(frm1, this);
            c.deleteservicingsched(tempid, tempcin);
        }

        private void calldategen_MouseDown(object sender, MouseEventArgs e)
        {
            doneTXT.Text = calldategen.Text;
        }

        private void calldategen_ValueChanged(object sender, EventArgs e)
        {
            doneTXT.Text = calldategen.Text;
        }

        private void MetroDateTime1_MouseDown(object sender, MouseEventArgs e)
        {
            servicingdate.Text = MetroDateTime1.Text;
        }

        private void MetroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            servicingdate.Text = MetroDateTime1.Text;
        }

        private void servicingGRID_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
