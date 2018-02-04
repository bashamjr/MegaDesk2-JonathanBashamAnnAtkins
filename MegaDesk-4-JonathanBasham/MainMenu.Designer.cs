namespace MegaDesk_4_JonathanBasham
{
    partial class MainMenu
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
            this.openAddQuote = new System.Windows.Forms.Button();
            this.openViewAllQuotes = new System.Windows.Forms.Button();
            this.openSearchQuote = new System.Windows.Forms.Button();
            this.openExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openAddQuote
            // 
            this.openAddQuote.AutoSize = true;
            this.openAddQuote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openAddQuote.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openAddQuote.FlatAppearance.BorderSize = 0;
            this.openAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddQuote.Location = new System.Drawing.Point(31, 56);
            this.openAddQuote.Name = "openAddQuote";
            this.openAddQuote.Size = new System.Drawing.Size(150, 50);
            this.openAddQuote.TabIndex = 0;
            this.openAddQuote.Text = "&Add New Quote";
            this.openAddQuote.UseVisualStyleBackColor = false;
            this.openAddQuote.Click += new System.EventHandler(this.openAddQuote_Click);
            // 
            // openViewAllQuotes
            // 
            this.openViewAllQuotes.AutoSize = true;
            this.openViewAllQuotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openViewAllQuotes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openViewAllQuotes.FlatAppearance.BorderSize = 0;
            this.openViewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openViewAllQuotes.Location = new System.Drawing.Point(31, 126);
            this.openViewAllQuotes.Name = "openViewAllQuotes";
            this.openViewAllQuotes.Size = new System.Drawing.Size(150, 50);
            this.openViewAllQuotes.TabIndex = 1;
            this.openViewAllQuotes.Text = "&View Quotes";
            this.openViewAllQuotes.UseVisualStyleBackColor = false;
            this.openViewAllQuotes.Click += new System.EventHandler(this.openViewAllQuotes_Click);
            // 
            // openSearchQuote
            // 
            this.openSearchQuote.AutoSize = true;
            this.openSearchQuote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openSearchQuote.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openSearchQuote.FlatAppearance.BorderSize = 0;
            this.openSearchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSearchQuote.Location = new System.Drawing.Point(31, 197);
            this.openSearchQuote.Name = "openSearchQuote";
            this.openSearchQuote.Size = new System.Drawing.Size(150, 50);
            this.openSearchQuote.TabIndex = 2;
            this.openSearchQuote.Text = "&Search Quotes";
            this.openSearchQuote.UseVisualStyleBackColor = false;
            this.openSearchQuote.Click += new System.EventHandler(this.openSearchQuote_Click);
            // 
            // openExit
            // 
            this.openExit.AutoSize = true;
            this.openExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openExit.FlatAppearance.BorderSize = 0;
            this.openExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openExit.Location = new System.Drawing.Point(31, 267);
            this.openExit.Name = "openExit";
            this.openExit.Size = new System.Drawing.Size(150, 50);
            this.openExit.TabIndex = 3;
            this.openExit.Text = "&Exit";
            this.openExit.UseVisualStyleBackColor = false;
            this.openExit.Click += new System.EventHandler(this.openExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mega Desk Quote";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openExit);
            this.Controls.Add(this.openSearchQuote);
            this.Controls.Add(this.openViewAllQuotes);
            this.Controls.Add(this.openAddQuote);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openAddQuote;
        private System.Windows.Forms.Button openViewAllQuotes;
        private System.Windows.Forms.Button openSearchQuote;
        private System.Windows.Forms.Button openExit;
        private System.Windows.Forms.Label label1;
    }
}

