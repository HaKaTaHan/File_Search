namespace Project_FileContentExplorer
{
    partial class Findaccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_Text = new System.Windows.Forms.TextBox();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIND ACCOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TYPE YOUR E-MAIL";
            // 
            // Email_Text
            // 
            this.Email_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.Email_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Text.ForeColor = System.Drawing.Color.White;
            this.Email_Text.Location = new System.Drawing.Point(77, 229);
            this.Email_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email_Text.MaxLength = 100;
            this.Email_Text.Name = "Email_Text";
            this.Email_Text.Size = new System.Drawing.Size(342, 32);
            this.Email_Text.TabIndex = 26;
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.Submit_Btn.FlatAppearance.BorderSize = 0;
            this.Submit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Btn.ForeColor = System.Drawing.Color.White;
            this.Submit_Btn.Location = new System.Drawing.Point(77, 374);
            this.Submit_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(114, 38);
            this.Submit_Btn.TabIndex = 31;
            this.Submit_Btn.Text = "SUBMIT";
            this.Submit_Btn.UseVisualStyleBackColor = false;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // Findaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1056, 751);
            this.Controls.Add(this.Submit_Btn);
            this.Controls.Add(this.Email_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Findaccount";
            this.Text = "Findaccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_Text;
        private System.Windows.Forms.Button Submit_Btn;
    }
}