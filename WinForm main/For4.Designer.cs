
namespace WinForm_main
{
    partial class For4
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
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.AskLabel = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTextBox
            // 
            this.bTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.bTextBox.ForeColor = System.Drawing.Color.Green;
            this.bTextBox.Location = new System.Drawing.Point(178, 107);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(86, 27);
            this.bTextBox.TabIndex = 16;
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.Green;
            this.ActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ActionButton.ForeColor = System.Drawing.Color.Ivory;
            this.ActionButton.Location = new System.Drawing.Point(119, 150);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(196, 53);
            this.ActionButton.TabIndex = 14;
            this.ActionButton.Text = "Count";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // aTextBox
            // 
            this.aTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.aTextBox.ForeColor = System.Drawing.Color.Green;
            this.aTextBox.Location = new System.Drawing.Point(178, 65);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(86, 27);
            this.aTextBox.TabIndex = 15;
            this.aTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.bLabel.ForeColor = System.Drawing.Color.Green;
            this.bLabel.Location = new System.Drawing.Point(144, 110);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(33, 20);
            this.bLabel.TabIndex = 13;
            this.bLabel.Text = "b =";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.aLabel.ForeColor = System.Drawing.Color.Green;
            this.aLabel.Location = new System.Drawing.Point(144, 68);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(33, 20);
            this.aLabel.TabIndex = 12;
            this.aLabel.Text = "a =";
            // 
            // AskLabel
            // 
            this.AskLabel.AutoSize = true;
            this.AskLabel.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.AskLabel.ForeColor = System.Drawing.Color.Green;
            this.AskLabel.Location = new System.Drawing.Point(104, 21);
            this.AskLabel.Name = "AskLabel";
            this.AskLabel.Size = new System.Drawing.Size(271, 25);
            this.AskLabel.TabIndex = 11;
            this.AskLabel.Text = "Enter two integers ( a < b )";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.SumTextBox.ForeColor = System.Drawing.Color.Green;
            this.SumTextBox.Location = new System.Drawing.Point(210, 225);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(86, 27);
            this.SumTextBox.TabIndex = 21;
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SumTextBox.Visible = false;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.SumLabel.ForeColor = System.Drawing.Color.Green;
            this.SumLabel.Location = new System.Drawing.Point(141, 228);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(63, 20);
            this.SumLabel.TabIndex = 20;
            this.SumLabel.Text = "Sum  =";
            this.SumLabel.Visible = false;
            // 
            // For4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.AskLabel);
            this.Name = "For4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label AskLabel;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Label SumLabel;
    }
}