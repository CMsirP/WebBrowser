
namespace WebBrowser.UI
{
    partial class BookmarksManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxBookmarks = new System.Windows.Forms.ListBox();
            this.lblSearchTerms = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxBookmarks
            // 
            this.listBoxBookmarks.FormattingEnabled = true;
            this.listBoxBookmarks.Location = new System.Drawing.Point(33, 59);
            this.listBoxBookmarks.Name = "listBoxBookmarks";
            this.listBoxBookmarks.Size = new System.Drawing.Size(729, 433);
            this.listBoxBookmarks.TabIndex = 0;
            // 
            // lblSearchTerms
            // 
            this.lblSearchTerms.AutoSize = true;
            this.lblSearchTerms.Location = new System.Drawing.Point(787, 59);
            this.lblSearchTerms.Name = "lblSearchTerms";
            this.lblSearchTerms.Size = new System.Drawing.Size(133, 13);
            this.lblSearchTerms.TabIndex = 1;
            this.lblSearchTerms.Text = "Enter Search Terms Below";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(790, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(790, 85);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(130, 20);
            this.txtBoxSearch.TabIndex = 3;
            // 
            // BookmarksManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 540);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchTerms);
            this.Controls.Add(this.listBoxBookmarks);
            this.Name = "BookmarksManagerForm";
            this.Text = "BookmarksManagerForm";
            this.Load += new System.EventHandler(this.BookmarksManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookmarks;
        private System.Windows.Forms.Label lblSearchTerms;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
    }
}