namespace Project_FileContentExplorer
{
    partial class Signup
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.PW_text = new System.Windows.Forms.TextBox();
            this.PW_Check_Label = new System.Windows.Forms.Label();
            this.ID_Error = new System.Windows.Forms.Label();
            this.CheckID_Btn = new System.Windows.Forms.Button();
            this.SingUp_Btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm_text = new System.Windows.Forms.TextBox();
            this.Email_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_Combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 39);
            this.label6.TabIndex = 21;
            this.label6.Text = "CREATE ACCOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "PASSWORD";
            // 
            // ID_text
            // 
            this.ID_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ID_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_text.ForeColor = System.Drawing.Color.White;
            this.ID_text.Location = new System.Drawing.Point(77, 194);
            this.ID_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID_text.MaxLength = 10;
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(285, 29);
            this.ID_text.TabIndex = 25;
            this.ID_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_text_KeyPress);
            this.ID_text.Leave += new System.EventHandler(this.ID_text_Leave);
            // 
            // PW_text
            // 
            this.PW_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.PW_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW_text.ForeColor = System.Drawing.Color.White;
            this.PW_text.Location = new System.Drawing.Point(77, 319);
            this.PW_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PW_text.MaxLength = 12;
            this.PW_text.Name = "PW_text";
            this.PW_text.PasswordChar = '*';
            this.PW_text.Size = new System.Drawing.Size(285, 29);
            this.PW_text.TabIndex = 26;
            this.PW_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PW_Check_Label
            // 
            this.PW_Check_Label.AutoSize = true;
            this.PW_Check_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW_Check_Label.ForeColor = System.Drawing.Color.Red;
            this.PW_Check_Label.Location = new System.Drawing.Point(73, 479);
            this.PW_Check_Label.Name = "PW_Check_Label";
            this.PW_Check_Label.Size = new System.Drawing.Size(220, 24);
            this.PW_Check_Label.TabIndex = 28;
            this.PW_Check_Label.Text = "* Passwords don\'t match!";
            this.PW_Check_Label.Visible = false;
            // 
            // ID_Error
            // 
            this.ID_Error.AutoSize = true;
            this.ID_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Error.ForeColor = System.Drawing.Color.Red;
            this.ID_Error.Location = new System.Drawing.Point(73, 228);
            this.ID_Error.Name = "ID_Error";
            this.ID_Error.Size = new System.Drawing.Size(165, 24);
            this.ID_Error.TabIndex = 29;
            this.ID_Error.Text = "* Already exists ID!";
            this.ID_Error.Visible = false;
            // 
            // CheckID_Btn
            // 
            this.CheckID_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.CheckID_Btn.FlatAppearance.BorderSize = 0;
            this.CheckID_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckID_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckID_Btn.ForeColor = System.Drawing.Color.White;
            this.CheckID_Btn.Location = new System.Drawing.Point(392, 192);
            this.CheckID_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckID_Btn.Name = "CheckID_Btn";
            this.CheckID_Btn.Size = new System.Drawing.Size(97, 31);
            this.CheckID_Btn.TabIndex = 30;
            this.CheckID_Btn.Text = "CHECK";
            this.CheckID_Btn.UseVisualStyleBackColor = false;
            this.CheckID_Btn.Click += new System.EventHandler(this.CheckID_Btn_Click);
            // 
            // SingUp_Btn
            // 
            this.SingUp_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(180)))), ((int)(((byte)(82)))));
            this.SingUp_Btn.FlatAppearance.BorderSize = 0;
            this.SingUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingUp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingUp_Btn.ForeColor = System.Drawing.Color.White;
            this.SingUp_Btn.Location = new System.Drawing.Point(77, 675);
            this.SingUp_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SingUp_Btn.Name = "SingUp_Btn";
            this.SingUp_Btn.Size = new System.Drawing.Size(114, 38);
            this.SingUp_Btn.TabIndex = 31;
            this.SingUp_Btn.Text = "SIGN UP";
            this.SingUp_Btn.UseVisualStyleBackColor = false;
            this.SingUp_Btn.Click += new System.EventHandler(this.SingUp_Btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(135, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "6 to 10 Characters, Numbers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(215, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Any kind of 8 to 12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "CONFIRM";
            // 
            // Confirm_text
            // 
            this.Confirm_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.Confirm_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_text.ForeColor = System.Drawing.Color.White;
            this.Confirm_text.Location = new System.Drawing.Point(77, 445);
            this.Confirm_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Confirm_text.MaxLength = 12;
            this.Confirm_text.Name = "Confirm_text";
            this.Confirm_text.PasswordChar = '*';
            this.Confirm_text.Size = new System.Drawing.Size(285, 29);
            this.Confirm_text.TabIndex = 27;
            this.Confirm_text.TextChanged += new System.EventHandler(this.Confirm_text_TextChanged);
            // 
            // Email_text
            // 
            this.Email_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.Email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_text.ForeColor = System.Drawing.Color.White;
            this.Email_text.Location = new System.Drawing.Point(77, 580);
            this.Email_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(183, 29);
            this.Email_text.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "E-MAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(267, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "@";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Email_Combo
            // 
            this.Email_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.Email_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Email_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Email_Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Combo.ForeColor = System.Drawing.Color.White;
            this.Email_Combo.FormattingEnabled = true;
            this.Email_Combo.Items.AddRange(new object[] {
            "직접 입력",
            "naver.com",
            "nate.com",
            "gmail.com",
            "daum.net"});
            this.Email_Combo.Location = new System.Drawing.Point(299, 580);
            this.Email_Combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email_Combo.Name = "Email_Combo";
            this.Email_Combo.Size = new System.Drawing.Size(189, 32);
            this.Email_Combo.TabIndex = 37;
            this.Email_Combo.SelectedIndexChanged += new System.EventHandler(this.Email_Combo_SelectedIndexChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1056, 751);
            this.Controls.Add(this.Email_Combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SingUp_Btn);
            this.Controls.Add(this.CheckID_Btn);
            this.Controls.Add(this.ID_Error);
            this.Controls.Add(this.PW_Check_Label);
            this.Controls.Add(this.Confirm_text);
            this.Controls.Add(this.PW_text);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.TextBox PW_text;
        private System.Windows.Forms.Label PW_Check_Label;
        private System.Windows.Forms.Label ID_Error;
        private System.Windows.Forms.Button CheckID_Btn;
        private System.Windows.Forms.Button SingUp_Btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Confirm_text;
        private System.Windows.Forms.TextBox Email_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Email_Combo;
    }
}