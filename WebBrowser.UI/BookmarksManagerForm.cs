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

namespace WebBrowser.UI
{
    public partial class BookmarksManagerForm : Form
    {
        public BookmarksManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarksManagerForm_Load(object sender, EventArgs e)
        {
            List<BookmarkItem> list = BookmarkItemManager.GetBookmarkItems();
            foreach (var item in list)
            {
                string input = item.Title + " (" + item.URL + ")";
                listBoxBookmarks.Items.Add(input);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            List<BookmarkItem> list = BookmarkItemManager.GetBookmarkItems();
            List<string> items = new List<string>();

            foreach (var item in list)
            {
                string input = item.Title + " (" + item.URL + ")";
                if (input.Contains(keyword))
                {
                    items.Add(input);
                }

            }
            listBoxBookmarks.Items.Clear();
            foreach (string item in items)
            {
                listBoxBookmarks.Items.Add(item);
            }
        }
    }

}
