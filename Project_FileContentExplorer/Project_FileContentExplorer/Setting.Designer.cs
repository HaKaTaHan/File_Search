namespace Project_FileContentExplorer
{
    partial class Setting
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Scope_Btn = new System.Windows.Forms.Button();
            this.Scope_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DOC_Text = new System.Windows.Forms.CheckBox();
            this.HWP_Check = new System.Windows.Forms.CheckBox();
            this.TXT_Check = new System.Windows.Forms.CheckBox();
            this.PDF__Check = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.Scope_Btn);
            this.panel2.Controls.Add(this.Scope_Text);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.DOC_Text);
            this.panel2.Controls.Add(this.HWP_Check);
            this.panel2.Controls.Add(this.TXT_Check);
            this.panel2.Controls.Add(this.PDF__Check);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 601);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Scope_Btn
            // 
            this.Scope_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.Scope_Btn.FlatAppearance.BorderSize = 0;
            this.Scope_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scope_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scope_Btn.ForeColor = System.Drawing.Color.White;
            this.Scope_Btn.Location = new System.Drawing.Point(546, 160);
            this.Scope_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Scope_Btn.Name = "Scope_Btn";
            this.Scope_Btn.Size = new System.Drawing.Size(170, 25);
            this.Scope_Btn.TabIndex = 17;
            this.Scope_Btn.Text = "CHANGE LOCATION";
            this.Scope_Btn.UseVisualStyleBackColor = false;
            this.Scope_Btn.Click += new System.EventHandler(this.ChangeLocation_Btn_Click);
            // 
            // Scope_Text
            // 
            this.Scope_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Scope_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scope_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.Scope_Text.Location = new System.Drawing.Point(26, 160);
            this.Scope_Text.Name = "Scope_Text";
            this.Scope_Text.ReadOnly = true;
            this.Scope_Text.Size = new System.Drawing.Size(500, 24);
            this.Scope_Text.TabIndex = 16;
            this.Scope_Text.TextChanged += new System.EventHandler(this.Scope_Text_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "SEARCH SCOPE";
            // 
            // DOC_Text
            // 
            this.DOC_Text.AutoSize = true;
            this.DOC_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOC_Text.ForeColor = System.Drawing.Color.White;
            this.DOC_Text.Location = new System.Drawing.Point(386, 62);
            this.DOC_Text.Name = "DOC_Text";
            this.DOC_Text.Size = new System.Drawing.Size(125, 24);
            this.DOC_Text.TabIndex = 15;
            this.DOC_Text.Text = ".DOC  .DOCX";
            this.DOC_Text.UseVisualStyleBackColor = true;
            this.DOC_Text.CheckedChanged += new System.EventHandler(this.DOC_Text_CheckedChanged);
            // 
            // HWP_Check
            // 
            this.HWP_Check.AutoSize = true;
            this.HWP_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWP_Check.ForeColor = System.Drawing.Color.White;
            this.HWP_Check.Location = new System.Drawing.Point(266, 62);
            this.HWP_Check.Name = "HWP_Check";
            this.HWP_Check.Size = new System.Drawing.Size(69, 24);
            this.HWP_Check.TabIndex = 14;
            this.HWP_Check.Text = ".HWP";
            this.HWP_Check.UseVisualStyleBackColor = true;
            this.HWP_Check.CheckedChanged += new System.EventHandler(this.HWP_Check_CheckedChanged);
            // 
            // TXT_Check
            // 
            this.TXT_Check.AutoSize = true;
            this.TXT_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Check.ForeColor = System.Drawing.Color.White;
            this.TXT_Check.Location = new System.Drawing.Point(146, 62);
            this.TXT_Check.Name = "TXT_Check";
            this.TXT_Check.Size = new System.Drawing.Size(61, 24);
            this.TXT_Check.TabIndex = 13;
            this.TXT_Check.Text = ".TXT";
            this.TXT_Check.UseVisualStyleBackColor = true;
            this.TXT_Check.CheckedChanged += new System.EventHandler(this.TXT_Check_CheckedChanged);
            // 
            // PDF__Check
            // 
            this.PDF__Check.AutoSize = true;
            this.PDF__Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDF__Check.ForeColor = System.Drawing.Color.White;
            this.PDF__Check.Location = new System.Drawing.Point(26, 62);
            this.PDF__Check.Name = "PDF__Check";
            this.PDF__Check.Size = new System.Drawing.Size(64, 24);
            this.PDF__Check.TabIndex = 12;
            this.PDF__Check.Text = ".PDF";
            this.PDF__Check.UseVisualStyleBackColor = true;
            this.PDF__Check.CheckedChanged += new System.EventHandler(this.PDF__Check_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "EXTENSION";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Setting";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox DOC_Text;
        private System.Windows.Forms.CheckBox HWP_Check;
        private System.Windows.Forms.CheckBox TXT_Check;
        private System.Windows.Forms.CheckBox PDF__Check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Scope_Text;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button Scope_Btn;
    }
}