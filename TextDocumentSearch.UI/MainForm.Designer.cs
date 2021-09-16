namespace TextDocumentSearch.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.keywordLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.filepathTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.browseButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.topToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(12, 38);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(102, 13);
            this.keywordLabel.TabIndex = 1;
            this.keywordLabel.Text = "Keyword/Sentence:";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(120, 35);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(270, 20);
            this.keywordTextBox.TabIndex = 2;
            this.keywordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keywordTextBox_KeyUp);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(396, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(15, 62);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(456, 160);
            this.resultsListBox.TabIndex = 5;
            // 
            // topToolStrip
            // 
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filepathTextBox,
            this.browseButton});
            this.topToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(487, 25);
            this.topToolStrip.TabIndex = 6;
            this.topToolStrip.Text = "toolStrip1";
            // 
            // filepathTextBox
            // 
            this.filepathTextBox.Name = "filepathTextBox";
            this.filepathTextBox.Size = new System.Drawing.Size(400, 25);
            this.filepathTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filepathTextBox_KeyUp);
            // 
            // browseButton
            // 
            this.browseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.browseButton.Image = ((System.Drawing.Image)(resources.GetObject("browseButton.Image")));
            this.browseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(58, 22);
            this.browseButton.Text = "Browse...";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 233);
            this.Controls.Add(this.topToolStrip);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.keywordLabel);
            this.Name = "MainForm";
            this.Text = "Text File Contents Search";
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripTextBox filepathTextBox;
        private System.Windows.Forms.ToolStripButton browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

