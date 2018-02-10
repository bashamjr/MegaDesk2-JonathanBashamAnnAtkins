namespace MegaDesk_4_JonathanBasham
{
    partial class ViewAllQuotes
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
            this.cancelViewAllQuotesButton = new System.Windows.Forms.Button();
            this.dgvAllQuotes = new System.Windows.Forms.DataGridView();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrderDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelViewAllQuotesButton
            // 
            this.cancelViewAllQuotesButton.AutoSize = true;
            this.cancelViewAllQuotesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelViewAllQuotesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelViewAllQuotesButton.Location = new System.Drawing.Point(724, 331);
            this.cancelViewAllQuotesButton.Name = "cancelViewAllQuotesButton";
            this.cancelViewAllQuotesButton.Size = new System.Drawing.Size(150, 50);
            this.cancelViewAllQuotesButton.TabIndex = 1;
            this.cancelViewAllQuotesButton.Text = "Cancel";
            this.cancelViewAllQuotesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelViewAllQuotesButton.UseVisualStyleBackColor = false;
            this.cancelViewAllQuotesButton.Click += new System.EventHandler(this.cancelViewAllQuotesButton_Click);
            // 
            // dgvAllQuotes
            // 
            this.dgvAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuoteDate,
            this.CustomerName,
            this.Width,
            this.Depth,
            this.numOfDrawers,
            this.surfMaterial,
            this.rushOrderDays,
            this.quoteTotal});
            this.dgvAllQuotes.Location = new System.Drawing.Point(24, 82);
            this.dgvAllQuotes.Name = "dgvAllQuotes";
            this.dgvAllQuotes.Size = new System.Drawing.Size(850, 233);
            this.dgvAllQuotes.TabIndex = 2;
            // 
            // QuoteDate
            // 
            this.QuoteDate.HeaderText = "Quote Date";
            this.QuoteDate.Name = "QuoteDate";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Depth
            // 
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.HeaderText = "Drawers";
            this.numOfDrawers.Name = "numOfDrawers";
            // 
            // surfMaterial
            // 
            this.surfMaterial.HeaderText = "Surface Material";
            this.surfMaterial.Name = "surfMaterial";
            // 
            // rushOrderDays
            // 
            this.rushOrderDays.HeaderText = "Rush Order Days";
            this.rushOrderDays.Name = "rushOrderDays";
            // 
            // quoteTotal
            // 
            this.quoteTotal.HeaderText = "Quote Total";
            this.quoteTotal.Name = "quoteTotal";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 419);
            this.Controls.Add(this.dgvAllQuotes);
            this.Controls.Add(this.cancelViewAllQuotesButton);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelViewAllQuotesButton;
        private System.Windows.Forms.DataGridView dgvAllQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrderDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteTotal;
    }
}