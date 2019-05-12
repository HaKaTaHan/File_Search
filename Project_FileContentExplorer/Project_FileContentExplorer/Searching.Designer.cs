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
            this.label1 = new System.Windows.Forms.Label();
            this.Pause_Btn = new System.Windows.Forms.Button();
            this.Search_Progress = new System.Windows.Forms.ProgressBar();
            this.Keyword_Label = new System.Windows.Forms.Label();
            this.Item_Panel = new System.Windows.Forms.Panel();
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
            // 
            // Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.Item_Panel);
            this.Controls.Add(this.Keyword_Label);
            this.Controls.Add(this.Search_Progress);
            this.Controls.Add(this.Pause_Btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Searching";
            this.Text = "Searching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pause_Btn;
        private System.Windows.Forms.ProgressBar Search_Progress;
        private System.Windows.Forms.Label Keyword_Label;
        private System.Windows.Forms.Panel Item_Panel;
    }
}