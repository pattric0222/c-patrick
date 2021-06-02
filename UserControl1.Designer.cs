
namespace WinLastHomework
{
    partial class UserControl1
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
            this.Showuserordered = new System.Windows.Forms.DataGridView();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.stocktext = new System.Windows.Forms.TextBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizebox = new System.Windows.Forms.ComboBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.slippanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetext1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.picturebox2 = new System.Windows.Forms.PictureBox();
            this.sentslipbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Payordered = new System.Windows.Forms.Button();
            this.unpaidbtn = new System.Windows.Forms.Button();
            this.paidbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Showuserordered)).BeginInit();
            this.slippanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Showuserordered
            // 
            this.Showuserordered.AllowUserToAddRows = false;
            this.Showuserordered.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.Showuserordered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Showuserordered.Location = new System.Drawing.Point(342, 65);
            this.Showuserordered.Name = "Showuserordered";
            this.Showuserordered.ReadOnly = true;
            this.Showuserordered.Size = new System.Drawing.Size(434, 343);
            this.Showuserordered.TabIndex = 0;
            this.Showuserordered.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Showuserordered_CellClick);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.Aqua;
            this.cancelbtn.Location = new System.Drawing.Point(25, 332);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelbtn.Size = new System.Drawing.Size(131, 56);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel Order";
            this.cancelbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // stocktext
            // 
            this.stocktext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stocktext.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktext.Location = new System.Drawing.Point(25, 86);
            this.stocktext.Name = "stocktext";
            this.stocktext.ReadOnly = true;
            this.stocktext.Size = new System.Drawing.Size(302, 31);
            this.stocktext.TabIndex = 6;
            this.stocktext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stocktext.TextChanged += new System.EventHandler(this.stocktext_TextChanged);
            // 
            // pricetext
            // 
            this.pricetext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pricetext.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetext.Location = new System.Drawing.Point(25, 163);
            this.pricetext.Name = "pricetext";
            this.pricetext.ReadOnly = true;
            this.pricetext.Size = new System.Drawing.Size(182, 31);
            this.pricetext.TabIndex = 7;
            this.pricetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pricetext.TextChanged += new System.EventHandler(this.pricetext_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(20, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 29);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Product Name";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(20, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(20, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sizebox
            // 
            this.sizebox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sizebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizebox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizebox.FormattingEnabled = true;
            this.sizebox.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL",
            "4XL"});
            this.sizebox.Location = new System.Drawing.Point(25, 257);
            this.sizebox.Name = "sizebox";
            this.sizebox.Size = new System.Drawing.Size(77, 33);
            this.sizebox.TabIndex = 15;
            this.sizebox.SelectedIndexChanged += new System.EventHandler(this.sizebox_SelectedIndexChanged);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.Aqua;
            this.editbtn.Location = new System.Drawing.Point(178, 246);
            this.editbtn.Name = "editbtn";
            this.editbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editbtn.Size = new System.Drawing.Size(131, 56);
            this.editbtn.TabIndex = 16;
            this.editbtn.Text = "Edit Size";
            this.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // slippanel
            // 
            this.slippanel.Controls.Add(this.label4);
            this.slippanel.Controls.Add(this.pricetext1);
            this.slippanel.Controls.Add(this.label3);
            this.slippanel.Controls.Add(this.browse);
            this.slippanel.Controls.Add(this.picturebox2);
            this.slippanel.Controls.Add(this.sentslipbtn);
            this.slippanel.Controls.Add(this.pictureBox1);
            this.slippanel.Location = new System.Drawing.Point(3, 0);
            this.slippanel.Name = "slippanel";
            this.slippanel.Size = new System.Drawing.Size(783, 474);
            this.slippanel.TabIndex = 17;
            this.slippanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slippanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(22, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "this order price:";
            // 
            // pricetext1
            // 
            this.pricetext1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pricetext1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetext1.Location = new System.Drawing.Point(142, 387);
            this.pricetext1.Name = "pricetext1";
            this.pricetext1.ReadOnly = true;
            this.pricetext1.Size = new System.Drawing.Size(185, 26);
            this.pricetext1.TabIndex = 24;
            this.pricetext1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pls Browse Your Slip Below";
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.MidnightBlue;
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.Aqua;
            this.browse.Location = new System.Drawing.Point(424, 400);
            this.browse.Name = "browse";
            this.browse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.browse.Size = new System.Drawing.Size(131, 56);
            this.browse.TabIndex = 22;
            this.browse.Text = "Browse Slip";
            this.browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // picturebox2
            // 
            this.picturebox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox2.Location = new System.Drawing.Point(411, 29);
            this.picturebox2.Name = "picturebox2";
            this.picturebox2.Size = new System.Drawing.Size(327, 341);
            this.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox2.TabIndex = 21;
            this.picturebox2.TabStop = false;
            // 
            // sentslipbtn
            // 
            this.sentslipbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.sentslipbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sentslipbtn.FlatAppearance.BorderSize = 0;
            this.sentslipbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentslipbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentslipbtn.ForeColor = System.Drawing.Color.Aqua;
            this.sentslipbtn.Location = new System.Drawing.Point(595, 400);
            this.sentslipbtn.Name = "sentslipbtn";
            this.sentslipbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sentslipbtn.Size = new System.Drawing.Size(125, 56);
            this.sentslipbtn.TabIndex = 18;
            this.sentslipbtn.Text = "Sent Slip";
            this.sentslipbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sentslipbtn.UseVisualStyleBackColor = false;
            this.sentslipbtn.Click += new System.EventHandler(this.sentslipbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinLastHomework.Properties.Resources._186491764_4217429351655257_484220082493831667_n;
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Payordered
            // 
            this.Payordered.BackColor = System.Drawing.Color.MidnightBlue;
            this.Payordered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Payordered.FlatAppearance.BorderSize = 0;
            this.Payordered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payordered.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payordered.ForeColor = System.Drawing.Color.Aqua;
            this.Payordered.Location = new System.Drawing.Point(178, 332);
            this.Payordered.Name = "Payordered";
            this.Payordered.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Payordered.Size = new System.Drawing.Size(131, 56);
            this.Payordered.TabIndex = 18;
            this.Payordered.Text = "Pay Your Ordered";
            this.Payordered.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Payordered.UseVisualStyleBackColor = false;
            this.Payordered.Click += new System.EventHandler(this.Payordered_Click);
            // 
            // unpaidbtn
            // 
            this.unpaidbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.unpaidbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unpaidbtn.FlatAppearance.BorderSize = 0;
            this.unpaidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unpaidbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidbtn.ForeColor = System.Drawing.Color.Aqua;
            this.unpaidbtn.Location = new System.Drawing.Point(532, 32);
            this.unpaidbtn.Name = "unpaidbtn";
            this.unpaidbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.unpaidbtn.Size = new System.Drawing.Size(111, 27);
            this.unpaidbtn.TabIndex = 19;
            this.unpaidbtn.Text = "Unpaid";
            this.unpaidbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unpaidbtn.UseVisualStyleBackColor = false;
            this.unpaidbtn.Click += new System.EventHandler(this.unpaidbtn_Click);
            // 
            // paidbtn
            // 
            this.paidbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.paidbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paidbtn.FlatAppearance.BorderSize = 0;
            this.paidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidbtn.ForeColor = System.Drawing.Color.Aqua;
            this.paidbtn.Location = new System.Drawing.Point(665, 32);
            this.paidbtn.Name = "paidbtn";
            this.paidbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paidbtn.Size = new System.Drawing.Size(111, 27);
            this.paidbtn.TabIndex = 20;
            this.paidbtn.Text = "Paid";
            this.paidbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paidbtn.UseVisualStyleBackColor = false;
            this.paidbtn.Click += new System.EventHandler(this.paidbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinLastHomework.Properties.Resources.paid_stamp_2;
            this.pictureBox3.Location = new System.Drawing.Point(5, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(331, 446);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.paidbtn);
            this.Controls.Add(this.unpaidbtn);
            this.Controls.Add(this.slippanel);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.Payordered);
            this.Controls.Add(this.sizebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.stocktext);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Showuserordered);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(791, 477);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Showuserordered)).EndInit();
            this.slippanel.ResumeLayout(false);
            this.slippanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Showuserordered;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox stocktext;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sizebox;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Panel slippanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sentslipbtn;
        private System.Windows.Forms.Button Payordered;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.PictureBox picturebox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unpaidbtn;
        private System.Windows.Forms.Button paidbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetext1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
