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
using System.Data.SqlTypes;

namespace Book_Store
{
    public partial class MainMenu : Form
    {
        
        string sname;
        string email;
        string adrss;
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(string s ,string e, string add)
        {
            InitializeComponent();
            sname = s;
            email = e;
            adrss = add;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label8.Text=""+sname+"";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Profile p = new Profile(sname,email,adrss);
                p.Show();
                this.Hide();
            
           
           

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(sname,email,adrss);
            p.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Details D = new Details(sname);
            D.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Details D = new Details(sname);
            D.Show();
            this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Details D = new Details(sname);
            D.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Details D = new Details(sname);
            D.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Details D = new Details(sname);
            D.Show();
            this.Hide();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         
           




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text;
            SqlConnection conn = new SqlConnection("Data Source=ANDREW-PC\\SQLEXPRESS;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT [name] , [author] , [price]
                             FROM [BookGeeks].[dbo].[book]
                               WHERE [name]='" + bookname + "'";

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string name = rdr[0].ToString();
                string author = rdr[1].ToString();
                string price = rdr[2].ToString();

                Details d = new Details(name, author, price);
                d.Show();

            }


            
        }
    }
}
