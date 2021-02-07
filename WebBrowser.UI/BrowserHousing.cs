﻿using System;
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
        public BrowserHousing()
        {
            InitializeComponent();
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

        private void txtBoxAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
