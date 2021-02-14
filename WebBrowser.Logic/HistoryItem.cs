using System;
using System.Collections.Generic;
using System.Text;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        private string url;
        public string URL { get => url; set { url = value; } }
        private string title;
        public string Title { get => title; set { title = value; } }
        private DateTime date;
        public DateTime Date { get => date; set { date = value; } }
    }
}
}
