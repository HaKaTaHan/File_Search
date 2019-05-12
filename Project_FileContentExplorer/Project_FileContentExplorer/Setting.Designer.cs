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
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DayTo_Combo = new System.Windows.Forms.ComboBox();
            this.YearTo_Combo = new System.Windows.Forms.ComboBox();
            this.MonthTo_Combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DayFrom_Combo = new System.Windows.Forms.ComboBox();
            this.YearFrom_Combo = new System.Windows.Forms.ComboBox();
            this.MonthFrom_Combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.DayTo_Combo);
            this.panel2.Controls.Add(this.YearTo_Combo);
            this.panel2.Controls.Add(this.MonthTo_Combo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DayFrom_Combo);
            this.panel2.Controls.Add(this.YearFrom_Combo);
            this.panel2.Controls.Add(this.MonthFrom_Combo);
            this.panel2.Controls.Add(this.label6);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(435, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "~";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(718, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = ",";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(578, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = ",";
            // 
            // DayTo_Combo
            // 
            this.DayTo_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.DayTo_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayTo_Combo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTo_Combo.ForeColor = System.Drawing.Color.White;
            this.DayTo_Combo.FormattingEnabled = true;
            this.DayTo_Combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayTo_Combo.Location = new System.Drawing.Point(595, 258);
            this.DayTo_Combo.Name = "DayTo_Combo";
            this.DayTo_Combo.Size = new System.Drawing.Size(121, 24);
            this.DayTo_Combo.TabIndex = 22;
            this.DayTo_Combo.SelectedIndexChanged += new System.EventHandler(this.DayTo_Combo_SelectedIndexChanged);
            // 
            // YearTo_Combo
            // 
            this.YearTo_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.YearTo_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearTo_Combo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTo_Combo.ForeColor = System.Drawing.Color.White;
            this.YearTo_Combo.FormattingEnabled = true;
            this.YearTo_Combo.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.YearTo_Combo.Location = new System.Drawing.Point(735, 258);
            this.YearTo_Combo.Name = "YearTo_Combo";
            this.YearTo_Combo.Size = new System.Drawing.Size(121, 24);
            this.YearTo_Combo.TabIndex = 23;
            this.YearTo_Combo.SelectedIndexChanged += new System.EventHandler(this.YearTo_Combo_SelectedIndexChanged);
            // 
            // MonthTo_Combo
            // 
            this.MonthTo_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.MonthTo_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthTo_Combo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthTo_Combo.ForeColor = System.Drawing.Color.White;
            this.MonthTo_Combo.FormattingEnabled = true;
            this.MonthTo_Combo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthTo_Combo.Location = new System.Drawing.Point(455, 258);
            this.MonthTo_Combo.Name = "MonthTo_Combo";
            this.MonthTo_Combo.Size = new System.Drawing.Size(121, 24);
            this.MonthTo_Combo.TabIndex = 21;
            this.MonthTo_Combo.SelectedIndexChanged += new System.EventHandler(this.MonthTo_Combo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(289, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = ",";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(149, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = ",";
            // 
            // DayFrom_Combo
            // 
            this.DayFrom_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.DayFrom_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayFrom_Combo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayFrom_Combo.ForeColor = System.Drawing.Color.White;
            this.DayFrom_Combo.FormattingEnabled = true;
            this.DayFrom_Combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayFrom_Combo.Location = new System.Drawing.Point(166, 258);
            this.DayFrom_Combo.Name = "DayFrom_Combo";
            this.DayFrom_Combo.Size = new System.Drawing.Size(121, 24);
            this.DayFrom_Combo.TabIndex = 19;
            this.DayFrom_Combo.SelectedIndexChanged += new System.EventHandler(this.DayFrom_Combo_SelectedIndexChanged);
            // 
            // YearFrom_Combo
            // 
            this.YearFrom_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.YearFrom_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearFrom_Combo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearFrom_Combo.ForeColor = System.Drawing.Color.White;
            this.YearFrom_Combo.FormattingEnabled = true;
            this.YearFrom_Combo.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.YearFrom_Combo.Location = new System.Drawing.Point(306, 258);
            this.YearFrom_Combo.Name = "YearFrom_Combo";
            this.YearFrom_Combo.Size = new System.Drawing.Size(121, 24);
            this.YearFrom_Combo.TabIndex = 20;
            this.YearFrom_Combo.SelectedIndexChanged += new System.EventHandler(this.YearFrom_Combo_SelectedIndexChanged);
            // 
            // MonthFrom_Combo
            // 
            this.MonthFrom_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.MonthFrom_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthFrom_Combo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthFrom_Combo.ForeColor = System.Drawing.Color.White;
            this.MonthFrom_Combo.FormattingEnabled = true;
            this.MonthFrom_Combo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthFrom_Combo.Location = new System.Drawing.Point(26, 258);
            this.MonthFrom_Combo.Name = "MonthFrom_Combo";
            this.MonthFrom_Combo.Size = new System.Drawing.Size(121, 24);
            this.MonthFrom_Combo.TabIndex = 18;
            this.MonthFrom_Combo.SelectedIndexChanged += new System.EventHandler(this.MonthFrom_Combo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "SEARCH DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "SEARCH SCOPE";
            // 
            // DOC_Text
            // 
            this.DOC_Text.AutoSize = true;
            this.DOC_Text.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOC_Text.ForeColor = System.Drawing.Color.White;
            this.DOC_Text.Location = new System.Drawing.Point(386, 62);
            this.DOC_Text.Name = "DOC_Text";
            this.DOC_Text.Size = new System.Drawing.Size(126, 23);
            this.DOC_Text.TabIndex = 15;
            this.DOC_Text.Text = ".DOC  .DOCX";
            this.DOC_Text.UseVisualStyleBackColor = true;
            this.DOC_Text.CheckedChanged += new System.EventHandler(this.DOC_Text_CheckedChanged);
            // 
            // HWP_Check
            // 
            this.HWP_Check.AutoSize = true;
            this.HWP_Check.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWP_Check.ForeColor = System.Drawing.Color.White;
            this.HWP_Check.Location = new System.Drawing.Point(266, 62);
            this.HWP_Check.Name = "HWP_Check";
            this.HWP_Check.Size = new System.Drawing.Size(71, 23);
            this.HWP_Check.TabIndex = 14;
            this.HWP_Check.Text = ".HWP";
            this.HWP_Check.UseVisualStyleBackColor = true;
            this.HWP_Check.CheckedChanged += new System.EventHandler(this.HWP_Check_CheckedChanged);
            // 
            // TXT_Check
            // 
            this.TXT_Check.AutoSize = true;
            this.TXT_Check.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Check.ForeColor = System.Drawing.Color.White;
            this.TXT_Check.Location = new System.Drawing.Point(146, 62);
            this.TXT_Check.Name = "TXT_Check";
            this.TXT_Check.Size = new System.Drawing.Size(59, 23);
            this.TXT_Check.TabIndex = 13;
            this.TXT_Check.Text = ".TXT";
            this.TXT_Check.UseVisualStyleBackColor = true;
            this.TXT_Check.CheckedChanged += new System.EventHandler(this.TXT_Check_CheckedChanged);
            // 
            // PDF__Check
            // 
            this.PDF__Check.AutoSize = true;
            this.PDF__Check.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDF__Check.ForeColor = System.Drawing.Color.White;
            this.PDF__Check.Location = new System.Drawing.Point(26, 62);
            this.PDF__Check.Name = "PDF__Check";
            this.PDF__Check.Size = new System.Drawing.Size(63, 23);
            this.PDF__Check.TabIndex = 12;
            this.PDF__Check.Text = ".PDF";
            this.PDF__Check.UseVisualStyleBackColor = true;
            this.PDF__Check.CheckedChanged += new System.EventHandler(this.PDF__Check_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DayTo_Combo;
        private System.Windows.Forms.ComboBox YearTo_Combo;
        private System.Windows.Forms.ComboBox MonthTo_Combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DayFrom_Combo;
        private System.Windows.Forms.ComboBox YearFrom_Combo;
        private System.Windows.Forms.ComboBox MonthFrom_Combo;
        private System.Windows.Forms.Label label6;
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