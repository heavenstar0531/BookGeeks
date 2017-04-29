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
    public partial class checkout : Form
    {


        double total;

        bool done = false;
        public checkout(string p)
        {
            InitializeComponent();

            double price = Convert.ToDouble(p);
            total += price;
            label5.Text = total.ToString();
        }
        public checkout()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.BackColor = Color.White;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.BackColor = Color.DarkGray;
            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Visa")
            {
                textBox2.Visible = true;
                label3.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                label3.Visible = false;
            }

        }

        private void checkout_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Cash On Delivery";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (done == false)
            {
                if (MessageBox.Show("Your order is not done yet, are you sure you want to exit? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Hide();

                }
            }
            else if (done == true)
                this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true && textBox1.Text == "")
            {

                MessageBox.Show("Please enter new address ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if (textBox2.Visible == true && textBox2.Text.Length < 5)
                {
                    MessageBox.Show("Visa is not vaild!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {



                    done = true;
                    MessageBox.Show("your order has been done");
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Cart c = new Cart();
            c.Show();
            this.Hide();
        }

    }
}