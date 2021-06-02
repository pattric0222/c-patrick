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
using System.IO;

namespace WinLastHomework
{
    public partial class UserControl1 : UserControl
    {
        string Username;

        public UserControl1(string Str_Value)
        {
            InitializeComponent();
            Username = Str_Value;
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dataproject;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        private void showEquipment(string getselect)
        {

            MySqlConnection conn = databaseConnection();
            //datatable dt = new datatable();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;


            cmd = conn.CreateCommand();
            cmd.CommandText = getselect;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            Showuserordered.DataSource = ds.Tables[0].DefaultView;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            sizebox.SelectedIndex = 0;
            pictureBox3.Hide();
            slippanel.Hide();
            showEquipment($"SELECT Name,stockname,price,size,type,ID FROM ordered WHERE username = \"{Username}\" AND slip IS NULL");
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = Showuserordered.CurrentCell.RowIndex;
                int deleteId = Convert.ToInt32(Showuserordered.Rows[selectedRow].Cells["ID"].Value);

                MySqlConnection conn = databaseConnection();

                string sql = "DELETE FROM ordered WHERE ID = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Deleted Your Order", "INFO", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    showEquipment($"SELECT Name,stockname,price,size,type,ID FROM ordered WHERE username = \"{Username}\" AND slip IS NULL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Showuserordered_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Showuserordered.CurrentRow.Selected = true;
            stocktext.Text = Showuserordered.Rows[e.RowIndex].Cells["stockname"].FormattedValue.ToString();
            pricetext.Text = Showuserordered.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            sizebox.Text = Showuserordered.Rows[e.RowIndex].Cells["size"].FormattedValue.ToString();
            pricetext1.Text = Showuserordered.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            int selectedRow = Showuserordered.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(Showuserordered.Rows[selectedRow].Cells["ID"].Value);
            string typecheck = Convert.ToString(Showuserordered.Rows[selectedRow].Cells["type"].Value);
            
            if (typecheck == "Souvenir")
            {
                MessageBox.Show("Cannot edit souvenir size", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MySqlConnection conn = databaseConnection();

                    string sql = "UPDATE ordered SET size = '" + sizebox.Text + "' WHERE ID = '" + editId + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Edited Your Size", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showEquipment($"SELECT Name,stockname,price,size,type,ID FROM ordered WHERE username = \"{Username}\" AND slip IS NULL");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Payordered_Click(object sender, EventArgs e)
        {
            slippanel.Show();
            this.slippanel.BringToFront();
        }

        private void sentslipbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = Showuserordered.CurrentCell.RowIndex;
                int sentslipId = Convert.ToInt32(Showuserordered.Rows[selectedRow].Cells["ID"].Value);
                MemoryStream ms = new MemoryStream();
                picturebox2.Image.Save(ms, picturebox2.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlConnection conn = databaseConnection();

                string sql = "UPDATE ordered SET slip = @img WHERE ID = '" + sentslipId + "'";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.Add("@img", MySqlDbType.Blob);
                cmd.Parameters["@img"].Value = img;

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Sent your Slip", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    slippanel.Hide();
                    this.slippanel.SendToBack();
                    showEquipment($"SELECT Name,stockname,price,size,type,ID FROM ordered WHERE username = \"{Username}\" AND slip IS NULL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                picturebox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void paidbtn_Click(object sender, EventArgs e)
        {
            showEquipment($"SELECT Name,stockname,price,size,type,ID FROM ordered WHERE username = \"{Username}\" AND slip IS NOT NULL");
            pictureBox3.Show();
            stocktext.Hide();
            pricetext.Hide();
            sizebox.Hide();
            lblTitle.Hide();
            label1.Hide();
            label2.Hide();
            editbtn.Hide();
            cancelbtn.Hide();
            Payordered.Hide();
        }

        private void unpaidbtn_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            stocktext.Show();
            pricetext.Show();
            sizebox.Show();
            lblTitle.Show();
            label1.Show();
            label2.Show();
            editbtn.Show();
            cancelbtn.Show();
            Payordered.Show();
            showEquipment($"SELECT Name,stockname,price,size,type,ID FROM ordered WHERE username = \"{Username}\" AND slip IS NULL");
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void slippanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sizebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pricetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void stocktext_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
