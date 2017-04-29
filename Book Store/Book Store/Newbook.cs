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
    public partial class Newbook : Form
    {
        public Newbook()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Newbook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.dataSet1.books);
            // TODO: This line of code loads data into the 'dataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.users);

        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
