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
    public partial class Login : Form

    {

        public string Fname;
        public string address;
        public string email;
        public Login()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=ANDREW-PC\\SQLEXPRESS;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT [fname], [email], [addr]
                             FROM [BookGeeks].[dbo].[users]
                               WHERE [Uname]='"+username.Text+"'AND [password]='"+TextBox2.Text+"'";

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {

                Fname = rdr[0].ToString();
                email = rdr[1].ToString();
                address = rdr[2].ToString();
                this.Hide();
                MainMenu m = new MainMenu(Fname,email,address);
                Details d = new Details(Fname);
                m.Show();         
                
                

            }

            else
                MessageBox.Show("Incorrect username or password,Please Try again!");
            TextBox2.Clear();
            
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


    }
}
