using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinLastHomework
{
    public partial class Login : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dataproject;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM userdata WHERE username ='"+txtUsername.Text+"'AND password ='"+txtPassword.Text+"'";

            MySqlDataReader row = cmd.ExecuteReader();
            if(row.Read())
            {
                MessageBox.Show("Login Success","Welldone" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboardform a = new Dashboardform();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้งาน หรือ รหัสผ่านไม่ถูกต้อง");
            }
            conn.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisForm a = new RegisForm();
            this.Hide();
            a.Show();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
            checkbxShowPass.Checked = false;

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
