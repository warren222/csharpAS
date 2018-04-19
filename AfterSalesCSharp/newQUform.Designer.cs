namespace AfterSalesCSharp
{
    partial class newQUform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newQUform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.itemGRID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.addBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.deleteBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.updateBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.netamount = new MetroFramework.Controls.MetroTextBox();
            this.qty = new MetroFramework.Controls.MetroTextBox();
            this.unitprice = new MetroFramework.Controls.MetroTextBox();
            this.parts = new MetroFramework.Controls.MetroTextBox();
            this.wdwloc = new MetroFramework.Controls.MetroTextBox();
            this.itemno = new MetroFramework.Controls.MetroTextBox();
            this.faxno = new MetroFramework.Controls.MetroTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.acceptedby = new MetroFramework.Controls.MetroTextBox();
            this.approvedby = new MetroFramework.Controls.MetroTextBox();
            this.preparedby = new MetroFramework.Controls.MetroTextBox();
            this.telno = new MetroFramework.Controls.MetroTextBox();
            this.addressTXT = new MetroFramework.Controls.MetroTextBox();
            this.projectTXT = new MetroFramework.Controls.MetroTextBox();
            this.MetroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.qudate = new MetroFramework.Controls.MetroTextBox();
            this.aseno = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGRID)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.saveBTN);
            this.panel1.Controls.Add(this.faxno);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.acceptedby);
            this.panel1.Controls.Add(this.approvedby);
            this.panel1.Controls.Add(this.preparedby);
            this.panel1.Controls.Add(this.telno);
            this.panel1.Controls.Add(this.addressTXT);
            this.panel1.Controls.Add(this.projectTXT);
            this.panel1.Controls.Add(this.MetroDateTime1);
            this.panel1.Controls.Add(this.qudate);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(9, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 584);
            this.panel1.TabIndex = 0;
            // 
            // saveBTN
            // 
            this.saveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBTN.Image = ((System.Drawing.Image)(resources.GetObject("saveBTN.Image")));
            this.saveBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBTN.Location = new System.Drawing.Point(716, 865);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(74, 29);
            this.saveBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.saveBTN.TabIndex = 487;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseSelectable = true;
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // itemGRID
            // 
            this.itemGRID.AllowUserToAddRows = false;
            this.itemGRID.AllowUserToDeleteRows = false;
            this.itemGRID.AllowUserToOrderColumns = true;
            this.itemGRID.AllowUserToResizeColumns = false;
            this.itemGRID.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.itemGRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.itemGRID.ColumnHeadersHeight = 30;
            this.itemGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemGRID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemGRID.Location = new System.Drawing.Point(11, 102);
            this.itemGRID.Name = "itemGRID";
            this.itemGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.itemGRID.ReadOnly = true;
            this.itemGRID.RowHeadersWidth = 40;
            this.itemGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.itemGRID.RowTemplate.Height = 27;
            this.itemGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGRID.Size = new System.Drawing.Size(774, 366);
            this.itemGRID.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.itemGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.itemGRID.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.itemGRID.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.itemGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.itemGRID.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.itemGRID.StateCommon.HeaderColumn.Border.Width = 0;
            this.itemGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemGRID.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.itemGRID.TabIndex = 486;
            this.itemGRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGRID_CellClick);
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.DarkGray;
            this.addBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBTN.Image = null;
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBTN.Location = new System.Drawing.Point(711, 68);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(74, 28);
            this.addBTN.Style = MetroFramework.MetroColorStyle.Silver;
            this.addBTN.TabIndex = 485;
            this.addBTN.Text = "Add";
            this.addBTN.UseCustomBackColor = true;
            this.addBTN.UseSelectable = true;
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.DarkGray;
            this.deleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBTN.Image = null;
            this.deleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBTN.Location = new System.Drawing.Point(551, 68);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(74, 28);
            this.deleteBTN.Style = MetroFramework.MetroColorStyle.Silver;
            this.deleteBTN.TabIndex = 484;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseCustomBackColor = true;
            this.deleteBTN.UseSelectable = true;
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.DarkGray;
            this.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBTN.Image = null;
            this.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBTN.Location = new System.Drawing.Point(631, 68);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(74, 28);
            this.updateBTN.Style = MetroFramework.MetroColorStyle.Silver;
            this.updateBTN.TabIndex = 483;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseCustomBackColor = true;
            this.updateBTN.UseSelectable = true;
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // netamount
            // 
            // 
            // 
            // 
            this.netamount.CustomButton.Image = null;
            this.netamount.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.netamount.CustomButton.Name = "";
            this.netamount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.netamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.netamount.CustomButton.TabIndex = 1;
            this.netamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.netamount.CustomButton.UseSelectable = true;
            this.netamount.CustomButton.Visible = false;
            this.netamount.DisplayIcon = true;
            this.netamount.Enabled = false;
            this.netamount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.netamount.Lines = new string[0];
            this.netamount.Location = new System.Drawing.Point(277, 68);
            this.netamount.MaxLength = 32767;
            this.netamount.Multiline = true;
            this.netamount.Name = "netamount";
            this.netamount.PasswordChar = '\0';
            this.netamount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.netamount.SelectedText = "";
            this.netamount.SelectionLength = 0;
            this.netamount.SelectionStart = 0;
            this.netamount.ShowClearButton = true;
            this.netamount.Size = new System.Drawing.Size(189, 28);
            this.netamount.Style = MetroFramework.MetroColorStyle.Red;
            this.netamount.TabIndex = 46;
            this.netamount.UseCustomForeColor = true;
            this.netamount.UseSelectable = true;
            this.netamount.WaterMark = "Net Amount";
            this.netamount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.netamount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.netamount.Leave += new System.EventHandler(this.netamount_Leave);
            // 
            // qty
            // 
            // 
            // 
            // 
            this.qty.CustomButton.Image = null;
            this.qty.CustomButton.Location = new System.Drawing.Point(52, 2);
            this.qty.CustomButton.Name = "";
            this.qty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.qty.CustomButton.TabIndex = 1;
            this.qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.qty.CustomButton.UseSelectable = true;
            this.qty.CustomButton.Visible = false;
            this.qty.DisplayIcon = true;
            this.qty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.qty.Lines = new string[0];
            this.qty.Location = new System.Drawing.Point(193, 68);
            this.qty.MaxLength = 32767;
            this.qty.Multiline = true;
            this.qty.Name = "qty";
            this.qty.PasswordChar = '\0';
            this.qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qty.SelectedText = "";
            this.qty.SelectionLength = 0;
            this.qty.SelectionStart = 0;
            this.qty.ShowClearButton = true;
            this.qty.Size = new System.Drawing.Size(78, 28);
            this.qty.Style = MetroFramework.MetroColorStyle.Red;
            this.qty.TabIndex = 45;
            this.qty.UseCustomForeColor = true;
            this.qty.UseSelectable = true;
            this.qty.WaterMark = "Quantity";
            this.qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.qty.Leave += new System.EventHandler(this.qty_Leave);
            // 
            // unitprice
            // 
            // 
            // 
            // 
            this.unitprice.CustomButton.Image = null;
            this.unitprice.CustomButton.Location = new System.Drawing.Point(150, 2);
            this.unitprice.CustomButton.Name = "";
            this.unitprice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.unitprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unitprice.CustomButton.TabIndex = 1;
            this.unitprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unitprice.CustomButton.UseSelectable = true;
            this.unitprice.CustomButton.Visible = false;
            this.unitprice.DisplayIcon = true;
            this.unitprice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.unitprice.Lines = new string[0];
            this.unitprice.Location = new System.Drawing.Point(11, 68);
            this.unitprice.MaxLength = 32767;
            this.unitprice.Multiline = true;
            this.unitprice.Name = "unitprice";
            this.unitprice.PasswordChar = '\0';
            this.unitprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unitprice.SelectedText = "";
            this.unitprice.SelectionLength = 0;
            this.unitprice.SelectionStart = 0;
            this.unitprice.ShowClearButton = true;
            this.unitprice.Size = new System.Drawing.Size(176, 28);
            this.unitprice.Style = MetroFramework.MetroColorStyle.Red;
            this.unitprice.TabIndex = 44;
            this.unitprice.UseCustomForeColor = true;
            this.unitprice.UseSelectable = true;
            this.unitprice.WaterMark = "Unit Price";
            this.unitprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unitprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.unitprice.Leave += new System.EventHandler(this.unitprice_Leave);
            // 
            // parts
            // 
            // 
            // 
            // 
            this.parts.CustomButton.Image = null;
            this.parts.CustomButton.Location = new System.Drawing.Point(409, 2);
            this.parts.CustomButton.Name = "";
            this.parts.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.parts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.parts.CustomButton.TabIndex = 1;
            this.parts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.parts.CustomButton.UseSelectable = true;
            this.parts.CustomButton.Visible = false;
            this.parts.DisplayIcon = true;
            this.parts.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.parts.Lines = new string[0];
            this.parts.Location = new System.Drawing.Point(350, 16);
            this.parts.MaxLength = 32767;
            this.parts.Multiline = true;
            this.parts.Name = "parts";
            this.parts.PasswordChar = '\0';
            this.parts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.parts.SelectedText = "";
            this.parts.SelectionLength = 0;
            this.parts.SelectionStart = 0;
            this.parts.ShowClearButton = true;
            this.parts.Size = new System.Drawing.Size(435, 28);
            this.parts.Style = MetroFramework.MetroColorStyle.Red;
            this.parts.TabIndex = 43;
            this.parts.UseCustomForeColor = true;
            this.parts.UseSelectable = true;
            this.parts.WaterMark = "Parts / Accessories Used";
            this.parts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.parts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // wdwloc
            // 
            // 
            // 
            // 
            this.wdwloc.CustomButton.Image = null;
            this.wdwloc.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.wdwloc.CustomButton.Name = "";
            this.wdwloc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.wdwloc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.wdwloc.CustomButton.TabIndex = 1;
            this.wdwloc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.wdwloc.CustomButton.UseSelectable = true;
            this.wdwloc.CustomButton.Visible = false;
            this.wdwloc.DisplayIcon = true;
            this.wdwloc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.wdwloc.Lines = new string[0];
            this.wdwloc.Location = new System.Drawing.Point(96, 16);
            this.wdwloc.MaxLength = 32767;
            this.wdwloc.Multiline = true;
            this.wdwloc.Name = "wdwloc";
            this.wdwloc.PasswordChar = '\0';
            this.wdwloc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wdwloc.SelectedText = "";
            this.wdwloc.SelectionLength = 0;
            this.wdwloc.SelectionStart = 0;
            this.wdwloc.ShowClearButton = true;
            this.wdwloc.Size = new System.Drawing.Size(248, 28);
            this.wdwloc.Style = MetroFramework.MetroColorStyle.Red;
            this.wdwloc.TabIndex = 42;
            this.wdwloc.UseCustomForeColor = true;
            this.wdwloc.UseSelectable = true;
            this.wdwloc.WaterMark = "Wdw / Door Location";
            this.wdwloc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.wdwloc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // itemno
            // 
            // 
            // 
            // 
            this.itemno.CustomButton.Image = null;
            this.itemno.CustomButton.Location = new System.Drawing.Point(53, 2);
            this.itemno.CustomButton.Name = "";
            this.itemno.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.itemno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.itemno.CustomButton.TabIndex = 1;
            this.itemno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itemno.CustomButton.UseSelectable = true;
            this.itemno.CustomButton.Visible = false;
            this.itemno.DisplayIcon = true;
            this.itemno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.itemno.Lines = new string[0];
            this.itemno.Location = new System.Drawing.Point(11, 16);
            this.itemno.MaxLength = 32767;
            this.itemno.Multiline = true;
            this.itemno.Name = "itemno";
            this.itemno.PasswordChar = '\0';
            this.itemno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemno.SelectedText = "";
            this.itemno.SelectionLength = 0;
            this.itemno.SelectionStart = 0;
            this.itemno.ShowClearButton = true;
            this.itemno.Size = new System.Drawing.Size(79, 28);
            this.itemno.Style = MetroFramework.MetroColorStyle.Red;
            this.itemno.TabIndex = 41;
            this.itemno.UseCustomForeColor = true;
            this.itemno.UseSelectable = true;
            this.itemno.WaterMark = "Item #";
            this.itemno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.itemno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // faxno
            // 
            // 
            // 
            // 
            this.faxno.CustomButton.Image = null;
            this.faxno.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.faxno.CustomButton.Name = "";
            this.faxno.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.faxno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.faxno.CustomButton.TabIndex = 1;
            this.faxno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.faxno.CustomButton.UseSelectable = true;
            this.faxno.CustomButton.Visible = false;
            this.faxno.DisplayIcon = true;
            this.faxno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.faxno.Lines = new string[0];
            this.faxno.Location = new System.Drawing.Point(599, 88);
            this.faxno.MaxLength = 32767;
            this.faxno.Multiline = true;
            this.faxno.Name = "faxno";
            this.faxno.PasswordChar = '\0';
            this.faxno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.faxno.SelectedText = "";
            this.faxno.SelectionLength = 0;
            this.faxno.SelectionStart = 0;
            this.faxno.ShowClearButton = true;
            this.faxno.Size = new System.Drawing.Size(189, 28);
            this.faxno.Style = MetroFramework.MetroColorStyle.Red;
            this.faxno.TabIndex = 40;
            this.faxno.UseCustomForeColor = true;
            this.faxno.UseSelectable = true;
            this.faxno.WaterMark = "Fax No";
            this.faxno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.faxno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(14, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(774, 144);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // acceptedby
            // 
            // 
            // 
            // 
            this.acceptedby.CustomButton.Image = null;
            this.acceptedby.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.acceptedby.CustomButton.Name = "";
            this.acceptedby.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.acceptedby.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.acceptedby.CustomButton.TabIndex = 1;
            this.acceptedby.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.acceptedby.CustomButton.UseSelectable = true;
            this.acceptedby.CustomButton.Visible = false;
            this.acceptedby.DisplayIcon = true;
            this.acceptedby.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.acceptedby.Lines = new string[0];
            this.acceptedby.Location = new System.Drawing.Point(408, 865);
            this.acceptedby.MaxLength = 32767;
            this.acceptedby.Multiline = true;
            this.acceptedby.Name = "acceptedby";
            this.acceptedby.PasswordChar = '\0';
            this.acceptedby.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.acceptedby.SelectedText = "";
            this.acceptedby.SelectionLength = 0;
            this.acceptedby.SelectionStart = 0;
            this.acceptedby.ShowClearButton = true;
            this.acceptedby.Size = new System.Drawing.Size(189, 28);
            this.acceptedby.Style = MetroFramework.MetroColorStyle.Red;
            this.acceptedby.TabIndex = 38;
            this.acceptedby.UseCustomForeColor = true;
            this.acceptedby.UseSelectable = true;
            this.acceptedby.WaterMark = "Accepted By";
            this.acceptedby.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.acceptedby.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // approvedby
            // 
            // 
            // 
            // 
            this.approvedby.CustomButton.Image = null;
            this.approvedby.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.approvedby.CustomButton.Name = "";
            this.approvedby.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.approvedby.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.approvedby.CustomButton.TabIndex = 1;
            this.approvedby.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.approvedby.CustomButton.UseSelectable = true;
            this.approvedby.CustomButton.Visible = false;
            this.approvedby.DisplayIcon = true;
            this.approvedby.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.approvedby.Lines = new string[0];
            this.approvedby.Location = new System.Drawing.Point(213, 865);
            this.approvedby.MaxLength = 32767;
            this.approvedby.Multiline = true;
            this.approvedby.Name = "approvedby";
            this.approvedby.PasswordChar = '\0';
            this.approvedby.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.approvedby.SelectedText = "";
            this.approvedby.SelectionLength = 0;
            this.approvedby.SelectionStart = 0;
            this.approvedby.ShowClearButton = true;
            this.approvedby.Size = new System.Drawing.Size(189, 28);
            this.approvedby.Style = MetroFramework.MetroColorStyle.Red;
            this.approvedby.TabIndex = 37;
            this.approvedby.UseCustomForeColor = true;
            this.approvedby.UseSelectable = true;
            this.approvedby.WaterMark = "Approved By";
            this.approvedby.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.approvedby.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // preparedby
            // 
            // 
            // 
            // 
            this.preparedby.CustomButton.Image = null;
            this.preparedby.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.preparedby.CustomButton.Name = "";
            this.preparedby.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.preparedby.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.preparedby.CustomButton.TabIndex = 1;
            this.preparedby.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.preparedby.CustomButton.UseSelectable = true;
            this.preparedby.CustomButton.Visible = false;
            this.preparedby.DisplayIcon = true;
            this.preparedby.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.preparedby.Lines = new string[0];
            this.preparedby.Location = new System.Drawing.Point(18, 865);
            this.preparedby.MaxLength = 32767;
            this.preparedby.Multiline = true;
            this.preparedby.Name = "preparedby";
            this.preparedby.PasswordChar = '\0';
            this.preparedby.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.preparedby.SelectedText = "";
            this.preparedby.SelectionLength = 0;
            this.preparedby.SelectionStart = 0;
            this.preparedby.ShowClearButton = true;
            this.preparedby.Size = new System.Drawing.Size(189, 28);
            this.preparedby.Style = MetroFramework.MetroColorStyle.Red;
            this.preparedby.TabIndex = 36;
            this.preparedby.UseCustomForeColor = true;
            this.preparedby.UseSelectable = true;
            this.preparedby.WaterMark = "Prepared By";
            this.preparedby.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.preparedby.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // telno
            // 
            // 
            // 
            // 
            this.telno.CustomButton.Image = null;
            this.telno.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.telno.CustomButton.Name = "";
            this.telno.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.telno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.telno.CustomButton.TabIndex = 1;
            this.telno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telno.CustomButton.UseSelectable = true;
            this.telno.CustomButton.Visible = false;
            this.telno.DisplayIcon = true;
            this.telno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.telno.Lines = new string[0];
            this.telno.Location = new System.Drawing.Point(599, 54);
            this.telno.MaxLength = 32767;
            this.telno.Multiline = true;
            this.telno.Name = "telno";
            this.telno.PasswordChar = '\0';
            this.telno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telno.SelectedText = "";
            this.telno.SelectionLength = 0;
            this.telno.SelectionStart = 0;
            this.telno.ShowClearButton = true;
            this.telno.Size = new System.Drawing.Size(189, 28);
            this.telno.Style = MetroFramework.MetroColorStyle.Red;
            this.telno.TabIndex = 34;
            this.telno.UseCustomForeColor = true;
            this.telno.UseSelectable = true;
            this.telno.WaterMark = "Tel No";
            this.telno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addressTXT
            // 
            // 
            // 
            // 
            this.addressTXT.CustomButton.Image = null;
            this.addressTXT.CustomButton.Location = new System.Drawing.Point(518, 2);
            this.addressTXT.CustomButton.Name = "";
            this.addressTXT.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.addressTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addressTXT.CustomButton.TabIndex = 1;
            this.addressTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addressTXT.CustomButton.UseSelectable = true;
            this.addressTXT.CustomButton.Visible = false;
            this.addressTXT.DisplayIcon = true;
            this.addressTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.addressTXT.Lines = new string[0];
            this.addressTXT.Location = new System.Drawing.Point(14, 88);
            this.addressTXT.MaxLength = 32767;
            this.addressTXT.Name = "addressTXT";
            this.addressTXT.PasswordChar = '\0';
            this.addressTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressTXT.SelectedText = "";
            this.addressTXT.SelectionLength = 0;
            this.addressTXT.SelectionStart = 0;
            this.addressTXT.ShowClearButton = true;
            this.addressTXT.Size = new System.Drawing.Size(544, 28);
            this.addressTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.addressTXT.TabIndex = 33;
            this.addressTXT.UseCustomForeColor = true;
            this.addressTXT.UseSelectable = true;
            this.addressTXT.WaterMark = "Address";
            this.addressTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addressTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // projectTXT
            // 
            // 
            // 
            // 
            this.projectTXT.CustomButton.Image = null;
            this.projectTXT.CustomButton.Location = new System.Drawing.Point(518, 2);
            this.projectTXT.CustomButton.Name = "";
            this.projectTXT.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.projectTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectTXT.CustomButton.TabIndex = 1;
            this.projectTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectTXT.CustomButton.UseSelectable = true;
            this.projectTXT.CustomButton.Visible = false;
            this.projectTXT.DisplayIcon = true;
            this.projectTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.projectTXT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectTXT.Lines = new string[0];
            this.projectTXT.Location = new System.Drawing.Point(14, 54);
            this.projectTXT.MaxLength = 32767;
            this.projectTXT.Name = "projectTXT";
            this.projectTXT.PasswordChar = '\0';
            this.projectTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectTXT.SelectedText = "";
            this.projectTXT.SelectionLength = 0;
            this.projectTXT.SelectionStart = 0;
            this.projectTXT.ShowClearButton = true;
            this.projectTXT.Size = new System.Drawing.Size(544, 28);
            this.projectTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.projectTXT.TabIndex = 32;
            this.projectTXT.UseCustomForeColor = true;
            this.projectTXT.UseSelectable = true;
            this.projectTXT.WaterMark = "Project Name";
            this.projectTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroDateTime1
            // 
            this.MetroDateTime1.CustomFormat = "yyyy-MMM-dd";
            this.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MetroDateTime1.Location = new System.Drawing.Point(14, 15);
            this.MetroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.MetroDateTime1.Name = "MetroDateTime1";
            this.MetroDateTime1.Size = new System.Drawing.Size(126, 29);
            this.MetroDateTime1.Style = MetroFramework.MetroColorStyle.Red;
            this.MetroDateTime1.TabIndex = 30;
            this.MetroDateTime1.ValueChanged += new System.EventHandler(this.MetroDateTime1_ValueChanged);
            this.MetroDateTime1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MetroDateTime1_MouseDown);
            // 
            // qudate
            // 
            // 
            // 
            // 
            this.qudate.CustomButton.Image = null;
            this.qudate.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.qudate.CustomButton.Name = "";
            this.qudate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.qudate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.qudate.CustomButton.TabIndex = 1;
            this.qudate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.qudate.CustomButton.UseSelectable = true;
            this.qudate.CustomButton.Visible = false;
            this.qudate.DisplayIcon = true;
            this.qudate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.qudate.Lines = new string[0];
            this.qudate.Location = new System.Drawing.Point(146, 16);
            this.qudate.MaxLength = 32767;
            this.qudate.Multiline = true;
            this.qudate.Name = "qudate";
            this.qudate.PasswordChar = '\0';
            this.qudate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qudate.SelectedText = "";
            this.qudate.SelectionLength = 0;
            this.qudate.SelectionStart = 0;
            this.qudate.ShowClearButton = true;
            this.qudate.Size = new System.Drawing.Size(189, 28);
            this.qudate.Style = MetroFramework.MetroColorStyle.Red;
            this.qudate.TabIndex = 31;
            this.qudate.UseCustomForeColor = true;
            this.qudate.UseSelectable = true;
            this.qudate.WaterMark = "Quotation Date";
            this.qudate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.qudate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aseno
            // 
            // 
            // 
            // 
            this.aseno.CustomButton.Image = null;
            this.aseno.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.aseno.CustomButton.Name = "";
            this.aseno.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.aseno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aseno.CustomButton.TabIndex = 1;
            this.aseno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aseno.CustomButton.UseSelectable = true;
            this.aseno.DisplayIcon = true;
            this.aseno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.aseno.Lines = new string[0];
            this.aseno.Location = new System.Drawing.Point(610, 29);
            this.aseno.MaxLength = 32767;
            this.aseno.Multiline = true;
            this.aseno.Name = "aseno";
            this.aseno.PasswordChar = '\0';
            this.aseno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aseno.SelectedText = "";
            this.aseno.SelectionLength = 0;
            this.aseno.SelectionStart = 0;
            this.aseno.ShowButton = true;
            this.aseno.ShowClearButton = true;
            this.aseno.Size = new System.Drawing.Size(189, 28);
            this.aseno.Style = MetroFramework.MetroColorStyle.Red;
            this.aseno.TabIndex = 29;
            this.aseno.UseCustomForeColor = true;
            this.aseno.UseSelectable = true;
            this.aseno.WaterMark = "ASE NO.";
            this.aseno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aseno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.aseno.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.aseno_ButtonClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.itemno);
            this.panel2.Controls.Add(this.wdwloc);
            this.panel2.Controls.Add(this.itemGRID);
            this.panel2.Controls.Add(this.parts);
            this.panel2.Controls.Add(this.addBTN);
            this.panel2.Controls.Add(this.unitprice);
            this.panel2.Controls.Add(this.deleteBTN);
            this.panel2.Controls.Add(this.qty);
            this.panel2.Controls.Add(this.updateBTN);
            this.panel2.Controls.Add(this.netamount);
            this.panel2.Location = new System.Drawing.Point(3, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 482);
            this.panel2.TabIndex = 488;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // newQUform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aseno);
            this.MaximizeBox = false;
            this.Name = "newQUform";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.newQUform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGRID)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal MetroFramework.Controls.MetroDateTime MetroDateTime1;
        private System.Windows.Forms.TextBox textBox1;
        internal MetroFramework.Controls.MetroTextBox netamount;
        internal MetroFramework.Controls.MetroTextBox qty;
        internal MetroFramework.Controls.MetroTextBox unitprice;
        internal MetroFramework.Controls.MetroTextBox parts;
        internal MetroFramework.Controls.MetroTextBox wdwloc;
        internal MetroFramework.Controls.MetroTextBox itemno;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton deleteBTN;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton updateBTN;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton addBTN;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView itemGRID;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton saveBTN;
        public System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroTextBox aseno;
        public MetroFramework.Controls.MetroTextBox qudate;
        public MetroFramework.Controls.MetroTextBox acceptedby;
        public MetroFramework.Controls.MetroTextBox approvedby;
        public MetroFramework.Controls.MetroTextBox preparedby;
        public MetroFramework.Controls.MetroTextBox telno;
        public MetroFramework.Controls.MetroTextBox addressTXT;
        public MetroFramework.Controls.MetroTextBox projectTXT;
        public MetroFramework.Controls.MetroTextBox faxno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}