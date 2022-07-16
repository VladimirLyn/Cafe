using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\djdf1\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "")
            {
                MessageBox.Show("Введите НОМЕР товара, которого хотите удалить");
            }
            else
            {
                Con.Open();
                string query = "delete from ItemTbl where ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар удалён");
                Con.Close();
                populate();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder order = new UserOrder();
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersF user = new UsersF();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Con.Open();
                string query = "insert into ItemTbl values('" + ItemNumTb.Text + "','" + ItemNameTb.Text + "','" + CatCb.SelectedItem.ToString() + "'," +PriceTb.Text+")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар добавлен");
                Con.Close();
                populate();
            }
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || CatCb.Text == ""  || PriceTb.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Con.Open();
                string query = "update ItemTbl set ItemName ='" + ItemNameTb.Text + "',Itemcat ='" + CatCb.SelectedItem.ToString() +"',ItemPrice = '"+PriceTb.Text + "'where ItemNum ='" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар изменён");
                Con.Close();
                populate();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "")
            {
                MessageBox.Show("Введите НОМЕР товара, который хотите удалить");
            }
            else
            {
                Con.Open();
                string query = "delete from ItemTbl where ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар удалён");
                Con.Close();
                populate();
            }
        }
    }
}
