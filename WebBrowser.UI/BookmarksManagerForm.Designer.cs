
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
            // BookmarksManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 540);
            this.Controls.Add(this.listBoxBookmarks);
            this.Name = "BookmarksManagerForm";
            this.Text = "BookmarksManagerForm";
            this.Load += new System.EventHandler(this.BookmarksManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookmarks;
    }
}