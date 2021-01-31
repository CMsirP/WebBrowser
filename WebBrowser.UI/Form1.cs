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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtBoxAddress.Text);
        }

        private void KeyDownTxtb(object sender, KeyEventArgs k)
        {
            if (k.KeyCode == Keys.Return)
            {
                webBrowser1.Navigate(txtBoxAddress.Text);
                k.Handled = true;
                k.SuppressKeyPress = true;
            }
        }
    }
}
