namespace MegaDesk_4_JonathanBasham
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.surfMaterial = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rushDays = new System.Windows.Forms.ComboBox();
            this.addDisplayQuoteButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDrawers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.AutoSize = true;
            this.cancelQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelQuoteButton.Location = new System.Drawing.Point(222, 289);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(150, 50);
            this.cancelQuoteButton.TabIndex = 0;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelQuoteButton.UseVisualStyleBackColor = false;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(170, 40);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(202, 26);
            this.customerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDepth
            // 
            this.txtDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepth.Location = new System.Drawing.Point(170, 115);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(202, 26);
            this.txtDepth.TabIndex = 6;
            this.txtDepth.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepth_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Drawers:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Surface Material:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surfMaterial
            // 
            this.surfMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfMaterial.FormattingEnabled = true;
            this.surfMaterial.Location = new System.Drawing.Point(171, 195);
            this.surfMaterial.Name = "surfMaterial";
            this.surfMaterial.Size = new System.Drawing.Size(201, 28);
            this.surfMaterial.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rush Days:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rushDays
            // 
            this.rushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDays.FormattingEnabled = true;
            this.rushDays.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.rushDays.Location = new System.Drawing.Point(171, 236);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(201, 28);
            this.rushDays.TabIndex = 14;
            // 
            // addDisplayQuoteButton
            // 
            this.addDisplayQuoteButton.AutoSize = true;
            this.addDisplayQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addDisplayQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDisplayQuoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addDisplayQuoteButton.Location = new System.Drawing.Point(57, 289);
            this.addDisplayQuoteButton.Name = "addDisplayQuoteButton";
            this.addDisplayQuoteButton.Size = new System.Drawing.Size(150, 50);
            this.addDisplayQuoteButton.TabIndex = 15;
            this.addDisplayQuoteButton.Text = "&Add";
            this.addDisplayQuoteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addDisplayQuoteButton.UseVisualStyleBackColor = false;
            this.addDisplayQuoteButton.Click += new System.EventHandler(this.addDisplayQuoteButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(53, 9);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 20);
            this.errorMessage.TabIndex = 16;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(170, 76);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(202, 26);
            this.txtWidth.TabIndex = 17;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtWidth_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtDrawers
            // 
            this.txtDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrawers.FormattingEnabled = true;
            this.txtDrawers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.txtDrawers.Location = new System.Drawing.Point(171, 156);
            this.txtDrawers.Name = "txtDrawers";
            this.txtDrawers.Size = new System.Drawing.Size(201, 28);
            this.txtDrawers.TabIndex = 18;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 362);
            this.ControlBox = false;
            this.Controls.Add(this.txtDrawers);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.addDisplayQuoteButton);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.surfMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelQuoteButton);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox surfMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rushDays;
        private System.Windows.Forms.Button addDisplayQuoteButton;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox txtDrawers;
    }
}