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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
           

        }
        string gender = "Null";

        private void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
                gender = "M";
            if (RadioButton2.Checked == true)
                gender = "F";

            SqlConnection con = new SqlConnection("Data Source=ANDREW-PC\\SQLEXPRESS;Integrated Security=True");
            con.Open();
              SqlCommand cmd = con.CreateCommand();
              if (textBox6.Text == "" || TextBox5.Text == "" || TextBox4.Text == "" || TextBox3.Text == "" || TextBox2.Text == "" || TextBox1.Text == "")
              {
                  MessageBox.Show("Some feilds are empty");

              }
              else
              {
                  cmd.CommandText = @"INSERT INTO [BookGeeks].[dbo].[users]
           ([Fname]
           ,[Lname]
           ,[Uname]
           ,[email]
           ,[addr]
           ,[gender]
           ,[password])
            VALUES ('" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox1.Text + "','" + TextBox3.Text + "','" + textBox6.Text + "','" + gender + "','" + TextBox2.Text + "')";

                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Signup Success!");
                  MainMenu M = new MainMenu(TextBox4.Text, TextBox3.Text, textBox6.Text);
                  M.Show();
                  this.Hide();

              }

            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
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

    }
}
