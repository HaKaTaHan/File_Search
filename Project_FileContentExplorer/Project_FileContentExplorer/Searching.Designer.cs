namespace Project_FileContentExplorer
{
    partial class Searching
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Pause_Btn = new System.Windows.Forms.Button();
            this.Search_Progress = new System.Windows.Forms.ProgressBar();
            this.Keyword_Label = new System.Windows.Forms.Label();
            this.Item_Panel = new System.Windows.Forms.Panel();
            this.Resume_Btn = new System.Windows.Forms.Button();
            this.Stop_Btn = new System.Windows.Forms.Button();
            this.Tohome_Btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEARCHING KEYWORD: ";
            // 
            // Pause_Btn
            // 
            this.Pause_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.Pause_Btn.FlatAppearance.BorderSize = 0;
            this.Pause_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_Btn.ForeColor = System.Drawing.Color.White;
            this.Pause_Btn.Location = new System.Drawing.Point(721, 26);
            this.Pause_Btn.Name = "Pause_Btn";
            this.Pause_Btn.Size = new System.Drawing.Size(140, 35);
            this.Pause_Btn.TabIndex = 5;
            this.Pause_Btn.Text = "PAUSE";
            this.Pause_Btn.UseVisualStyleBackColor = false;
            this.Pause_Btn.Click += new System.EventHandler(this.Pause_Btn_Click);
            // 
            // Search_Progress
            // 
            this.Search_Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(180)))), ((int)(((byte)(82)))));
            this.Search_Progress.Location = new System.Drawing.Point(47, 82);
            this.Search_Progress.Name = "Search_Progress";
            this.Search_Progress.Size = new System.Drawing.Size(814, 23);
            this.Search_Progress.TabIndex = 6;
            // 
            // Keyword_Label
            // 
            this.Keyword_Label.AutoSize = true;
            this.Keyword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keyword_Label.ForeColor = System.Drawing.Color.White;
            this.Keyword_Label.Location = new System.Drawing.Point(376, 26);
            this.Keyword_Label.Name = "Keyword_Label";
            this.Keyword_Label.Size = new System.Drawing.Size(172, 31);
            this.Keyword_Label.TabIndex = 7;
            this.Keyword_Label.Text = "KEYWORDS";
            // 
            // Item_Panel
            // 
            this.Item_Panel.AutoScroll = true;
            this.Item_Panel.Location = new System.Drawing.Point(47, 120);
            this.Item_Panel.Name = "Item_Panel";
            this.Item_Panel.Size = new System.Drawing.Size(814, 469);
            this.Item_Panel.TabIndex = 8;
            this.Item_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Item_Panel_Paint);
            // 
            // Resume_Btn
            // 
            this.Resume_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(180)))), ((int)(((byte)(82)))));
            this.Resume_Btn.FlatAppearance.BorderSize = 0;
            this.Resume_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume_Btn.ForeColor = System.Drawing.Color.White;
            this.Resume_Btn.Location = new System.Drawing.Point(565, 26);
            this.Resume_Btn.Name = "Resume_Btn";
            this.Resume_Btn.Size = new System.Drawing.Size(140, 35);
            this.Resume_Btn.TabIndex = 9;
            this.Resume_Btn.Text = "RESUME";
            this.Resume_Btn.UseVisualStyleBackColor = false;
            this.Resume_Btn.Visible = false;
            this.Resume_Btn.Click += new System.EventHandler(this.Resume_Btn_Click);
            // 
            // Stop_Btn
            // 
            this.Stop_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Stop_Btn.FlatAppearance.BorderSize = 0;
            this.Stop_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Btn.ForeColor = System.Drawing.Color.White;
            this.Stop_Btn.Location = new System.Drawing.Point(721, 26);
            this.Stop_Btn.Name = "Stop_Btn";
            this.Stop_Btn.Size = new System.Drawing.Size(140, 35);
            this.Stop_Btn.TabIndex = 10;
            this.Stop_Btn.Text = "STOP";
            this.Stop_Btn.UseVisualStyleBackColor = false;
            this.Stop_Btn.Visible = false;
            this.Stop_Btn.Click += new System.EventHandler(this.Stop_Btn_Click);
            // 
            // Tohome_Btn
            // 
            this.Tohome_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.Tohome_Btn.FlatAppearance.BorderSize = 0;
            this.Tohome_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tohome_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tohome_Btn.ForeColor = System.Drawing.Color.White;
            this.Tohome_Btn.Location = new System.Drawing.Point(565, 26);
            this.Tohome_Btn.Name = "Tohome_Btn";
            this.Tohome_Btn.Size = new System.Drawing.Size(296, 35);
            this.Tohome_Btn.TabIndex = 12;
            this.Tohome_Btn.Text = "SEARCH NEW KEYWORD";
            this.Tohome_Btn.UseVisualStyleBackColor = false;
            this.Tohome_Btn.Visible = false;
            this.Tohome_Btn.Click += new System.EventHandler(this.Tohome_Btn_Click);
            // 
            // Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(883, 550);
            this.Controls.Add(this.Tohome_Btn);
            this.Controls.Add(this.Stop_Btn);
            this.Controls.Add(this.Resume_Btn);
            this.Controls.Add(this.Item_Panel);
            this.Controls.Add(this.Keyword_Label);
            this.Controls.Add(this.Search_Progress);
            this.Controls.Add(this.Pause_Btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Searching";
            this.Text = "Searching";
            this.Load += new System.EventHandler(this.Searching_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pause_Btn;
        private System.Windows.Forms.ProgressBar Search_Progress;
        private System.Windows.Forms.Label Keyword_Label;
        private System.Windows.Forms.Panel Item_Panel;
        private System.Windows.Forms.Button Resume_Btn;
        private System.Windows.Forms.Button Stop_Btn;
        private System.Windows.Forms.Button Tohome_Btn;
        private System.Windows.Forms.Timer timer1;
    }
}