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
using MetroFramework;

namespace AfterSalesCSharp
{
    public partial class newQUform : MetroForm
    {
        Form1 frm1;
        string tempitemid;
        public newQUform()
        {
            InitializeComponent();
        }

        private void aseno_ButtonClick(object sender, EventArgs e)
        {
            aseno.Text = aseno.Text.Replace("'", "").Trim();
            aseno.Text = aseno.Text.Replace("\"", "").Trim();
            quClass q = new quClass(frm1,this);
            q.addase(aseno.Text);
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
           cleanentry();
            quClass q = new quClass(frm1,this);
            q.savequotation(aseno.Text,qudate.Text,projectTXT.Text,
                            addressTXT.Text,telno.Text,faxno.Text,
                            preparedby.Text,approvedby.Text,acceptedby.Text);
        }
        public void cleanentry()
        {
            qudate.Text = qudate.Text.Replace("'", "`").Trim();
            qudate.Text = qudate.Text.Replace("\"", "``").Trim();
            projectTXT.Text = projectTXT.Text.Replace("'", "`").Trim();
            projectTXT.Text = projectTXT.Text.Replace("\"", "``").Trim();
            addressTXT.Text = addressTXT.Text.Replace("'", "`").Trim();
            addressTXT.Text = addressTXT.Text.Replace("\"", "``").Trim();
            telno.Text = telno.Text.Replace("'", "`").Trim();
            telno.Text = telno.Text.Replace("\"", "``").Trim();
            faxno.Text = faxno.Text.Replace("'", "`").Trim();
            faxno.Text = faxno.Text.Replace("\"", "``").Trim();
            preparedby.Text = preparedby.Text.Replace("'", "`").Trim();
            preparedby.Text = preparedby.Text.Replace("\"", "``").Trim();
            approvedby.Text = approvedby.Text.Replace("'", "`").Trim();
            approvedby.Text = approvedby.Text.Replace("\"", "``").Trim();
            acceptedby.Text = acceptedby.Text.Replace("'", "`").Trim();
            acceptedby.Text = acceptedby.Text.Replace("\"", "``").Trim();
        }

        private void MetroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            qudate.Text = MetroDateTime1.Text;
        }

        private void MetroDateTime1_MouseDown(object sender, MouseEventArgs e)
        {
            qudate.Text = MetroDateTime1.Text;
        }

        private void unitprice_Leave(object sender, EventArgs e)
        {
            if (sql.IsNumeric(unitprice.Text) == false)
            {
                MetroMessageBox.Show(this, "Invalid Unit Price", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unitprice.Focus();
            }
        }

        private void qty_Leave(object sender, EventArgs e)
        {
            if (sql.IsNumeric(qty.Text) == false)
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qty.Focus();
            }
        }

        private void netamount_Leave(object sender, EventArgs e)
        {
            if (sql.IsNumeric(netamount.Text) == false)
            {
                MetroMessageBox.Show(this, "Invalid Net Price", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                netamount.Focus();
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            cleanitementry();
         
            quClass q = new quClass(frm1,this);
            q.addnewitem(aseno.Text,itemno.Text,wdwloc.Text,parts.Text,unitprice.Text,qty.Text,netamount.Text);
            q.loaditems(aseno.Text);
        }
        public void cleanitementry()
        {
            itemno.Text = itemno.Text.Replace("'", "`");
            itemno.Text = itemno.Text.Replace("\"", "``");
            wdwloc.Text = wdwloc.Text.Replace("'", "`");
            wdwloc.Text = wdwloc.Text.Replace("\"", "``");
            parts.Text = parts.Text.Replace("'", "`");
            parts.Text = parts.Text.Replace("\"", "``");
        }

        private void itemGRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((itemGRID.RowCount>=0) && (e.RowIndex>=0))
            {
                DataGridViewRow rows = itemGRID.Rows[e.RowIndex];
                tempitemid = rows.Cells[0].Value.ToString();
                itemno.Text = rows.Cells[2].Value.ToString();
                wdwloc.Text= rows.Cells[3].Value.ToString();
                parts.Text = rows.Cells[4].Value.ToString();
                unitprice.Text = rows.Cells[5].Value.ToString();
                qty.Text = rows.Cells[6].Value.ToString();
                netamount.Text = rows.Cells[7].Value.ToString();
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            cleanitementry();
            quClass q = new quClass(frm1, this);
            q.updateitem(tempitemid, itemno.Text, wdwloc.Text, parts.Text, unitprice.Text, qty.Text, netamount.Text);
            q.loaditems(aseno.Text);
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Click yes to delete this item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            quClass q = new quClass(frm1, this);
            q.deleteitem(tempitemid);
            q.loaditems(aseno.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (((sql.IsNumeric(unitprice.Text) == true) && (sql.IsNumeric(qty.Text) == true)))
            {
                double up= double.Parse(unitprice.Text);
                double qt = double.Parse(qty.Text);
                double r = (up * qt);
                netamount.Text = r.ToString();
            }
        }

        private void newQUform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
