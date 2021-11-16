
namespace WinForm_main
{
    partial class While1
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
            this.TextBoxN = new System.Windows.Forms.TextBox();
            this.LabelN = new System.Windows.Forms.Label();
            this.LabelAsk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxSum.ForeColor = System.Drawing.Color.Navy;
            this.TextBoxSum.Location = new System.Drawing.Point(129, 204);
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.ReadOnly = true;
            this.TextBoxSum.Size = new System.Drawing.Size(225, 27);
            this.TextBoxSum.TabIndex = 27;
            this.TextBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSum.Visible = false;
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelSum.ForeColor = System.Drawing.Color.Navy;
            this.LabelSum.Location = new System.Drawing.Point(60, 207);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(63, 20);
            this.LabelSum.TabIndex = 26;
            this.LabelSum.Text = "Sum  =";
            this.LabelSum.Visible = false;
            // 
            // ButtonAction
            // 
            this.ButtonAction.BackColor = System.Drawing.Color.Navy;
            this.ButtonAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAction.Location = new System.Drawing.Point(112, 122);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(196, 53);
            this.ButtonAction.TabIndex = 25;
            this.ButtonAction.Text = "Count";
            this.ButtonAction.UseVisualStyleBackColor = false;
            this.ButtonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // TextBoxN
            // 
            this.TextBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxN.ForeColor = System.Drawing.Color.Navy;
            this.TextBoxN.Location = new System.Drawing.Point(185, 67);
            this.TextBoxN.Name = "TextBoxN";
            this.TextBoxN.Size = new System.Drawing.Size(86, 27);
            this.TextBoxN.TabIndex = 24;
            this.TextBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelN.ForeColor = System.Drawing.Color.Navy;
            this.LabelN.Location = new System.Drawing.Point(143, 70);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(36, 20);
            this.LabelN.TabIndex = 23;
            this.LabelN.Text = "N =";
            // 
            // LabelAsk
            // 
            this.LabelAsk.AutoSize = true;
            this.LabelAsk.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.LabelAsk.ForeColor = System.Drawing.Color.Navy;
            this.LabelAsk.Location = new System.Drawing.Point(124, 23);
            this.LabelAsk.Name = "LabelAsk";
            this.LabelAsk.Size = new System.Drawing.Size(207, 25);
            this.LabelAsk.TabIndex = 22;
            this.LabelAsk.Text = "Enter integer N (>0)";
            // 
            // While1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.LabelSum);
            this.Controls.Add(this.ButtonAction);
            this.Controls.Add(this.TextBoxN);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.LabelAsk);
            this.Name = "While1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "While1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Button ButtonAction;
        private System.Windows.Forms.TextBox TextBoxN;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label LabelAsk;
    }
}