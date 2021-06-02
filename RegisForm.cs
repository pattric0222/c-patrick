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
    public partial class RegisForm : Form
    {
        public RegisForm()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dataproject;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Show();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmpass.Text == "")
            {
                MessageBox.Show("Some Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirmpass.Text)
            {
                if (txtPhone.Text.Length != 10)
                {
                    MessageBox.Show("Please Entry 10 Degits of PhoneNumber", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else
                {
                    try
                    {
                        MySqlConnection conn = databaseConnection();

                        string sql = "INSERT INTO userdata(username, password, phone) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtPhone.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (rows > 0)
                        {
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtConfirmpass.Text = "";
                            txtPhone.Text = "";
                            MessageBox.Show("Register Complete", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login a = new Login();
                            this.Hide();
                            a.Show();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("This UserName Already Taken", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmpass.Text = "";
                txtPassword.Focus();
            }
            
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmpass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmpass.PasswordChar = '*';
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmpass.Text = "";
            txtPhone.Text = "";
            txtUsername.Focus();
            checkbxShowPass.Checked = false;
        }

        private void RegisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
