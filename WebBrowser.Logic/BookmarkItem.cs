using System;
using System.Collections.Generic;
using System.Text;

namespace WebBrowser.Logic
{
    public class BookmarkItem
    {
        private int id;
        public int Id { get => id; set { id = value; } }
        private string url;
        public string URL { get => url; set { url = value; } }
        private string title;
        public string Title { get => title; set { title = value; } }
    }
}
