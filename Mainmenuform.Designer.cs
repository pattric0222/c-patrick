
namespace WinLastHomework
{
    partial class Mainmenuform
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
            this.orderbtn = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.dataoutput = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.Sizebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizetxt = new System.Windows.Forms.Label();
            this.souvenirbtn = new System.Windows.Forms.Button();
            this.clothesbtn = new System.Windows.Forms.Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.amounttxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataoutput)).BeginInit();
            this.SuspendLayout();
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.orderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderbtn.FlatAppearance.BorderSize = 0;
            this.orderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.ForeColor = System.Drawing.Color.Aqua;
            this.orderbtn.Location = new System.Drawing.Point(672, 391);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderbtn.Size = new System.Drawing.Size(103, 55);
            this.orderbtn.TabIndex = 4;
            this.orderbtn.Text = "Order";
            this.orderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click_1);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::WinLastHomework.Properties.Resources.money_bag;
            this.PictureBox.Location = new System.Drawing.Point(372, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(416, 365);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            // 
            // dataoutput
            // 
            this.dataoutput.AllowUserToAddRows = false;
            this.dataoutput.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataoutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataoutput.Location = new System.Drawing.Point(9, 24);
            this.dataoutput.Name = "dataoutput";
            this.dataoutput.ReadOnly = true;
            this.dataoutput.Size = new System.Drawing.Size(354, 277);
            this.dataoutput.TabIndex = 6;
            this.dataoutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataoutput_CellClick);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtName.Location = new System.Drawing.Point(28, 328);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 35);
            this.txtName.TabIndex = 12;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.LightGray;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtaddress.Location = new System.Drawing.Point(28, 393);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(335, 54);
            this.txtaddress.TabIndex = 13;
            // 
            // Sizebox
            // 
            this.Sizebox.BackColor = System.Drawing.Color.White;
            this.Sizebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sizebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sizebox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sizebox.FormattingEnabled = true;
            this.Sizebox.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL",
            "4XL"});
            this.Sizebox.Location = new System.Drawing.Point(563, 401);
            this.Sizebox.Name = "Sizebox";
            this.Sizebox.Size = new System.Drawing.Size(63, 33);
            this.Sizebox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(0, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Your Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(0, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address :";
            // 
            // sizetxt
            // 
            this.sizetxt.AutoSize = true;
            this.sizetxt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizetxt.ForeColor = System.Drawing.Color.Aqua;
            this.sizetxt.Location = new System.Drawing.Point(512, 409);
            this.sizetxt.Name = "sizetxt";
            this.sizetxt.Size = new System.Drawing.Size(43, 18);
            this.sizetxt.TabIndex = 17;
            this.sizetxt.Text = "Size :";
            // 
            // souvenirbtn
            // 
            this.souvenirbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.souvenirbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.souvenirbtn.FlatAppearance.BorderSize = 0;
            this.souvenirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.souvenirbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.souvenirbtn.ForeColor = System.Drawing.Color.Aqua;
            this.souvenirbtn.Location = new System.Drawing.Point(236, 0);
            this.souvenirbtn.Name = "souvenirbtn";
            this.souvenirbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.souvenirbtn.Size = new System.Drawing.Size(127, 26);
            this.souvenirbtn.TabIndex = 18;
            this.souvenirbtn.Text = "Souvenir";
            this.souvenirbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.souvenirbtn.UseVisualStyleBackColor = false;
            this.souvenirbtn.Click += new System.EventHandler(this.souvenirbtn_Click);
            // 
            // clothesbtn
            // 
            this.clothesbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.clothesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clothesbtn.FlatAppearance.BorderSize = 0;
            this.clothesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clothesbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothesbtn.ForeColor = System.Drawing.Color.Aqua;
            this.clothesbtn.Location = new System.Drawing.Point(112, 0);
            this.clothesbtn.Name = "clothesbtn";
            this.clothesbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clothesbtn.Size = new System.Drawing.Size(127, 26);
            this.clothesbtn.TabIndex = 19;
            this.clothesbtn.Text = "Clothes";
            this.clothesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clothesbtn.UseVisualStyleBackColor = false;
            this.clothesbtn.Click += new System.EventHandler(this.clothesbtn_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 450;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // amounttxt
            // 
            this.amounttxt.BackColor = System.Drawing.Color.White;
            this.amounttxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amounttxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amounttxt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttxt.FormattingEnabled = true;
            this.amounttxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.amounttxt.Location = new System.Drawing.Point(443, 401);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(63, 33);
            this.amounttxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(369, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amount:";
            // 
            // Mainmenuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.clothesbtn);
            this.Controls.Add(this.souvenirbtn);
            this.Controls.Add(this.sizetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sizebox);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataoutput);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.orderbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainmenuform";
            this.Text = "Mainmenuform";
            this.Load += new System.EventHandler(this.PnlFormLoader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataoutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.DataGridView dataoutput;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ComboBox Sizebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sizetxt;
        private System.Windows.Forms.Button souvenirbtn;
        private System.Windows.Forms.Button clothesbtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox amounttxt;
    }
}