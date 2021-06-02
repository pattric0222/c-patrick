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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void showEquipment(string sqlsent)
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
        private void Form2_Load(object sender, EventArgs e)
        {
            showEquipment("SELECT * FROM equipment");
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dataproject;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO equipment(name, amount) VALUES('" + equiptext.Text + "','" + amounttext.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                showEquipment("SELECT * FROM equipment");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
                int selectedRow = dataoutput.CurrentCell.RowIndex;
                int deleteId = Convert.ToInt32(dataoutput.Rows[selectedRow].Cells["id"].Value);

                MySqlConnection conn = databaseConnection();

                string sql = "DELETE FROM equipment WHERE id = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                    showEquipment("SELECT * FROM equipment");
                }
        }

        private void editbtn_Click(object sender, EventArgs e)
          {

                int selectedRow = dataoutput.CurrentCell.RowIndex;
                int editId = Convert.ToInt32(dataoutput.Rows[selectedRow].Cells["id"].Value);

                MySqlConnection conn = databaseConnection();

                string sql = "UPDATE equipment SET name = '" + equiptext.Text + "',amount = '" + amounttext.Text + "'WHERE id = '" + editId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                    showEquipment("SELECT * FROM equipment");
                }

            }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void amounttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาป้อนเฉพาะตัวเลขเท่านั้น","Error นาจาาาา !!!");
                e.Handled = true;
            }
        }

        private void dataoutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataoutput.CurrentRow.Selected = true;
            equiptext.Text = dataoutput.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            amounttext.Text = dataoutput.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
        }
    }
    }

