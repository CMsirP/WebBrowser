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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.historyDBDataSet);

        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'historyDBDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.historyDBDataSet.History);

        }
    }
}
