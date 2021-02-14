using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class BookmarksManagerForm : Form
    {
        public BookmarksManagerForm()
        {
            InitializeComponent();
        }

        private void bookmarksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookmarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookmarksDBDataSet1);

        }

        private void BookmarksManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookmarksDBDataSet1.Bookmarks' table. You can move, or remove it, as needed.
            this.bookmarksTableAdapter.Fill(this.bookmarksDBDataSet1.Bookmarks);

        }
    }
}
