using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace WinLastHomework
{
    public partial class Dashboardform : Form
    {
        string status;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dataproject;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
 (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse

  );
        public Dashboardform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Dashboardform_Load(object sender, EventArgs e)
        {
            textusername.Text = Program.Username;
            pnlnav.Hide();
            string Username = Program.Username;
            string status;

            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT status FROM userdata WHERE Username = \"{Username}\"";
            MySqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                status = da.GetValue(0).ToString();
                if (status != "Admin")
                {
                    adminbtn.Hide();
                }
            }
        }

        private void mainbtn_Click(object sender, EventArgs e)
        {
            pnlnav.Height = mainbtn.Height;
            pnlnav.Top = mainbtn.Top;
            pnlnav.Left = mainbtn.Left;
            pnlnav.Show();

            lblTitle.Text = "Main Menu";

            this.PnlFormLoader.Controls.Clear();
            Mainmenuform FrmMainmenu = new Mainmenuform() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Program.Username = textusername.Text;
            FrmMainmenu.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmMainmenu);
            FrmMainmenu.Show();
            mainbtn.BackColor = Color.Gray;

        }

        private void contactbtn_Click(object sender, EventArgs e)
        {
            mainbtn.BackColor = Color.MidnightBlue;
            pnlnav.Height = contactbtn.Height;
            pnlnav.Top = contactbtn.Top;
            pnlnav.Left = contactbtn.Left;
            pnlnav.Show();
            contactbtn.BackColor = Color.Gray;

            lblTitle.Text = "Contact";

            PnlFormLoader.Controls.Clear();
            PnlFormLoader.Controls.Add(new UserControl2());
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            mainbtn.BackColor = Color.MidnightBlue;
            pnlnav.Height = logoutbtn.Height;
            pnlnav.Top = logoutbtn.Top;
            pnlnav.Left = logoutbtn.Left;
            pnlnav.Show();
            logoutbtn.BackColor = Color.Gray;

            DialogResult dr = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes) {
                Login a = new Login();
                this.Hide();
                a.Show();
            }
        }

        private void ordered_Click(object sender, EventArgs e)
        {
            mainbtn.BackColor = Color.MidnightBlue;
            pnlnav.Hide();
            orderedbtnn.BackColor = Color.Gray;
            lblTitle.Text = "Ordered History";

            PnlFormLoader.Controls.Clear();
            PnlFormLoader.Controls.Add(new UserControl1(textusername.Text));

        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
                    mainbtn.BackColor = Color.MidnightBlue;
                    pnlnav.Hide();
                    adminbtn.BackColor = Color.Gray;
                    lblTitle.Text = "Admin Mode";

                    Program.Username = textusername.Text;
                    PnlFormLoader.Controls.Clear();
                    PnlFormLoader.Controls.Add(new UserControl3());
            
        }

        private void mainbtn_Leave(object sender, EventArgs e)
        {
            mainbtn.BackColor = Color.MidnightBlue;
        }

        private void contactbtn_Leave(object sender, EventArgs e)
        {
            contactbtn.BackColor = Color.MidnightBlue;
        }

        private void logoutbtn_Leave(object sender, EventArgs e)
        {
            logoutbtn.BackColor = Color.MidnightBlue;
        }


        private void orderedbtnn_Leave(object sender, EventArgs e)
        {
            orderedbtnn.BackColor = Color.MidnightBlue;
        }

        private void adminbtn_Leave(object sender, EventArgs e)
        {
            adminbtn.BackColor = Color.MidnightBlue;
        }
    }
}
