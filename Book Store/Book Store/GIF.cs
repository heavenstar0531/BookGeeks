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
    public partial class GIF : Form
    {
        public GIF()
        {
            InitializeComponent();
        }
        Timer t = new Timer();

        private void GIF_Load(object sender, EventArgs e)
        {
            t.Interval = 10000;
            t.Tick += new EventHandler(OnTimerTicked);
            t.Start();
        }

        public void OnTimerTicked(object sender, EventArgs e)
        {
            t.Stop();
            Login formdois = new Login();
            this.Hide();
            formdois.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
