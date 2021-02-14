﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BrowserHousing : UserControl
    {
        private string currentAddress = "";

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigated(object sender,
    WebBrowserNavigatedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            txtBoxAddress.Text = webBrowser1.Url.ToString();
            currentAddress = txtBoxAddress.Text;
        }

        private void btnBookmark_Click(object sender, EventArgs e)
        {
            string title = ((HtmlDocument)webBrowser1.Document).Title;
            List<BookmarkItem> list = BookmarkItemManager.GetBookmarkItems();
            foreach (var bm in list)
            {
                if (bm.Title.Equals(title))
                {
                    return;
                }
            }
            var item = new BookmarkItem();
            item.Title = title;
            item.URL = webBrowser1.Document.Url.ToString();

        }
    }
}