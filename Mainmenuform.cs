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
    public partial class Mainmenuform : Form
    {
        string phonenumber;
        public Mainmenuform()
        {
            InitializeComponent();  
        }

        private void PnlFormLoader_Load(object sender, EventArgs e)
        {
            amounttxt.SelectedIndex = 0;
            Sizebox.Hide();
            sizetxt.Hide();
        }


        private void showEquipment(string sqlsent)
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                //datatable dt = new datatable();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = sqlsent;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                conn.Close();

                dataoutput.DataSource = ds.Tables[0].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getnumber()
        {
            MySqlConnection con = databaseConnection();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT phone FROM userdata WHERE username = \"{Program.Username}\"";

            MySqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                phonenumber = da.GetValue(0).ToString();
            }
            

        }

            private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dataproject;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }

        private void dataoutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataoutput.CurrentRow.Selected = true;
                dataoutput.Rows[e.RowIndex].Cells["stockname"].FormattedValue.ToString();
                int id = Convert.ToInt32(dataoutput.Rows[e.RowIndex].Cells["ID"].FormattedValue);
                int price = Convert.ToInt32(dataoutput.Rows[e.RowIndex].Cells["price"].FormattedValue);
                
                var data = (Byte[])(dataoutput.Rows[e.RowIndex].Cells["photo"].Value);
                var stream = new MemoryStream(data);
                PictureBox.Image = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"HERE IS EMPTY !!!");
            }

        }

        private void orderbtn_Click_1(object sender, EventArgs e)
        {
            int selectedRow = dataoutput.CurrentCell.RowIndex;
            int price = Convert.ToInt32(dataoutput.Rows[selectedRow].Cells["price"].Value);
            var stockname = dataoutput.Rows[selectedRow].Cells["stockname"].Value;
            var type = dataoutput.Rows[selectedRow].Cells["type"].Value;
            int amount = int.Parse(amounttxt.SelectedItem.ToString());
            getnumber();

            DialogResult dr = MessageBox.Show("Are you sure to order this product", "ASKING", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO ordered(username, stockname, price, Name, address, phonenum,size, type) VALUES('" + Program.Username + "','" + stockname + "','" + price*amount + "','" + txtName.Text + "','" + txtaddress.Text + "','" + phonenumber + "','" + Sizebox.SelectedItem + "','" + type + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("Success", "Ordered");
                }

            }

        }

        private void souvenirbtn_Click(object sender, EventArgs e)
        {
            showEquipment("SELECT * FROM stock WHERE type = \"Souvenir\"");
            Sizebox.Hide();
            sizetxt.Hide();
            Sizebox.SelectedIndex = -1;
        }

        private void clothesbtn_Click(object sender, EventArgs e)
        {
            showEquipment("SELECT * FROM stock WHERE type = \"Clothes\"");
            Sizebox.Show();
            sizetxt.Show();
            Sizebox.SelectedIndex = 0;
        }
    }
}
