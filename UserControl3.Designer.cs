
namespace WinLastHomework
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Showalldata = new System.Windows.Forms.DataGridView();
            this.editbtn = new System.Windows.Forms.Button();
            this.sizetxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productdatabtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Showallstock = new System.Windows.Forms.DataGridView();
            this.deletestockbtn = new System.Windows.Forms.Button();
            this.stocktxt = new System.Windows.Forms.TextBox();
            this.stocknametxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editstockbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.orderedbtn = new System.Windows.Forms.Button();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.browsebtn = new System.Windows.Forms.Button();
            this.addstockbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.adminstockpanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.statustxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Showalldata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showallstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.adminstockpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Showalldata
            // 
            this.Showalldata.AllowUserToAddRows = false;
            this.Showalldata.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.Showalldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Showalldata.Location = new System.Drawing.Point(3, 323);
            this.Showalldata.Name = "Showalldata";
            this.Showalldata.Size = new System.Drawing.Size(785, 151);
            this.Showalldata.TabIndex = 1;
            this.Showalldata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Showalldata_CellClick);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.Aqua;
            this.editbtn.Location = new System.Drawing.Point(217, 233);
            this.editbtn.Name = "editbtn";
            this.editbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editbtn.Size = new System.Drawing.Size(93, 56);
            this.editbtn.TabIndex = 26;
            this.editbtn.Text = "Edit";
            this.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // sizetxt
            // 
            this.sizetxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sizetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizetxt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizetxt.FormattingEnabled = true;
            this.sizetxt.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL",
            "4XL"});
            this.sizetxt.Location = new System.Drawing.Point(325, 42);
            this.sizetxt.Name = "sizetxt";
            this.sizetxt.Size = new System.Drawing.Size(77, 33);
            this.sizetxt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(320, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Address";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(8, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 29);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Name";
            // 
            // nametext
            // 
            this.nametext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nametext.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametext.Location = new System.Drawing.Point(13, 44);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(265, 31);
            this.nametext.TabIndex = 20;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Aqua;
            this.Deletebtn.Location = new System.Drawing.Point(316, 233);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deletebtn.Size = new System.Drawing.Size(94, 56);
            this.Deletebtn.TabIndex = 19;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addresstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.addresstxt.Location = new System.Drawing.Point(13, 113);
            this.addresstxt.Margin = new System.Windows.Forms.Padding(6);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(195, 176);
            this.addresstxt.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(416, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // productdatabtn
            // 
            this.productdatabtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.productdatabtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productdatabtn.FlatAppearance.BorderSize = 0;
            this.productdatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productdatabtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productdatabtn.ForeColor = System.Drawing.Color.Aqua;
            this.productdatabtn.Location = new System.Drawing.Point(677, 298);
            this.productdatabtn.Name = "productdatabtn";
            this.productdatabtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productdatabtn.Size = new System.Drawing.Size(111, 27);
            this.productdatabtn.TabIndex = 30;
            this.productdatabtn.Text = "Product Data";
            this.productdatabtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productdatabtn.UseVisualStyleBackColor = false;
            this.productdatabtn.Click += new System.EventHandler(this.productdatabtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(3, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ordered Database";
            // 
            // Showallstock
            // 
            this.Showallstock.AllowUserToAddRows = false;
            this.Showallstock.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.Showallstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Showallstock.Location = new System.Drawing.Point(4, 323);
            this.Showallstock.Name = "Showallstock";
            this.Showallstock.Size = new System.Drawing.Size(785, 151);
            this.Showallstock.TabIndex = 31;
            this.Showallstock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Showallstock_CellClick);
            // 
            // deletestockbtn
            // 
            this.deletestockbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.deletestockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletestockbtn.FlatAppearance.BorderSize = 0;
            this.deletestockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletestockbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletestockbtn.ForeColor = System.Drawing.Color.Aqua;
            this.deletestockbtn.Location = new System.Drawing.Point(230, 243);
            this.deletestockbtn.Name = "deletestockbtn";
            this.deletestockbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deletestockbtn.Size = new System.Drawing.Size(85, 56);
            this.deletestockbtn.TabIndex = 32;
            this.deletestockbtn.Text = "Delete";
            this.deletestockbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletestockbtn.UseVisualStyleBackColor = false;
            this.deletestockbtn.Click += new System.EventHandler(this.deletestockbtn_Click);
            // 
            // stocktxt
            // 
            this.stocktxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stocktxt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktxt.Location = new System.Drawing.Point(14, 68);
            this.stocktxt.Name = "stocktxt";
            this.stocktxt.Size = new System.Drawing.Size(302, 31);
            this.stocktxt.TabIndex = 33;
            // 
            // stocknametxt
            // 
            this.stocknametxt.AutoSize = true;
            this.stocknametxt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.stocknametxt.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocknametxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stocknametxt.Location = new System.Drawing.Point(9, 36);
            this.stocknametxt.Name = "stocknametxt";
            this.stocknametxt.Size = new System.Drawing.Size(140, 29);
            this.stocknametxt.TabIndex = 34;
            this.stocknametxt.Text = "Stock Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Price";
            // 
            // editstockbtn
            // 
            this.editstockbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.editstockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editstockbtn.FlatAppearance.BorderSize = 0;
            this.editstockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editstockbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editstockbtn.ForeColor = System.Drawing.Color.Aqua;
            this.editstockbtn.Location = new System.Drawing.Point(131, 243);
            this.editstockbtn.Name = "editstockbtn";
            this.editstockbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editstockbtn.Size = new System.Drawing.Size(93, 56);
            this.editstockbtn.TabIndex = 38;
            this.editstockbtn.Text = "Edit";
            this.editstockbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editstockbtn.UseVisualStyleBackColor = false;
            this.editstockbtn.Click += new System.EventHandler(this.editstockbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(335, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // orderedbtn
            // 
            this.orderedbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.orderedbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderedbtn.FlatAppearance.BorderSize = 0;
            this.orderedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderedbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedbtn.ForeColor = System.Drawing.Color.Aqua;
            this.orderedbtn.Location = new System.Drawing.Point(678, 298);
            this.orderedbtn.Name = "orderedbtn";
            this.orderedbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderedbtn.Size = new System.Drawing.Size(111, 27);
            this.orderedbtn.TabIndex = 41;
            this.orderedbtn.Text = "Ordered Data";
            this.orderedbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderedbtn.UseVisualStyleBackColor = false;
            this.orderedbtn.Click += new System.EventHandler(this.orderedbtn_Click);
            // 
            // pricetxt
            // 
            this.pricetxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pricetxt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(14, 134);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(302, 31);
            this.pricetxt.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(3, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Stock Database";
            // 
            // browsebtn
            // 
            this.browsebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.browsebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browsebtn.FlatAppearance.BorderSize = 0;
            this.browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsebtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebtn.ForeColor = System.Drawing.Color.Aqua;
            this.browsebtn.Location = new System.Drawing.Point(335, 255);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.browsebtn.Size = new System.Drawing.Size(131, 37);
            this.browsebtn.TabIndex = 45;
            this.browsebtn.Text = "Browse Picture";
            this.browsebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browsebtn.UseVisualStyleBackColor = false;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // addstockbtn
            // 
            this.addstockbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.addstockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addstockbtn.FlatAppearance.BorderSize = 0;
            this.addstockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstockbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstockbtn.ForeColor = System.Drawing.Color.Aqua;
            this.addstockbtn.Location = new System.Drawing.Point(14, 243);
            this.addstockbtn.Name = "addstockbtn";
            this.addstockbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addstockbtn.Size = new System.Drawing.Size(111, 56);
            this.addstockbtn.TabIndex = 46;
            this.addstockbtn.Text = "Add";
            this.addstockbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addstockbtn.UseVisualStyleBackColor = false;
            this.addstockbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Type";
            // 
            // typetxt
            // 
            this.typetxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.typetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typetxt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Clothes",
            "Souvenir"});
            this.typetxt.Location = new System.Drawing.Point(14, 200);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(177, 33);
            this.typetxt.TabIndex = 48;
            // 
            // adminstockpanel
            // 
            this.adminstockpanel.Controls.Add(this.typetxt);
            this.adminstockpanel.Controls.Add(this.label3);
            this.adminstockpanel.Controls.Add(this.addstockbtn);
            this.adminstockpanel.Controls.Add(this.browsebtn);
            this.adminstockpanel.Controls.Add(this.label6);
            this.adminstockpanel.Controls.Add(this.pricetxt);
            this.adminstockpanel.Controls.Add(this.orderedbtn);
            this.adminstockpanel.Controls.Add(this.pictureBox2);
            this.adminstockpanel.Controls.Add(this.editstockbtn);
            this.adminstockpanel.Controls.Add(this.label4);
            this.adminstockpanel.Controls.Add(this.stocknametxt);
            this.adminstockpanel.Controls.Add(this.stocktxt);
            this.adminstockpanel.Controls.Add(this.deletestockbtn);
            this.adminstockpanel.Controls.Add(this.Showallstock);
            this.adminstockpanel.Location = new System.Drawing.Point(0, 0);
            this.adminstockpanel.Name = "adminstockpanel";
            this.adminstockpanel.Size = new System.Drawing.Size(788, 477);
            this.adminstockpanel.TabIndex = 31;
            this.adminstockpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminstockpanel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(212, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Status";
            // 
            // statustxt
            // 
            this.statustxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statustxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statustxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statustxt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustxt.FormattingEnabled = true;
            this.statustxt.Items.AddRange(new object[] {
            "Not sent yet",
            "Sent"});
            this.statustxt.Location = new System.Drawing.Point(217, 113);
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(185, 33);
            this.statustxt.TabIndex = 25;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adminstockpanel);
            this.Controls.Add(this.productdatabtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sizetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Showalldata);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(791, 477);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Showalldata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showallstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.adminstockpanel.ResumeLayout(false);
            this.adminstockpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Showalldata;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.ComboBox sizetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button productdatabtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Showallstock;
        private System.Windows.Forms.Button deletestockbtn;
        private System.Windows.Forms.TextBox stocktxt;
        private System.Windows.Forms.Label stocknametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editstockbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button orderedbtn;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Button addstockbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Panel adminstockpanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox statustxt;
    }
}
