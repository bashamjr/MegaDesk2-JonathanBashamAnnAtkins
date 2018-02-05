namespace MegaDesk_4_JonathanBasham
{
    partial class SearchQuotes
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
            this.cancelSearchQuoteButton = new System.Windows.Forms.Button();
            this.surfMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.QuoteDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WidthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrawersHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaterialHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RushHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuoteTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cancelSearchQuoteButton
            // 
            this.cancelSearchQuoteButton.AutoSize = true;
            this.cancelSearchQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelSearchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchQuoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelSearchQuoteButton.Location = new System.Drawing.Point(610, 300);
            this.cancelSearchQuoteButton.Name = "cancelSearchQuoteButton";
            this.cancelSearchQuoteButton.Size = new System.Drawing.Size(150, 50);
            this.cancelSearchQuoteButton.TabIndex = 1;
            this.cancelSearchQuoteButton.Text = "Cancel";
            this.cancelSearchQuoteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelSearchQuoteButton.UseVisualStyleBackColor = false;
            this.cancelSearchQuoteButton.Click += new System.EventHandler(this.cancelSearchQuoteButton_Click);
            // 
            // surfMaterialComboBox
            // 
            this.surfMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfMaterialComboBox.FormattingEnabled = true;
            this.surfMaterialComboBox.Location = new System.Drawing.Point(227, 23);
            this.surfMaterialComboBox.Name = "surfMaterialComboBox";
            this.surfMaterialComboBox.Size = new System.Drawing.Size(152, 28);
            this.surfMaterialComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Orders by Material";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(394, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 27);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QuoteDateHeader,
            this.NameHeader,
            this.WidthHeader,
            this.DepthHeader,
            this.DrawersHeader,
            this.MaterialHeader,
            this.RushHeader,
            this.QuoteTotal});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(33, 66);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(727, 214);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // QuoteDateHeader
            // 
            this.QuoteDateHeader.Text = "Date of Quote";
            this.QuoteDateHeader.Width = 100;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Customer Name";
            this.NameHeader.Width = 100;
            // 
            // WidthHeader
            // 
            this.WidthHeader.Text = "Width";
            // 
            // DepthHeader
            // 
            this.DepthHeader.Text = "Depth";
            // 
            // DrawersHeader
            // 
            this.DrawersHeader.Text = "Number of Drawers";
            this.DrawersHeader.Width = 116;
            // 
            // MaterialHeader
            // 
            this.MaterialHeader.Text = "Surface Material";
            this.MaterialHeader.Width = 106;
            // 
            // RushHeader
            // 
            this.RushHeader.Text = "Rush Order Days";
            this.RushHeader.Width = 108;
            // 
            // QuoteTotal
            // 
            this.QuoteTotal.Text = "Quote Total";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surfMaterialComboBox);
            this.Controls.Add(this.cancelSearchQuoteButton);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuoteButton;
        private System.Windows.Forms.ComboBox surfMaterialComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader QuoteDateHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader WidthHeader;
        private System.Windows.Forms.ColumnHeader DepthHeader;
        private System.Windows.Forms.ColumnHeader DrawersHeader;
        private System.Windows.Forms.ColumnHeader MaterialHeader;
        private System.Windows.Forms.ColumnHeader RushHeader;
        private System.Windows.Forms.ColumnHeader QuoteTotal;
    }
}