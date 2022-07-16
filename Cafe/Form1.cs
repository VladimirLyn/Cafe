using System.Data;
using System.Data.SqlClient;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\djdf1\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void button1_Click(object sender, EventArgs e)
        {

            /*  this.Hide();
              GuestOrder guest = new GuestOrder();
              guest.Show();*/

            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("¬ведите логин и пароль");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTbl where Uname='" + UnameTb.Text + "' and Upassword='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    GuestOrder guest = new GuestOrder();
                    guest.Show();
                }

                else
                {
                    MessageBox.Show("ќшибка логина или парол€");
                }
                Con.Close();
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder Uorder = new GuestOrder();
            Uorder.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}