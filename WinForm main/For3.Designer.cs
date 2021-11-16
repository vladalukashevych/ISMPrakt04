
namespace WinForm_main
{
    partial class For3
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
            this.LabelAsk = new System.Windows.Forms.Label();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.LabelA = new System.Windows.Forms.Label();
            this.TextBoxN = new System.Windows.Forms.TextBox();
            this.LabelN = new System.Windows.Forms.Label();
            this.ButtonAction = new System.Windows.Forms.Button();
            this.TextBoxPow = new System.Windows.Forms.TextBox();
            this.LabelPow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAsk
            // 
            this.LabelAsk.AutoSize = true;
            this.LabelAsk.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.LabelAsk.ForeColor = System.Drawing.Color.Olive;
            this.LabelAsk.Location = new System.Drawing.Point(13, 19);
            this.LabelAsk.Name = "LabelAsk";
            this.LabelAsk.Size = new System.Drawing.Size(487, 25);
            this.LabelAsk.TabIndex = 11;
            this.LabelAsk.Text = "Enter two numbers ( A - fractional, N - natural)";
            // 
            // TextBoxA
            // 
            this.TextBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxA.ForeColor = System.Drawing.Color.Olive;
            this.TextBoxA.Location = new System.Drawing.Point(140, 69);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(86, 27);
            this.TextBoxA.TabIndex = 14;
            this.TextBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelA.ForeColor = System.Drawing.Color.Olive;
            this.LabelA.Location = new System.Drawing.Point(106, 72);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(35, 20);
            this.LabelA.TabIndex = 13;
            this.LabelA.Text = "A =";
            // 
            // TextBoxN
            // 
            this.TextBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxN.ForeColor = System.Drawing.Color.Olive;
            this.TextBoxN.Location = new System.Drawing.Point(286, 69);
            this.TextBoxN.Name = "TextBoxN";
            this.TextBoxN.Size = new System.Drawing.Size(86, 27);
            this.TextBoxN.TabIndex = 16;
            this.TextBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelN.ForeColor = System.Drawing.Color.Olive;
            this.LabelN.Location = new System.Drawing.Point(244, 72);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(36, 20);
            this.LabelN.TabIndex = 15;
            this.LabelN.Text = "N =";
            // 
            // ButtonAction
            // 
            this.ButtonAction.BackColor = System.Drawing.Color.Olive;
            this.ButtonAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAction.Location = new System.Drawing.Point(151, 123);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(196, 53);
            this.ButtonAction.TabIndex = 17;
            this.ButtonAction.Text = "Count";
            this.ButtonAction.UseVisualStyleBackColor = false;
            this.ButtonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // TextBoxPow
            // 
            this.TextBoxPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TextBoxPow.ForeColor = System.Drawing.Color.Olive;
            this.TextBoxPow.Location = new System.Drawing.Point(204, 206);
            this.TextBoxPow.Name = "TextBoxPow";
            this.TextBoxPow.ReadOnly = true;
            this.TextBoxPow.Size = new System.Drawing.Size(134, 27);
            this.TextBoxPow.TabIndex = 19;
            this.TextBoxPow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPow.Visible = false;
            // 
            // LabelPow
            // 
            this.LabelPow.AutoSize = true;
            this.LabelPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.LabelPow.ForeColor = System.Drawing.Color.Olive;
            this.LabelPow.Location = new System.Drawing.Point(139, 209);
            this.LabelPow.Name = "LabelPow";
            this.LabelPow.Size = new System.Drawing.Size(59, 20);
            this.LabelPow.TabIndex = 18;
            this.LabelPow.Text = "A^N  =";
            this.LabelPow.Visible = false;
            // 
            // For3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(507, 280);
            this.Controls.Add(this.TextBoxPow);
            this.Controls.Add(this.LabelPow);
            this.Controls.Add(this.ButtonAction);
            this.Controls.Add(this.TextBoxN);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.TextBoxA);
            this.Controls.Add(this.LabelA);
            this.Controls.Add(this.LabelAsk);
            this.Name = "For3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAsk;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.TextBox TextBoxN;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Button ButtonAction;
        private System.Windows.Forms.TextBox TextBoxPow;
        private System.Windows.Forms.Label LabelPow;
    }
}