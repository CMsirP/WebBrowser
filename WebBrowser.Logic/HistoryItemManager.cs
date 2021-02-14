using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.History_BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
   public class HistoryItemManager
    {
        public static void AddHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        public static List<HistoryItem> GetHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var result = new List<HistoryItem>();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                result.Add(new HistoryItem() { Id = row.Id, Title = row.Title, URL = row.URL, Date = row.Date });
            }
            return result;
        }
    }
}
