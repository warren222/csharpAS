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

namespace AfterSalesCSharp
{
    public partial class newQUform : MetroForm
    {
        Form1 frm1;
        public newQUform()
        {
            InitializeComponent();
        }

        private void aseno_ButtonClick(object sender, EventArgs e)
        {
            quClass q = new quClass(frm1,this);
            q.addase(aseno.Text);
        }
    }
}
