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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadListBox()
        {
            List<HistoryItem> list = HistoryItemManager.GetHistoryItems();
            foreach (var item in list)
            {
                string input = "[" + item.Date + "] " + item.Title + " (" + item.URL + ")";
                listBoxHistory.Items.Add(input);
            }
        }
        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            List<HistoryItem> list = HistoryItemManager.GetHistoryItems();
            List<string> items = new List<string>();

            foreach (var item in list)
            {
                string input = "[" + item.Date + "] " + item.Title + " (" + item.URL + ")";
                if (input.Contains(keyword))
                {
                    items.Add(input);
                }
                
            }
            listBoxHistory.Items.Clear();
            foreach (string item in items)
            {
                    listBoxHistory.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<HistoryItem> list = HistoryItemManager.GetHistoryItems();
            HistoryItem current = new HistoryItem();
            try
            {
                string[] info = listBoxHistory.SelectedItem.ToString().Split('[', ']', '(', ')');
                current.Date = DateTime.Parse(info[1]);
                current.Title = info[2].Trim();
                current.URL = info[3];
                foreach (var item in list)
                {
                    if (current.Date.Date.Equals(item.Date.Date) && current.Title.Equals(item.Title) && current.URL.Equals(item.URL))
                    {
                        HistoryItemManager.DeleteHistoryItem(item.Id);
                        listBoxHistory.Items.Clear();
                        LoadListBox();
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
