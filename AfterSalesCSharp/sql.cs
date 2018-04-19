using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace AfterSalesCSharp
{
  
    class sql
    {
        static string datasource = "KMDI-ACER-E15\\KMDISQLSERVER";
        static string initialcatalog = "AfterSalesDB";
        static string userid = "kmdiadmin";
        static string password = "kmdiadmin";
        public static SqlConnection sqlcon = new SqlConnection("Data Source = '" + datasource + "';Network Library = 'DBMSSOCN';Initial Catalog='" + initialcatalog + "';User ID='" + userid + "';Password='" + password + "'");

        Form1 frm1;
        public sql(Form1 frm1val)
        {
            frm1 = frm1val;
        }

        public void autorow(Object sender, DataGridViewRowPostPaintEventArgs e)
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
            e.Graphics.DrawString(rowIdx, frm1.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        public static bool IsNumeric(string val)
        {
            double x;
            return double.TryParse(val, out x);
        }
    }
}
