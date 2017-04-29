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
    public partial class Profile : Form 
    {
        string uname;
        string mail;
        string addr;

        public Profile(string un, string email, string address)
        {
           
            InitializeComponent();
            uname = un;
            mail = email;
            addr = address;


        }
        public Profile()
        {

            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu M = new MainMenu(uname,mail,addr);
            M.Show();
                
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

        private void Profile_Load(object sender, EventArgs e)
        {
            label1.Text = uname;
            label3.Text = addr;
            label2.Text = mail;


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Details D = new Details(uname);
            D.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Details D = new Details(uname);
            D.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
    
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
