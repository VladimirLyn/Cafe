using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe
{
    public partial class UsersF : Form
    {
        public UsersF()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\djdf1\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            Con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);  
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];  
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm item = new ItemsForm();
            item.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uorder = new UserOrder();
            uorder.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UsersTbl values('" + UnameTb.Text + "','" + UphoneTb.Text + "','" + UpasswordTb.Text + "')";
            SqlCommand cmd = new SqlCommand (query,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Пользователь создан");
            Con.Close();
            populate();
        }

        private void UsersF_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "")
            {
                MessageBox.Show("Введите ИМЯ пользователя, которого хотите удалить");
            }
            else
            {
                Con.Open();
                string query = "delete from UsersTbl where Uname = '"+UnameTb.Text+"'";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Пользователь удалён");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == ""||UphoneTb.Text == "" ||UpasswordTb.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Con.Open();
                string query = "update UsersTbl set Uphone='" + UphoneTb.Text + "',Upassword='" + UpasswordTb.Text + "'where Uname ='"+UnameTb.Text+"'";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Пользователь изменён");
                Con.Close();
                populate();
            }

        }
    }
}
