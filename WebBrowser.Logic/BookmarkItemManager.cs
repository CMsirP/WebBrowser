using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.History_BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
    class BookmarkItemManager
    {
        public static void AddBookmarkItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        public static List<BookmarkItem> GetBookmarkItems()
        {
            var adapter = new BookmarksTableAdapter();
            var result = new List<BookmarkItem>();
            var rows = adapter.GetData();
            foreach(var row in rows)
            {
                result.Add(new BookmarkItem() { Id = row.Id, Title = row.Title, URL = row.URL });
            }
            return result;
        }
    }
}
