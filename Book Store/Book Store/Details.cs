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
    public partial class Details : Form
    {

        string pname;
        string N;
        string A;
        string abc;
        
               public Details()
        {

            InitializeComponent();

        }

        public Details(string sname)
        {
            pname = sname;
            InitializeComponent();
        }
        public Details(string name, string auth, string price)
        {
            InitializeComponent();
            
           N = name;
            A= auth;
            abc= price;
            label1.Text = N;
            label2.Text = A;
            label3.Text = abc;
        }
        
        
        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Item added to your wishlist");
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Item added to cart, Checkout now? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                checkout C = new checkout(abc);
                C.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("your item was added to your cart");
            }
        }

       
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookName_Click(object sender, EventArgs e)
        {

        }

        private void Author_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
