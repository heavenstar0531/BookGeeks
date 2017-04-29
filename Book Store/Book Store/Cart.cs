using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store
{
    public partial class Cart : Form
    {
        public Cart(string N, string P)
        {

            InitializeComponent();
        }

        public Cart()
        {
            InitializeComponent();
        }
        public Cart(string Fname)
        {
            string name = Fname;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_MouseHover(object sender, System.EventArgs e)
        {
            pictureBox3.Visible = true;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;

        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;


        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkout C = new checkout();
            C.Show();
            this.Hide();

        }


    

    }
}
