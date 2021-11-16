
namespace WinForm_main
{
    partial class DoWhile1
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
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.LabelSum = new System.Windows.Forms.Label();
            this.ButtonAction = new System.Windows.Forms.Button();
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelAsk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxSum.Location = new System.Drawing.Point(185, 219);
            this.TextBoxSum.Multiline = true;
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.ReadOnly = true;
            this.TextBoxSum.Size = new System.Drawing.Size(137, 29);
            this.TextBoxSum.TabIndex = 45;
            this.TextBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSum.Visible = false;
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelSum.Location = new System.Drawing.Point(131, 222);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(48, 20);
            this.LabelSum.TabIndex = 44;
            this.LabelSum.Text = "Sum:";
            this.LabelSum.Visible = false;
            // 
            // ButtonAction
            // 
            this.ButtonAction.BackColor = System.Drawing.Color.Maroon;
            this.ButtonAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonAction.ForeColor = System.Drawing.Color.White;
            this.ButtonAction.Location = new System.Drawing.Point(126, 136);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(196, 53);
            this.ButtonAction.TabIndex = 43;
            this.ButtonAction.Text = "Add";
            this.ButtonAction.UseVisualStyleBackColor = false;
            this.ButtonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextBoxNumber.Location = new System.Drawing.Point(210, 82);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(86, 27);
            this.TextBoxNumber.TabIndex = 42;
            this.TextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelNumber.Location = new System.Drawing.Point(131, 85);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(73, 20);
            this.LabelNumber.TabIndex = 41;
            this.LabelNumber.Text = "Number:";
            // 
            // LabelAsk
            // 
            this.LabelAsk.AutoSize = true;
            this.LabelAsk.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.LabelAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelAsk.Location = new System.Drawing.Point(30, 23);
            this.LabelAsk.Name = "LabelAsk";
            this.LabelAsk.Size = new System.Drawing.Size(400, 25);
            this.LabelAsk.TabIndex = 40;
            this.LabelAsk.Text = "Enter numbers to count (enter 0 to end)";
            // 
            // DoWhile1
            // 
            this.AcceptButton = this.ButtonAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.LabelSum);
            this.Controls.Add(this.ButtonAction);
            this.Controls.Add(this.TextBoxNumber);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.LabelAsk);
            this.Name = "DoWhile1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoWhile1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Button ButtonAction;
        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelAsk;
    }
}