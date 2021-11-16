
namespace WinForm_main
{
    partial class While2
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
            this.TextBoxK = new System.Windows.Forms.TextBox();
            this.LabelK = new System.Windows.Forms.Label();
            this.ButtonAction = new System.Windows.Forms.Button();
            this.TextBoxN = new System.Windows.Forms.TextBox();
            this.LabelN = new System.Windows.Forms.Label();
            this.LabelAsk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxK
            // 
            this.TextBoxK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxK.ForeColor = System.Drawing.Color.Purple;
            this.TextBoxK.Location = new System.Drawing.Point(196, 214);
            this.TextBoxK.Name = "TextBoxK";
            this.TextBoxK.ReadOnly = true;
            this.TextBoxK.Size = new System.Drawing.Size(86, 27);
            this.TextBoxK.TabIndex = 33;
            this.TextBoxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxK.Visible = false;
            // 
            // LabelK
            // 
            this.LabelK.AutoSize = true;
            this.LabelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelK.ForeColor = System.Drawing.Color.Purple;
            this.LabelK.Location = new System.Drawing.Point(155, 217);
            this.LabelK.Name = "LabelK";
            this.LabelK.Size = new System.Drawing.Size(35, 20);
            this.LabelK.TabIndex = 32;
            this.LabelK.Text = "K =";
            this.LabelK.Visible = false;
            // 
            // ButtonAction
            // 
            this.ButtonAction.BackColor = System.Drawing.Color.Purple;
            this.ButtonAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAction.Location = new System.Drawing.Point(123, 130);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(196, 53);
            this.ButtonAction.TabIndex = 31;
            this.ButtonAction.Text = "Find";
            this.ButtonAction.UseVisualStyleBackColor = false;
            this.ButtonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // TextBoxN
            // 
            this.TextBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxN.ForeColor = System.Drawing.Color.Purple;
            this.TextBoxN.Location = new System.Drawing.Point(196, 73);
            this.TextBoxN.Name = "TextBoxN";
            this.TextBoxN.Size = new System.Drawing.Size(86, 27);
            this.TextBoxN.TabIndex = 30;
            this.TextBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelN.ForeColor = System.Drawing.Color.Purple;
            this.LabelN.Location = new System.Drawing.Point(154, 76);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(36, 20);
            this.LabelN.TabIndex = 29;
            this.LabelN.Text = "N =";
            // 
            // LabelAsk
            // 
            this.LabelAsk.AutoSize = true;
            this.LabelAsk.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.LabelAsk.ForeColor = System.Drawing.Color.Purple;
            this.LabelAsk.Location = new System.Drawing.Point(118, 21);
            this.LabelAsk.Name = "LabelAsk";
            this.LabelAsk.Size = new System.Drawing.Size(228, 25);
            this.LabelAsk.TabIndex = 28;
            this.LabelAsk.Text = "Enter integer N ( > 1 )";
            // 
            // While2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.TextBoxK);
            this.Controls.Add(this.LabelK);
            this.Controls.Add(this.ButtonAction);
            this.Controls.Add(this.TextBoxN);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.LabelAsk);
            this.Name = "While2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "While2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxK;
        private System.Windows.Forms.Label LabelK;
        private System.Windows.Forms.Button ButtonAction;
        private System.Windows.Forms.TextBox TextBoxN;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label LabelAsk;
    }
}