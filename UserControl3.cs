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
    public partial class UserControl3 : UserControl
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dataproject;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public UserControl3()
        {
            InitializeComponent();
        }

        private void showOrdereddata(string getselect)
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

            Showalldata.DataSource = ds.Tables[0].DefaultView;
        }

        private void showStockdata(string getselect)
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

            Showallstock.DataSource = ds.Tables[0].DefaultView;
        }
        private void editbtn_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedRow = Showalldata.CurrentCell.RowIndex;
                int editId = Convert.ToInt32(Showalldata.Rows[selectedRow].Cells["ID"].Value);

                MySqlConnection conn = databaseConnection();

                string sql = "UPDATE ordered SET Name = '"+nametext.Text+ "',address = '" + addresstxt.Text + "',size = '" + sizetxt.Text + "',status = '"+statustxt.Text+"' WHERE ID = '" + editId + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Admin Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showOrdereddata($"SELECT * FROM ordered WHERE slip IS NOT NULL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Showalldata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
            Showalldata.CurrentRow.Selected = true;
            nametext.Text = Showalldata.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            addresstxt.Text = Showalldata.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
            sizetxt.Text = Showalldata.Rows[e.RowIndex].Cells["size"].FormattedValue.ToString();

            var data = (Byte[])(Showalldata.Rows[e.RowIndex].Cells["slip"].Value);
            var stream = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This ordered didn't sent the slip yet","No Slip",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            typetxt.SelectedIndex = 0;
            statustxt.SelectedIndex = 0;
            adminstockpanel.Hide();
            showOrdereddata($"SELECT * FROM ordered WHERE slip IS NOT NULL");
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = Showalldata.CurrentCell.RowIndex;
                int deleteId = Convert.ToInt32(Showalldata.Rows[selectedRow].Cells["ID"].Value);

                MySqlConnection conn = databaseConnection();

                string sql = "DELETE FROM ordered WHERE ID = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Deleted User Order", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showOrdereddata($"SELECT * FROM ordered WHERE slip IS NOT NULL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productdatabtn_Click(object sender, EventArgs e)
        {
            adminstockpanel.Show();
            this.adminstockpanel.BringToFront();
            showStockdata($"SELECT * FROM stock");
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {

                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlConnection conn = databaseConnection();

                string sql = "INSERT INTO stock(stockname, price, type, photo) VALUES('" + stocktxt.Text + "','" + pricetxt.Text + "','" + typetxt.SelectedItem + "',@img)";
                
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("@img", MySqlDbType.Blob);
                cmd.Parameters["@img"].Value = img;

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Admin added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStockdata($"SELECT * FROM stock");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editstockbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = Showallstock.CurrentCell.RowIndex;
                int editid = Convert.ToInt32(Showallstock.Rows[selectedRow].Cells["ID"].Value);


                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlConnection conn = databaseConnection();

                string sql = "UPDATE stock SET stockname = '" + stocktxt.Text + "', price = '" + pricetxt.Text + "',type = '" + typetxt.SelectedItem + "',photo = @img WHERE ID = '" + editid + "'";
               
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.Add("@img", MySqlDbType.Blob);
                cmd.Parameters["@img"].Value = img;

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Admin edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStockdata($"SELECT * FROM stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletestockbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = Showallstock.CurrentCell.RowIndex;
                int deleteId = Convert.ToInt32(Showallstock.Rows[selectedRow].Cells["ID"].Value);

                MySqlConnection conn = databaseConnection();

                string sql = "DELETE FROM stock WHERE ID = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Admin deleted stock item", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStockdata($"SELECT * FROM stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Showallstock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Showallstock.CurrentRow.Selected = true;
                stocktxt.Text = Showallstock.Rows[e.RowIndex].Cells["stockname"].FormattedValue.ToString();
                pricetxt.Text = Showallstock.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                typetxt.Text = Showallstock.Rows[e.RowIndex].Cells["type"].FormattedValue.ToString();

                var data = (Byte[])(Showallstock.Rows[e.RowIndex].Cells["photo"].Value);
                var stream = new MemoryStream(data);
                pictureBox2.Image = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderedbtn_Click(object sender, EventArgs e)
        {
            adminstockpanel.Hide();
        }

        private void adminstockpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
