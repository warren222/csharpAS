using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Transitions;
using System.Data.SqlClient;
using MetroFramework;


namespace AfterSalesCSharp
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        newSrevicingFRM NSF;
        newQUform quf;
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        //temporary memory
        public static string tempcin { get; set; }



        bool bol = true;
        string tempcalldateTXT;
        string tempprojectTXT;
        string tempaddressTXT;
        string temprecipientTXT;
        string tempcontactTXT;
        string tempemailTXT;
        string tempfoilTXT;
        string tempscreenTXT;
        string tempwindowsTXT;
        string tempdoorsTXT;
        string tempotherTXT;
        string tempdatevisitedTXT;
        string tempassignedpersonnelTXT;

        bool firstload = true;
        bool firstloadservicing = true;
        bool firstloadqu = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            rownumber1.SelectedIndex = 0;
            servicingrownumber.SelectedIndex = 0;
            qurownumber.SelectedIndex = 0;
        }

        private void calldategen_MouseDown(object sender, MouseEventArgs e)
        {
            calldateTXT.Text = calldategen.Text;
        }

        private void calldategen_ValueChanged(object sender, EventArgs e)
        {
            calldateTXT.Text = calldategen.Text;
        }

        private void datevisitedgen_MouseDown(object sender, MouseEventArgs e)
        {
            datevisitedTXT.Text = datevisitedgen.Text;
        }

        private void datevisitedgen_ValueChanged(object sender, EventArgs e)
        {
            datevisitedTXT.Text = datevisitedgen.Text;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            cleanCallINEntry();
            newcallinclass a = new newcallinclass(this);     
            a.addcallin(calldateTXT.Text, projectTXT.Text,
                              addressTXT.Text, recipientTXT.Text,
                              contactTXT.Text, emailTXT.Text,
                              foilTXT.Text, screenTXT.Text,
                              windowsTXT.Text, doorsTXT.Text,
                              otherTXT.Text, datevisitedTXT.Text,
                              assignedpersonnelTXT.Text);
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            CallinTableClass b = new CallinTableClass(this);
            b.loadcallintb();
        }
        //CLEAN AND CORRECT ENTRY
        public void cleanCallINEntry()
        {
            calldateTXT.Text = calldateTXT.Text.Replace("'", "`").Trim();
            calldateTXT.Text = calldateTXT.Text.Replace("\"", "``").Trim();
            projectTXT.Text = projectTXT.Text.Replace("'", "`").Trim();
            projectTXT.Text = projectTXT.Text.Replace("\"", "``").Trim();
            addressTXT.Text = addressTXT.Text.Replace("'", "`").Trim();
            addressTXT.Text = addressTXT.Text.Replace("\"", "``").Trim();
            recipientTXT.Text = recipientTXT.Text.Replace("'", "`").Trim();
            recipientTXT.Text = recipientTXT.Text.Replace("\"", "``").Trim();
            contactTXT.Text = contactTXT.Text.Replace("'", "`").Trim();
            contactTXT.Text = contactTXT.Text.Replace("\"", "``").Trim();
            emailTXT.Text = emailTXT.Text.Replace("'", "`").Trim();
            emailTXT.Text = emailTXT.Text.Replace("\"", "``").Trim();
            foilTXT.Text = foilTXT.Text.Replace("'", "`").Trim();
            foilTXT.Text = foilTXT.Text.Replace("\"", "``").Trim();
            screenTXT.Text = screenTXT.Text.Replace("'", "`").Trim();
            screenTXT.Text = screenTXT.Text.Replace("\"", "``").Trim();
            windowsTXT.Text = windowsTXT.Text.Replace("'", "`").Trim();
            windowsTXT.Text = windowsTXT.Text.Replace("\"", "``").Trim();
            doorsTXT.Text = doorsTXT.Text.Replace("'", "`").Trim();
            doorsTXT.Text = doorsTXT.Text.Replace("\"", "``").Trim();
            otherTXT.Text = otherTXT.Text.Replace("'", "`").Trim();
            otherTXT.Text = otherTXT.Text.Replace("\"", "``").Trim();
            datevisitedTXT.Text = datevisitedTXT.Text.Replace("'", "`").Trim();
            datevisitedTXT.Text = datevisitedTXT.Text.Replace("\"", "``").Trim();
            assignedpersonnelTXT.Text = assignedpersonnelTXT.Text.Replace("'", "`").Trim();
            assignedpersonnelTXT.Text = assignedpersonnelTXT.Text.Replace("\"", "``").Trim();
        }

        private void CallLogGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            newcallinPNL.VerticalScroll.Value = 0;
            if ((CallLogGrid.RowCount >= 0)&&(e.RowIndex >= 0)){
                DataGridViewRow row = CallLogGrid.Rows[e.RowIndex];
                savetotemp();
                calldateTXT.Text = row.Cells[2].Value.ToString();
                tempcin = row.Cells[3].Value.ToString();
                projectTXT.Text = row.Cells[4].Value.ToString();
                addressTXT.Text = row.Cells[5].Value.ToString();
                recipientTXT.Text = row.Cells[6].Value.ToString();
                contactTXT.Text = row.Cells[7].Value.ToString();
                emailTXT.Text = row.Cells[8].Value.ToString();
                foilTXT.Text = row.Cells[9].Value.ToString();
                screenTXT.Text = row.Cells[10].Value.ToString();
                windowsTXT.Text = row.Cells[11].Value.ToString();
                doorsTXT.Text = row.Cells[12].Value.ToString();
                otherTXT.Text = row.Cells[13].Value.ToString();
                datevisitedTXT.Text = row.Cells[14].Value.ToString();
                assignedpersonnelTXT.Text = row.Cells[15].Value.ToString();
                addBTN.Text = "Reentry";
                updateBTN.Visible = true;
                cancelBTN.Visible = true;
                deleteBTN.Visible = true;
                Color x = Color.Red;
                txtforecolor(x);
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            CallLogGrid.ClearSelection();
            addBTN.Text = "Add";
            updateBTN.Visible = false;
            cancelBTN.Visible = false;
            deleteBTN.Visible = false;
            bol = true;
            tempcin = "";
            storetemp();
            Color x= SystemColors.ControlText;
            txtforecolor(x);
        }
        //SAVE DATA INTO TEMPORARY MEMORY
        public void savetotemp()
        {
            if (bol == true)
            {
                tempcalldateTXT = calldateTXT.Text;
                tempprojectTXT = projectTXT.Text;
                tempaddressTXT = addressTXT.Text;
                temprecipientTXT = recipientTXT.Text;
                tempcontactTXT = contactTXT.Text;
                tempemailTXT = emailTXT.Text;
                tempfoilTXT = foilTXT.Text;
                tempscreenTXT = screenTXT.Text;
                tempwindowsTXT = windowsTXT.Text;
                tempdoorsTXT = doorsTXT.Text;
                tempotherTXT = otherTXT.Text;
                tempdatevisitedTXT = datevisitedTXT.Text;
                tempassignedpersonnelTXT = assignedpersonnelTXT.Text;
                bol = false;
            }
        }
        //STORE TEMP DATA BACK TO ORIGINAL OBJECT
        public void storetemp()
        {
            calldateTXT.Text = tempcalldateTXT;
            projectTXT.Text = tempprojectTXT;
            addressTXT.Text = tempaddressTXT;
            recipientTXT.Text = temprecipientTXT;
            contactTXT.Text = tempcontactTXT;
            emailTXT.Text = tempemailTXT;
            foilTXT.Text = tempfoilTXT;
            screenTXT.Text = tempscreenTXT;
            windowsTXT.Text = tempwindowsTXT;
            doorsTXT.Text = tempdoorsTXT;
            otherTXT.Text = tempotherTXT;
            datevisitedTXT.Text = tempdatevisitedTXT;
            assignedpersonnelTXT.Text = tempassignedpersonnelTXT;
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            cleanCallINEntry();
            if (tempcin == "")
            {

            }
            else
            {
                if(MetroMessageBox.Show(this, "Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                newcallinclass a = new newcallinclass(this);
                a.updatecallin(tempcin, calldateTXT.Text, projectTXT.Text,
                   addressTXT.Text, recipientTXT.Text,
                   contactTXT.Text, emailTXT.Text,
                   foilTXT.Text, screenTXT.Text,
                   windowsTXT.Text, doorsTXT.Text,
                   otherTXT.Text, datevisitedTXT.Text,
                   assignedpersonnelTXT.Text);
            }
        }

        private void dropsearchpanelBTN_Click(object sender, EventArgs e)
        {
            Transition T1 = new Transition(new TransitionType_EaseInEaseOut(200));
            int H = callinGRID.Height;
            if (callinGRID.Location.Y == 174)
            {
                T1.add(callinGRID, "Top", 64);
                T1.run();
                callinGRID.Height = H + 110;
            }
            else
            {
                T1.add(callinGRID, "Top", 174);
                T1.run();
                callinGRID.Height = H - 110;
            }
            CallinTableClass b = new CallinTableClass(this);
            b.loadsuggestions();
        }

        private void callinGRID_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            sql s = new sql(this);
            s.autorow(sender, e);
        }

        private void callinGRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if ((callinGRID.RowCount >= 0) && (e.RowIndex >= 0))
            {
                DataGridViewRow row = callinGRID.Rows[e.RowIndex];
                tempcin = row.Cells[3].Value.ToString();
                MessageBoxIcon icon = MessageBoxIcon.Question;
                if (e.ColumnIndex == 11)
                    MetroMessageBox.Show(this, "" + row.Cells[10].Value.ToString() + "", "Screens Concern", MessageBoxButtons.OK, icon);
                else if (e.ColumnIndex == 13)
                    MetroMessageBox.Show(this, "" + row.Cells[12].Value.ToString() + "", "Windows Concern", MessageBoxButtons.OK, icon);
                else if (e.ColumnIndex == 15)
                    MetroMessageBox.Show(this, "" + row.Cells[14].Value.ToString() + "", "Doors Concern", MessageBoxButtons.OK, icon);
                else if (e.ColumnIndex == 17)
                    MetroMessageBox.Show(this, "" + row.Cells[16].Value.ToString() + "", "Other Concern", MessageBoxButtons.OK, icon);
                else if (e.ColumnIndex == 20)
                { 
                    NSF = new newSrevicingFRM();
                    NSF.ShowDialog();
                }
            else
                return;
            }
            else
            {
                return;
            }
        }

        private void projectTXT_ButtonClick(object sender, EventArgs e)
        {
            buttonsearchclick(projectTXT, "PROJECT");
        }

        private void CLEARSEARCHRESULTbtn_Click(object sender, EventArgs e)
        {
            searchResultGridview.DataSource = null;
            searchresultLBL.Text = searchResultGridview.RowCount.ToString() + " Search result...";
            CLEARSEARCHRESULTbtn.Visible = false;
        }

        private void searchResultGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            newcallinPNL.VerticalScroll.Value = 0;
            if ((searchResultGridview.RowCount >= 0) && (e.RowIndex >= 0))
            {
                DataGridViewRow row = searchResultGridview.Rows[e.RowIndex];
                savetotemp();
                calldateTXT.Text = row.Cells[2].Value.ToString();
                tempcin = row.Cells[3].Value.ToString();
                projectTXT.Text = row.Cells[4].Value.ToString();
                addressTXT.Text = row.Cells[5].Value.ToString();
                recipientTXT.Text = row.Cells[6].Value.ToString();
                contactTXT.Text = row.Cells[7].Value.ToString();
                emailTXT.Text = row.Cells[8].Value.ToString();
                foilTXT.Text = row.Cells[9].Value.ToString();
                screenTXT.Text = row.Cells[10].Value.ToString();
                windowsTXT.Text = row.Cells[11].Value.ToString();
                doorsTXT.Text = row.Cells[12].Value.ToString();
                otherTXT.Text = row.Cells[13].Value.ToString();
                datevisitedTXT.Text = row.Cells[14].Value.ToString();
                assignedpersonnelTXT.Text = row.Cells[15].Value.ToString();
                addBTN.Text = "Reentry";
                updateBTN.Visible = true;
                cancelBTN.Visible = true;
                deleteBTN.Visible = true;
                Color x = Color.Red;
                txtforecolor(x);
            } 
        }
        //CHANGING FORECOLOR OF NEWCALLIN FIELDS
        public void txtforecolor(Color x)
        {
            calldateTXT.ForeColor = x;
            projectTXT.ForeColor = x;
            addressTXT.ForeColor = x;
            recipientTXT.ForeColor = x;
            contactTXT.ForeColor = x;
            emailTXT.ForeColor = x;
            foilTXT.ForeColor = x;
            screenTXT.ForeColor = x;
            windowsTXT.ForeColor = x;
            doorsTXT.ForeColor = x;
            otherTXT.ForeColor = x;
            datevisitedTXT.ForeColor = x;
            assignedpersonnelTXT.ForeColor = x;
        }

        private void addressTXT_ButtonClick(object sender, EventArgs e)
        {
            buttonsearchclick(addressTXT, "address");
        }

        private void recipientTXT_ButtonClick(object sender, EventArgs e)
        {
            buttonsearchclick(recipientTXT, "recipient");
        }

        private void contactTXT_ButtonClick(object sender, EventArgs e)
        {
            buttonsearchclick(contactTXT, "contact");
        }

        private void emailTXT_ButtonClick(object sender, EventArgs e)
        {
            buttonsearchclick(emailTXT, "email");
        }

        private void foilTXT_ButtonClick(object sender, EventArgs e)
        {
            buttonsearchclick(foilTXT, "foil");
        }
        public void buttonsearchclick(Control objectname,string column)
        {
            objectname.Text = objectname.Text.Replace("'", "`");
            objectname.Text = objectname.Text.Replace("\"", "``");
            if (objectname.Text == "")
            {
                MetroMessageBox.Show(this, "Please enter " + column + " to search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CallinTableClass b = new CallinTableClass(this);
                newcallinclass a = new newcallinclass(this);
                string str = "select " + b.callintbcolumns + " from callintb where " + column + " like '%" + objectname.Text + "%' order by autonum desc";
                a.loadsearchresult(str);
            }
        }

        private void clearallfieldsLNK_LinkClicked(object sender, EventArgs e)
        {
            tempcin = "";
            calldateTXT.Clear();
            projectTXT.Clear();
            addressTXT.Clear();
            recipientTXT.Clear();
            contactTXT.Clear();
            emailTXT.Clear();
            foilTXT.Clear();
            screenTXT.Clear();
            windowsTXT.Clear();
            doorsTXT.Clear();
            otherTXT.Clear();
            datevisitedTXT.Clear();
            assignedpersonnelTXT.Clear();
            cancelBTN.PerformClick();
            CLEARSEARCHRESULTbtn.PerformClick();
        }

        private void searchResultGridview_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            sql s = new sql(this);
            s.autorow(sender, e);
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if ( MetroMessageBox.Show(this, "Delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            newcallinclass a = new newcallinclass(this);
            a.deletecallin(tempcin);
        }

        private void findBTN_Click(object sender, EventArgs e)
        {
            cleanSearchfields();

            string cola = "STATUS";
            string colb = "CDATE";
            string colc = "CIN";
            string cold = "PROJECT";
            string colf = "ADDRESS";
            string colg = "RECIPIENT";

            string a = statusSearch.Text;
            string b = dateSearch.Text;
            string c = cinSearch.Text;
            string d = projectSearch.Text;
            string f = addressSearch.Text;
            string g = recipientSearch.Text;

            if (a =="")
                a = "STATUS";
            else
                a = "'%" + a + "%'";

            if (b == "")
                b = "CDATE";
            else
                b = "'%" + b + "%'";

            if (c == "")
                c = "CIN";
            else
                c = "'%" + c + "%'";

            if (d == "")
                d = "PROJECT";
            else
                d = "'%" + d + "%'";

            if (f == "")
                f = "ADDRESS";
            else
                f = "'%" + f + "%'";

            if (g == "")
                g = "RECIPIENT";
            else
                g = "'%" + g + "%'";

            CallinTableClass y = new CallinTableClass(this);
        string query = "select " + rowcounter(rownumber1.Text) + " " + y.callintbcolumns + " from callintb where " + cola + " like " + a + " and "+
                                                            "" + colb + " like " + b + " and "+
                                                            "" + colc + " like " + c + " and "+
                                                            "" + cold + " like " + d + " and "+
                                                            "" + colf + " like " + f + " and "+
                                                            "" + colg + " like " + g + " order by autonum desc";

            y.findcallin(query);
        }
        //CLEAR SEARCH FIELDS
        public void cleanSearchfields()
        {
            statusSearch.Text = statusSearch.Text.Replace("'", "`").Trim();
            statusSearch.Text = statusSearch.Text.Replace("\"", "``").Trim();
            dateSearch.Text = dateSearch.Text.Replace("'", "`").Trim();
            dateSearch.Text = dateSearch.Text.Replace("\"", "``").Trim();
            cinSearch.Text = cinSearch.Text.Replace("'", "`").Trim();
            cinSearch.Text = cinSearch.Text.Replace("\"", "``").Trim();
            projectSearch.Text = projectSearch.Text.Replace("'", "`").Trim();
            projectSearch.Text = projectSearch.Text.Replace("\"", "``").Trim();
            addressSearch.Text = addressSearch.Text.Replace("'", "`").Trim();
            addressSearch.Text = addressSearch.Text.Replace("\"", "``").Trim();
            recipientSearch.Text = recipientSearch.Text.Replace("'", "`").Trim();
            recipientSearch.Text = recipientSearch.Text.Replace("\"", "``").Trim();
        }

        private void statusSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                findBTN.PerformClick();
            }
        }

        private void clearsearchBTN_Click(object sender, EventArgs e)
        {
            statusSearch.Text = "";
            dateSearch.Text = "";
            cinSearch.Text = "";
            projectSearch.Text = "";
            addressSearch.Text = "";
            recipientSearch.Text = "";
        }

        private void regularserchTXT_ButtonClick(object sender, EventArgs e)
        {
            regularserchTXT.Text = regularserchTXT.Text.Replace("'", "`").Trim();
            regularserchTXT.Text = regularserchTXT.Text.Replace("\"", "``").Trim();

            CallinTableClass b = new CallinTableClass(this);
            string query = "select " + rowcounter(rownumber1.Text) + " " + b.callintbcolumns + " from callintb where project like '%" + regularserchTXT.Text + "%'";
            b.findcallin(query);
        }

        private void servicingrefreshBTN_Click(object sender, EventArgs e)
        {
            ServicingClass c = new ServicingClass(this,NSF);
            c.loadservicingtb("");
        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MetroTabControl1.SelectedIndex == 1)
            {
                if (firstload == false)
                {
                }
                else
                {
                    CallinTableClass b = new CallinTableClass(this);
                    b.loadcallintb();
                    firstload = false;
                }
            }
            else if (MetroTabControl1.SelectedIndex == 2)
            {
                if (firstloadservicing == false)
                {
                }
                else
                {
                    ServicingClass c = new ServicingClass(this,NSF);
                    c.loadservicingtb("");
                    firstloadservicing = false;
                }
            }
            else if (MetroTabControl1.SelectedIndex == 3)
            {
                if (firstloadqu == false)
                {
                }
                else
                {
                    quClass q = new quClass(this, quf);
                    q.loadquotaiontb();
                    firstloadqu = false;
                }
            }
        }

        private void servicingGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((servicingGridView.RowCount >= 0) && (e.RowIndex >= 0))
            {
                DataGridViewRow row = servicingGridView.Rows[e.RowIndex];
                tempcin = row.Cells[3].Value.ToString();
                if (e.ColumnIndex == 9)
                {
                    MetroMessageBox.Show(this, "" + row.Cells[8].Value.ToString() + "", "Assignee's Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (e.ColumnIndex == 11)
                {
                    MetroMessageBox.Show(this, "" + row.Cells[10].Value.ToString() + "", "Needed Materials / Remarks", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (e.ColumnIndex == 13)
                {
                    MetroMessageBox.Show(this, "" + row.Cells[12].Value.ToString() + "", "FOR RESCHED", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (e.ColumnIndex == 15)
                {
                    MetroMessageBox.Show(this, "" + row.Cells[14].Value.ToString() + "", "FOR COSTING", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (e.ColumnIndex == 17)
                {
                    MetroMessageBox.Show(this, "" + row.Cells[16].Value.ToString() + "", "FOR QUOTATION / ADDITIONAL", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (e.ColumnIndex == 4)
                {
                    NSF = new newSrevicingFRM();
                    NSF.ShowDialog();
                }
            }
        }

        private void servicingGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            sql s = new AfterSalesCSharp.sql(this);
            s.autorow(sender,e); 
        }

        private void servicingprojectSearch_ButtonClick(object sender, EventArgs e)
        {
            servicingprojectSearch.Text = servicingprojectSearch.Text.Replace("'", "`").Trim();
            servicingprojectSearch.Text = servicingprojectSearch.Text.Replace("\"", "``").Trim();

            ServicingClass c = new ServicingClass(this,NSF);
            string con = " where b.project like '%" + servicingprojectSearch.Text + "%' ";
            c.loadservicingtb(con);
        }
        public string rowcounter(string rownum)
        {
            if (rownum == "100")
                rownum = " TOP 100 ";
            else if (rownum == "200")
                rownum = " TOP 200 ";
            else if (rownum == "400")
                rownum = " TOP 400 ";
            else if (rownum == "800")
                rownum = " TOP 800 ";
            else if (rownum == "1,600")
                rownum = " TOP 1600 ";
            else if (rownum == "2,400")
                rownum = " TOP 2400 ";
            else if (rownum == "3,200")
                rownum = " TOP 3200 ";
            else if (rownum == "6,400")
                rownum = " TOP 6400 ";
            else if (rownum == "10,000")
                rownum = " TOP 10000 ";
            else if (rownum == "20,000")
                rownum = " TOP 20000 ";
            else if (rownum == "100,000")
                rownum = " TOP 100000 ";
            else if (rownum == "500,000")
                rownum = " TOP 500000 ";
            else if (rownum == "1,000,000")
                rownum = " TOP 1000000 ";
            else if (rownum == "1,500,000")
                rownum = " TOP 1500000 ";
            else if (rownum == "MAX")
                rownum = " ";
            return rownum;
        }

        private void qurefreshBTN_Click(object sender, EventArgs e)
        {
            quClass q = new quClass(this,quf);
            q.loadquotaiontb();
        }

        private void quaddnewBTN_Click(object sender, EventArgs e)
        {
            newQUform q = new newQUform();
            q.ShowDialog();
        }

        private void quGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((quGridView.RowCount >= 0) && (e.RowIndex >= 0))
            {
                DataGridViewRow rows = quGridView.Rows[e.RowIndex];
                if (e.ColumnIndex == 1)
                {
                    newQUform qu = new newQUform();
                    qu.aseno.Text = rows.Cells[0].Value.ToString();
                    qu.qudate.Text = rows.Cells[2].Value.ToString();
                    qu.projectTXT.Text = rows.Cells[3].Value.ToString();
                    qu.addressTXT.Text = rows.Cells[4].Value.ToString();
                    qu.telno.Text = rows.Cells[5].Value.ToString();
                    qu.faxno.Text = rows.Cells[6].Value.ToString();
                    qu.preparedby.Text= rows.Cells[7].Value.ToString();
                    qu.approvedby.Text = rows.Cells[8].Value.ToString();
                    qu.acceptedby.Text = rows.Cells[9].Value.ToString();

                    quClass q = new quClass(this, qu);
                    q.loaditems(qu.aseno.Text);
                    qu.aseno.Enabled = false;
                    qu.panel1.Enabled = true;
                    qu.ShowDialog();
                }
            }
        }
    }
}
