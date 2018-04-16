namespace AfterSalesCSharp
{
    partial class newSrevicingFRM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newSrevicingFRM));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.servicingGRID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.deleteBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.KryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.MetroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.KryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.calldategen = new MetroFramework.Controls.MetroDateTime();
            this.forschedTXT = new MetroFramework.Controls.MetroTextBox();
            this.forcostingTXT = new MetroFramework.Controls.MetroTextBox();
            this.doneTXT = new System.Windows.Forms.ComboBox();
            this.remarksTXT = new MetroFramework.Controls.MetroTextBox();
            this.assignedpersonnelTXT = new MetroFramework.Controls.MetroTextBox();
            this.assigneesreportTXT = new MetroFramework.Controls.MetroTextBox();
            this.forquotationTXT = new MetroFramework.Controls.MetroTextBox();
            this.servicingdate = new MetroFramework.Controls.MetroTextBox();
            this.cancelBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.updateBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.addBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicingGRID)).BeginInit();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.servicingGRID);
            this.Panel1.Controls.Add(this.deleteBTN);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.cancelBTN);
            this.Panel1.Controls.Add(this.updateBTN);
            this.Panel1.Controls.Add(this.addBTN);
            this.Panel1.Location = new System.Drawing.Point(12, 61);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1139, 509);
            this.Panel1.TabIndex = 24;
            // 
            // servicingGRID
            // 
            this.servicingGRID.AllowUserToAddRows = false;
            this.servicingGRID.AllowUserToDeleteRows = false;
            this.servicingGRID.AllowUserToOrderColumns = true;
            this.servicingGRID.AllowUserToResizeColumns = false;
            this.servicingGRID.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.servicingGRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.servicingGRID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicingGRID.ColumnHeadersHeight = 30;
            this.servicingGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.servicingGRID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicingGRID.Location = new System.Drawing.Point(394, 12);
            this.servicingGRID.MultiSelect = false;
            this.servicingGRID.Name = "servicingGRID";
            this.servicingGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.servicingGRID.ReadOnly = true;
            this.servicingGRID.RowHeadersWidth = 40;
            this.servicingGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.servicingGRID.RowTemplate.Height = 27;
            this.servicingGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicingGRID.Size = new System.Drawing.Size(742, 486);
            this.servicingGRID.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.servicingGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.servicingGRID.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.servicingGRID.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.servicingGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.servicingGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.servicingGRID.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.servicingGRID.StateCommon.HeaderColumn.Border.Width = 0;
            this.servicingGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.servicingGRID.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicingGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.servicingGRID.TabIndex = 466;
            this.servicingGRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicingGRID_CellClick);
            this.servicingGRID.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.servicingGRID_RowPostPaint);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.Image")));
            this.deleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBTN.Location = new System.Drawing.Point(172, 459);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(83, 29);
            this.deleteBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteBTN.TabIndex = 482;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseSelectable = true;
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Visible = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // Panel4
            // 
            this.Panel4.AutoScroll = true;
            this.Panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel4.Controls.Add(this.KryptonLabel1);
            this.Panel4.Controls.Add(this.MetroDateTime1);
            this.Panel4.Controls.Add(this.KryptonLabel2);
            this.Panel4.Controls.Add(this.calldategen);
            this.Panel4.Controls.Add(this.forschedTXT);
            this.Panel4.Controls.Add(this.forcostingTXT);
            this.Panel4.Controls.Add(this.doneTXT);
            this.Panel4.Controls.Add(this.remarksTXT);
            this.Panel4.Controls.Add(this.assignedpersonnelTXT);
            this.Panel4.Controls.Add(this.assigneesreportTXT);
            this.Panel4.Controls.Add(this.forquotationTXT);
            this.Panel4.Controls.Add(this.servicingdate);
            this.Panel4.Location = new System.Drawing.Point(11, 3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(365, 450);
            this.Panel4.TabIndex = 25;
            // 
            // KryptonLabel1
            // 
            this.KryptonLabel1.Location = new System.Drawing.Point(235, 3);
            this.KryptonLabel1.Name = "KryptonLabel1";
            this.KryptonLabel1.Size = new System.Drawing.Size(98, 22);
            this.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel1.TabIndex = 27;
            this.KryptonLabel1.Values.Text = "Date Servicing";
            // 
            // MetroDateTime1
            // 
            this.MetroDateTime1.CustomFormat = "yyyy-MMM-dd";
            this.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MetroDateTime1.Location = new System.Drawing.Point(11, 30);
            this.MetroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.MetroDateTime1.Name = "MetroDateTime1";
            this.MetroDateTime1.Size = new System.Drawing.Size(126, 29);
            this.MetroDateTime1.Style = MetroFramework.MetroColorStyle.Red;
            this.MetroDateTime1.TabIndex = 25;
            this.MetroDateTime1.ValueChanged += new System.EventHandler(this.MetroDateTime1_ValueChanged);
            this.MetroDateTime1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MetroDateTime1_MouseDown);
            // 
            // KryptonLabel2
            // 
            this.KryptonLabel2.Location = new System.Drawing.Point(284, 237);
            this.KryptonLabel2.Name = "KryptonLabel2";
            this.KryptonLabel2.Size = new System.Drawing.Size(48, 22);
            this.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel2.TabIndex = 24;
            this.KryptonLabel2.Values.Text = "Status";
            // 
            // calldategen
            // 
            this.calldategen.CustomFormat = "yyyy-MMM-dd";
            this.calldategen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calldategen.Location = new System.Drawing.Point(11, 263);
            this.calldategen.MinimumSize = new System.Drawing.Size(0, 29);
            this.calldategen.Name = "calldategen";
            this.calldategen.Size = new System.Drawing.Size(126, 29);
            this.calldategen.Style = MetroFramework.MetroColorStyle.Red;
            this.calldategen.TabIndex = 3;
            this.calldategen.ValueChanged += new System.EventHandler(this.calldategen_ValueChanged);
            this.calldategen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calldategen_MouseDown);
            // 
            // forschedTXT
            // 
            // 
            // 
            // 
            this.forschedTXT.CustomButton.Image = null;
            this.forschedTXT.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.forschedTXT.CustomButton.Name = "";
            this.forschedTXT.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.forschedTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.forschedTXT.CustomButton.TabIndex = 1;
            this.forschedTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.forschedTXT.CustomButton.UseSelectable = true;
            this.forschedTXT.CustomButton.Visible = false;
            this.forschedTXT.DisplayIcon = true;
            this.forschedTXT.Lines = new string[0];
            this.forschedTXT.Location = new System.Drawing.Point(10, 410);
            this.forschedTXT.MaxLength = 32767;
            this.forschedTXT.Multiline = true;
            this.forschedTXT.Name = "forschedTXT";
            this.forschedTXT.PasswordChar = '\0';
            this.forschedTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.forschedTXT.SelectedText = "";
            this.forschedTXT.SelectionLength = 0;
            this.forschedTXT.SelectionStart = 0;
            this.forschedTXT.ShowClearButton = true;
            this.forschedTXT.Size = new System.Drawing.Size(322, 108);
            this.forschedTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.forschedTXT.TabIndex = 6;
            this.forschedTXT.UseCustomForeColor = true;
            this.forschedTXT.UseSelectable = true;
            this.forschedTXT.WaterMark = "For Resched";
            this.forschedTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.forschedTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // forcostingTXT
            // 
            // 
            // 
            // 
            this.forcostingTXT.CustomButton.Image = null;
            this.forcostingTXT.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.forcostingTXT.CustomButton.Name = "";
            this.forcostingTXT.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.forcostingTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.forcostingTXT.CustomButton.TabIndex = 1;
            this.forcostingTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.forcostingTXT.CustomButton.UseSelectable = true;
            this.forcostingTXT.CustomButton.Visible = false;
            this.forcostingTXT.DisplayIcon = true;
            this.forcostingTXT.Lines = new string[0];
            this.forcostingTXT.Location = new System.Drawing.Point(10, 524);
            this.forcostingTXT.MaxLength = 32767;
            this.forcostingTXT.Multiline = true;
            this.forcostingTXT.Name = "forcostingTXT";
            this.forcostingTXT.PasswordChar = '\0';
            this.forcostingTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.forcostingTXT.SelectedText = "";
            this.forcostingTXT.SelectionLength = 0;
            this.forcostingTXT.SelectionStart = 0;
            this.forcostingTXT.ShowClearButton = true;
            this.forcostingTXT.Size = new System.Drawing.Size(322, 108);
            this.forcostingTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.forcostingTXT.TabIndex = 7;
            this.forcostingTXT.UseCustomForeColor = true;
            this.forcostingTXT.UseSelectable = true;
            this.forcostingTXT.WaterMark = "For Costing";
            this.forcostingTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.forcostingTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // doneTXT
            // 
            this.doneTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.doneTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doneTXT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneTXT.FormattingEnabled = true;
            this.doneTXT.Location = new System.Drawing.Point(143, 263);
            this.doneTXT.Name = "doneTXT";
            this.doneTXT.Size = new System.Drawing.Size(189, 28);
            this.doneTXT.TabIndex = 4;
            // 
            // remarksTXT
            // 
            // 
            // 
            // 
            this.remarksTXT.CustomButton.Image = null;
            this.remarksTXT.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.remarksTXT.CustomButton.Name = "";
            this.remarksTXT.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.remarksTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.remarksTXT.CustomButton.TabIndex = 1;
            this.remarksTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.remarksTXT.CustomButton.UseSelectable = true;
            this.remarksTXT.CustomButton.Visible = false;
            this.remarksTXT.DisplayIcon = true;
            this.remarksTXT.Lines = new string[0];
            this.remarksTXT.Location = new System.Drawing.Point(10, 296);
            this.remarksTXT.MaxLength = 32767;
            this.remarksTXT.Multiline = true;
            this.remarksTXT.Name = "remarksTXT";
            this.remarksTXT.PasswordChar = '\0';
            this.remarksTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.remarksTXT.SelectedText = "";
            this.remarksTXT.SelectionLength = 0;
            this.remarksTXT.SelectionStart = 0;
            this.remarksTXT.ShowClearButton = true;
            this.remarksTXT.Size = new System.Drawing.Size(322, 108);
            this.remarksTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.remarksTXT.TabIndex = 5;
            this.remarksTXT.UseCustomForeColor = true;
            this.remarksTXT.UseSelectable = true;
            this.remarksTXT.WaterMark = "Needed Materials / Remarks";
            this.remarksTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.remarksTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // assignedpersonnelTXT
            // 
            // 
            // 
            // 
            this.assignedpersonnelTXT.CustomButton.Image = null;
            this.assignedpersonnelTXT.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.assignedpersonnelTXT.CustomButton.Name = "";
            this.assignedpersonnelTXT.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.assignedpersonnelTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.assignedpersonnelTXT.CustomButton.TabIndex = 1;
            this.assignedpersonnelTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.assignedpersonnelTXT.CustomButton.UseSelectable = true;
            this.assignedpersonnelTXT.CustomButton.Visible = false;
            this.assignedpersonnelTXT.DisplayIcon = true;
            this.assignedpersonnelTXT.Lines = new string[0];
            this.assignedpersonnelTXT.Location = new System.Drawing.Point(11, 64);
            this.assignedpersonnelTXT.MaxLength = 32767;
            this.assignedpersonnelTXT.Multiline = true;
            this.assignedpersonnelTXT.Name = "assignedpersonnelTXT";
            this.assignedpersonnelTXT.PasswordChar = '\0';
            this.assignedpersonnelTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.assignedpersonnelTXT.SelectedText = "";
            this.assignedpersonnelTXT.SelectionLength = 0;
            this.assignedpersonnelTXT.SelectionStart = 0;
            this.assignedpersonnelTXT.ShowClearButton = true;
            this.assignedpersonnelTXT.Size = new System.Drawing.Size(322, 53);
            this.assignedpersonnelTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.assignedpersonnelTXT.TabIndex = 1;
            this.assignedpersonnelTXT.UseCustomForeColor = true;
            this.assignedpersonnelTXT.UseSelectable = true;
            this.assignedpersonnelTXT.WaterMark = "Enter Assigned Personnel";
            this.assignedpersonnelTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.assignedpersonnelTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // assigneesreportTXT
            // 
            // 
            // 
            // 
            this.assigneesreportTXT.CustomButton.Image = null;
            this.assigneesreportTXT.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.assigneesreportTXT.CustomButton.Name = "";
            this.assigneesreportTXT.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.assigneesreportTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.assigneesreportTXT.CustomButton.TabIndex = 1;
            this.assigneesreportTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.assigneesreportTXT.CustomButton.UseSelectable = true;
            this.assigneesreportTXT.CustomButton.Visible = false;
            this.assigneesreportTXT.DisplayIcon = true;
            this.assigneesreportTXT.Lines = new string[0];
            this.assigneesreportTXT.Location = new System.Drawing.Point(10, 123);
            this.assigneesreportTXT.MaxLength = 32767;
            this.assigneesreportTXT.Multiline = true;
            this.assigneesreportTXT.Name = "assigneesreportTXT";
            this.assigneesreportTXT.PasswordChar = '\0';
            this.assigneesreportTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.assigneesreportTXT.SelectedText = "";
            this.assigneesreportTXT.SelectionLength = 0;
            this.assigneesreportTXT.SelectionStart = 0;
            this.assigneesreportTXT.ShowClearButton = true;
            this.assigneesreportTXT.Size = new System.Drawing.Size(322, 108);
            this.assigneesreportTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.assigneesreportTXT.TabIndex = 2;
            this.assigneesreportTXT.UseCustomForeColor = true;
            this.assigneesreportTXT.UseSelectable = true;
            this.assigneesreportTXT.WaterMark = "Enter Assignee\'s Report";
            this.assigneesreportTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.assigneesreportTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // forquotationTXT
            // 
            // 
            // 
            // 
            this.forquotationTXT.CustomButton.Image = null;
            this.forquotationTXT.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.forquotationTXT.CustomButton.Name = "";
            this.forquotationTXT.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.forquotationTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.forquotationTXT.CustomButton.TabIndex = 1;
            this.forquotationTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.forquotationTXT.CustomButton.UseSelectable = true;
            this.forquotationTXT.CustomButton.Visible = false;
            this.forquotationTXT.DisplayIcon = true;
            this.forquotationTXT.Lines = new string[0];
            this.forquotationTXT.Location = new System.Drawing.Point(10, 638);
            this.forquotationTXT.MaxLength = 32767;
            this.forquotationTXT.Multiline = true;
            this.forquotationTXT.Name = "forquotationTXT";
            this.forquotationTXT.PasswordChar = '\0';
            this.forquotationTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.forquotationTXT.SelectedText = "";
            this.forquotationTXT.SelectionLength = 0;
            this.forquotationTXT.SelectionStart = 0;
            this.forquotationTXT.ShowClearButton = true;
            this.forquotationTXT.Size = new System.Drawing.Size(322, 108);
            this.forquotationTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.forquotationTXT.TabIndex = 8;
            this.forquotationTXT.UseCustomForeColor = true;
            this.forquotationTXT.UseSelectable = true;
            this.forquotationTXT.WaterMark = "For Quotation / Additional";
            this.forquotationTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.forquotationTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // servicingdate
            // 
            // 
            // 
            // 
            this.servicingdate.CustomButton.Image = null;
            this.servicingdate.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.servicingdate.CustomButton.Name = "";
            this.servicingdate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.servicingdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.servicingdate.CustomButton.TabIndex = 1;
            this.servicingdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.servicingdate.CustomButton.UseSelectable = true;
            this.servicingdate.CustomButton.Visible = false;
            this.servicingdate.DisplayIcon = true;
            this.servicingdate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.servicingdate.Lines = new string[0];
            this.servicingdate.Location = new System.Drawing.Point(143, 31);
            this.servicingdate.MaxLength = 32767;
            this.servicingdate.Multiline = true;
            this.servicingdate.Name = "servicingdate";
            this.servicingdate.PasswordChar = '\0';
            this.servicingdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.servicingdate.SelectedText = "";
            this.servicingdate.SelectionLength = 0;
            this.servicingdate.SelectionStart = 0;
            this.servicingdate.ShowClearButton = true;
            this.servicingdate.Size = new System.Drawing.Size(189, 28);
            this.servicingdate.Style = MetroFramework.MetroColorStyle.Red;
            this.servicingdate.TabIndex = 28;
            this.servicingdate.UseCustomForeColor = true;
            this.servicingdate.UseSelectable = true;
            this.servicingdate.WaterMark = "Enter Servicing Date";
            this.servicingdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.servicingdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBTN.Image = ((System.Drawing.Image)(resources.GetObject("cancelBTN.Image")));
            this.cancelBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBTN.Location = new System.Drawing.Point(83, 459);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(83, 29);
            this.cancelBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.cancelBTN.TabIndex = 481;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseSelectable = true;
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Visible = false;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBTN.Image = ((System.Drawing.Image)(resources.GetObject("updateBTN.Image")));
            this.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBTN.Location = new System.Drawing.Point(261, 459);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(83, 29);
            this.updateBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.updateBTN.TabIndex = 480;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseSelectable = true;
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Visible = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBTN.Location = new System.Drawing.Point(261, 459);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(83, 29);
            this.addBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.addBTN.TabIndex = 14;
            this.addBTN.Text = "Add";
            this.addBTN.UseSelectable = true;
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // newSrevicingFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 582);
            this.Controls.Add(this.Panel1);
            this.MaximizeBox = false;
            this.Name = "newSrevicingFRM";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "newSrevicingFRM";
            this.Load += new System.EventHandler(this.newSrevicingFRM_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicingGRID)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView servicingGRID;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton deleteBTN;
        internal System.Windows.Forms.Panel Panel4;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel1;
        internal MetroFramework.Controls.MetroDateTime MetroDateTime1;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel2;
        internal MetroFramework.Controls.MetroDateTime calldategen;
        internal MetroFramework.Controls.MetroTextBox forschedTXT;
        internal MetroFramework.Controls.MetroTextBox forcostingTXT;
        internal System.Windows.Forms.ComboBox doneTXT;
        internal MetroFramework.Controls.MetroTextBox remarksTXT;
        internal MetroFramework.Controls.MetroTextBox assignedpersonnelTXT;
        internal MetroFramework.Controls.MetroTextBox assigneesreportTXT;
        internal MetroFramework.Controls.MetroTextBox forquotationTXT;
        internal MetroFramework.Controls.MetroTextBox servicingdate;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton cancelBTN;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton updateBTN;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton addBTN;
    }
}