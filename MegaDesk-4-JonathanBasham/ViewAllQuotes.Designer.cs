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
            this.SuspendLayout();
            // 
            // cancelViewAllQuotesButton
            // 
            this.cancelViewAllQuotesButton.AutoSize = true;
            this.cancelViewAllQuotesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelViewAllQuotesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelViewAllQuotesButton.Location = new System.Drawing.Point(197, 275);
            this.cancelViewAllQuotesButton.Name = "cancelViewAllQuotesButton";
            this.cancelViewAllQuotesButton.Size = new System.Drawing.Size(150, 50);
            this.cancelViewAllQuotesButton.TabIndex = 1;
            this.cancelViewAllQuotesButton.Text = "Cancel";
            this.cancelViewAllQuotesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelViewAllQuotesButton.UseVisualStyleBackColor = false;
            this.cancelViewAllQuotesButton.Click += new System.EventHandler(this.cancelViewAllQuotesButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.cancelViewAllQuotesButton);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelViewAllQuotesButton;
    }
}