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
    public partial class BrowserHousing : UserControl
    {
        private Stack<string> back = new Stack<string>();
        private Stack<string> forward = new Stack<string>();
        private string currentAddress;

        public BrowserHousing()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (currentAddress != null && !back.Contains(currentAddress))
            {
                back.Push(currentAddress);
            }
            currentAddress = txtBoxAddress.Text;
            webBrowser1.Navigate(currentAddress);
            forward.Clear();
        }

        private void KeyDownTxtb(object sender, KeyEventArgs k)
        {
            if (k.KeyCode == Keys.Return)
            {
                if (currentAddress != null && !back.Contains(currentAddress))
                {
                    back.Push(currentAddress);
                }
                currentAddress = txtBoxAddress.Text;
                webBrowser1.Navigate(currentAddress);
                k.Handled = true;
                k.SuppressKeyPress = true;
                forward.Clear();
            }
        }

        private void txtBoxAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (back.Any())
            {
                string prevAdd = back.Pop();
                webBrowser1.Navigate(prevAdd);
                forward.Push(prevAdd);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (forward.Any())
            {
                string nextAdd = forward.Pop();
                webBrowser1.Navigate(nextAdd);
                back.Push(nextAdd);
            }

        }
    }
}
