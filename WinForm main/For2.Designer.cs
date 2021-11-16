
namespace WinForm_main
{
    partial class For2
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
            this.TextBoxN = new System.Windows.Forms.TextBox();
            this.LabelN = new System.Windows.Forms.Label();
            this.LabelAsk = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.LabelSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxN
            // 
            this.TextBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxN.Location = new System.Drawing.Point(189, 69);
            this.TextBoxN.Name = "TextBoxN";
            this.TextBoxN.Size = new System.Drawing.Size(86, 27);
            this.TextBoxN.TabIndex = 12;
            this.TextBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelN.Location = new System.Drawing.Point(147, 72);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(36, 20);
            this.LabelN.TabIndex = 11;
            this.LabelN.Text = "N =";
            // 
            // LabelAsk
            // 
            this.LabelAsk.AutoSize = true;
            this.LabelAsk.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.LabelAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelAsk.Location = new System.Drawing.Point(106, 21);
            this.LabelAsk.Name = "LabelAsk";
            this.LabelAsk.Size = new System.Drawing.Size(228, 25);
            this.LabelAsk.TabIndex = 10;
            this.LabelAsk.Text = "Enter integer N ( > 0 )";
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ActionButton.ForeColor = System.Drawing.Color.White;
            this.ActionButton.Location = new System.Drawing.Point(123, 119);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(196, 53);
            this.ActionButton.TabIndex = 13;
            this.ActionButton.Text = "Count";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxSum.Location = new System.Drawing.Point(181, 195);
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.ReadOnly = true;
            this.TextBoxSum.Size = new System.Drawing.Size(134, 27);
            this.TextBoxSum.TabIndex = 15;
            this.TextBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSum.Visible = false;
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelSum.Location = new System.Drawing.Point(112, 198);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(63, 20);
            this.LabelSum.TabIndex = 14;
            this.LabelSum.Text = "Sum  =";
            this.LabelSum.Visible = false;
            // 
            // For2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.LabelSum);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.TextBoxN);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.LabelAsk);
            this.Name = "For2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxN;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label LabelAsk;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.Label LabelSum;
    }
}