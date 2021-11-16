
namespace WinForm_main
{
    partial class While3
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
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.ButtonAction = new System.Windows.Forms.Button();
            this.TextBoxP = new System.Windows.Forms.TextBox();
            this.LabelP = new System.Windows.Forms.Label();
            this.LabelAsk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxResult.ForeColor = System.Drawing.Color.Maroon;
            this.TextBoxResult.Location = new System.Drawing.Point(80, 207);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(334, 45);
            this.TextBoxResult.TabIndex = 39;
            this.TextBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxResult.Visible = false;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelResult.ForeColor = System.Drawing.Color.Maroon;
            this.LabelResult.Location = new System.Drawing.Point(12, 223);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(62, 20);
            this.LabelResult.TabIndex = 38;
            this.LabelResult.Text = "Result:";
            this.LabelResult.Visible = false;
            // 
            // ButtonAction
            // 
            this.ButtonAction.BackColor = System.Drawing.Color.Maroon;
            this.ButtonAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonAction.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonAction.Location = new System.Drawing.Point(115, 127);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(196, 53);
            this.ButtonAction.TabIndex = 37;
            this.ButtonAction.Text = "Find";
            this.ButtonAction.UseVisualStyleBackColor = false;
            this.ButtonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // TextBoxP
            // 
            this.TextBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxP.ForeColor = System.Drawing.Color.Maroon;
            this.TextBoxP.Location = new System.Drawing.Point(188, 82);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(86, 27);
            this.TextBoxP.TabIndex = 36;
            this.TextBoxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelP
            // 
            this.LabelP.AutoSize = true;
            this.LabelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelP.ForeColor = System.Drawing.Color.Maroon;
            this.LabelP.Location = new System.Drawing.Point(146, 85);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(36, 20);
            this.LabelP.TabIndex = 35;
            this.LabelP.Text = "N =";
            // 
            // LabelAsk
            // 
            this.LabelAsk.AutoSize = true;
            this.LabelAsk.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.LabelAsk.ForeColor = System.Drawing.Color.Maroon;
            this.LabelAsk.Location = new System.Drawing.Point(110, 30);
            this.LabelAsk.Name = "LabelAsk";
            this.LabelAsk.Size = new System.Drawing.Size(252, 25);
            this.LabelAsk.TabIndex = 34;
            this.LabelAsk.Text = "Enter P - persents ( > 0 )";
            // 
            // While3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonAction);
            this.Controls.Add(this.TextBoxP);
            this.Controls.Add(this.LabelP);
            this.Controls.Add(this.LabelAsk);
            this.Name = "While3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "While3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button ButtonAction;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.Label LabelAsk;
    }
}