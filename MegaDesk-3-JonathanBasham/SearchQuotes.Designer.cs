namespace MegaDesk_3_JonathanBasham
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
            this.SuspendLayout();
            // 
            // cancelSearchQuoteButton
            // 
            this.cancelSearchQuoteButton.AutoSize = true;
            this.cancelSearchQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelSearchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchQuoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelSearchQuoteButton.Location = new System.Drawing.Point(211, 289);
            this.cancelSearchQuoteButton.Name = "cancelSearchQuoteButton";
            this.cancelSearchQuoteButton.Size = new System.Drawing.Size(150, 50);
            this.cancelSearchQuoteButton.TabIndex = 1;
            this.cancelSearchQuoteButton.Text = "Cancel";
            this.cancelSearchQuoteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelSearchQuoteButton.UseVisualStyleBackColor = false;
            this.cancelSearchQuoteButton.Click += new System.EventHandler(this.cancelSearchQuoteButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.cancelSearchQuoteButton);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuoteButton;
    }
}