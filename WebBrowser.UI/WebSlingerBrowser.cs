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
    public partial class WebSlingerBrowser : Form
    {
        public WebSlingerBrowser()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are using WebSlinger, a browser designed by Christopher Pinto. \r\n" +
                "Contact: cmp0106@auburn.edu");
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserHousing myBH = new BrowserHousing();
            var tabPage = new TabPage("New Tab");
            tabPage.Controls.Add(myBH);
            tabControl1.TabPages.Add(tabPage);

        }

        private void browserHousing1_Load(object sender, EventArgs e)
        {
            
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
            }
            catch
            {
                ArgumentNullException argumentNullException;
            }
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagerForm manager = new HistoryManagerForm();
            manager.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarksManagerForm manager = new BookmarksManagerForm();
            manager.ShowDialog();
        }
    }
}
