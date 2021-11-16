
namespace WinForm_main
{
    partial class For1
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
            this.AskLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AskLabel
            // 
            this.AskLabel.AutoSize = true;
            this.AskLabel.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskLabel.ForeColor = System.Drawing.Color.Maroon;
            this.AskLabel.Location = new System.Drawing.Point(108, 20);
            this.AskLabel.Name = "AskLabel";
            this.AskLabel.Size = new System.Drawing.Size(257, 25);
            this.AskLabel.TabIndex = 0;
            this.AskLabel.Text = "Enter two integers (a < b)";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aLabel.ForeColor = System.Drawing.Color.Maroon;
            this.aLabel.Location = new System.Drawing.Point(149, 67);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(33, 20);
            this.aLabel.TabIndex = 1;
            this.aLabel.Text = "a =";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLabel.ForeColor = System.Drawing.Color.Maroon;
            this.bLabel.Location = new System.Drawing.Point(149, 107);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(33, 20);
            this.bLabel.TabIndex = 2;
            this.bLabel.Text = "b =";
            // 
            // aTextBox
            // 
            this.aTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.aTextBox.Location = new System.Drawing.Point(188, 64);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(86, 27);
            this.aTextBox.TabIndex = 9;
            this.aTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.LightCoral;
            this.ActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActionButton.Location = new System.Drawing.Point(133, 151);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(196, 53);
            this.ActionButton.TabIndex = 5;
            this.ActionButton.Text = "Count";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ProductLabel.Location = new System.Drawing.Point(139, 224);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(87, 20);
            this.ProductLabel.TabIndex = 6;
            this.ProductLabel.Text = "Product = ";
            this.ProductLabel.Visible = false;
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ProductTextBox.Location = new System.Drawing.Point(232, 221);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.ReadOnly = true;
            this.ProductTextBox.Size = new System.Drawing.Size(87, 27);
            this.ProductTextBox.TabIndex = 7;
            this.ProductTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductTextBox.Visible = false;
            // 
            // bTextBox
            // 
            this.bTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.bTextBox.Location = new System.Drawing.Point(188, 107);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(86, 27);
            this.bTextBox.TabIndex = 10;
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // For1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.AskLabel);
            this.Name = "For1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label AskLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.TextBox bTextBox;
    }
}