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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            List<HistoryItem> list = HistoryItemManager.GetHistoryItems();
            foreach(var item in list)
            {
                string input = "[" + item.Date + "] " + item.Title + " (" + item.URL + ")";
                listBoxHistory.Items.Add(input);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            foreach (string item in listBoxHistory.Items)
            {
                if (!item.Contains(keyword))
                {
                    listBoxHistory.Items.Remove(item);
                }
            }
        }
    }
}
