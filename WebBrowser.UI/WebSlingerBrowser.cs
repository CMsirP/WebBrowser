using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Windows;

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
            MessageBox.Show("You are using Web Slinger, a browser designed by Christopher Pinto. \r\n" +
                "Contact: cmp0106@auburn.edu");
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserHousing browserHousing = new BrowserHousing();
            browserHousing.Name = "browserHousing1";
            var tabPage = new TabPage("New Tab");
            tabPage.Controls.Add(browserHousing);
            browserHousing.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage;

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

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryItemManager.DeleteAllHistoryItems();
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_SizeChanged(object sender, EventArgs e)
        {
        
        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var bh = tabControl1.SelectedTab.Controls.Cast<BrowserHousing>() //Finds specified control type, passes to var bh
                                .FirstOrDefault(x => x is BrowserHousing);
            bh.webBrowser1.ShowPrintPreviewDialog();
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Controls.ContainsKey("browserHousing1"))
            {
                BrowserHousing bh = (BrowserHousing)tabControl1.SelectedTab.Controls["browserHousing1"];
                bh.webBrowser1.ShowSaveAsDialog();
            }
        }

    }
}
