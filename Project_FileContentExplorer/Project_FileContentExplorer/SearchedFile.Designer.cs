namespace Project_FileContentExplorer
{
    partial class SearchedFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchedFile));
            this.FileName_Label = new System.Windows.Forms.Label();
            this.FilePath_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.Extension_Picture = new System.Windows.Forms.PictureBox();
            this.Upload_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Extension_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // FileName_Label
            // 
            this.FileName_Label.AutoSize = true;
            this.FileName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName_Label.ForeColor = System.Drawing.Color.White;
            this.FileName_Label.Location = new System.Drawing.Point(105, 18);
            this.FileName_Label.Name = "FileName_Label";
            this.FileName_Label.Size = new System.Drawing.Size(157, 24);
            this.FileName_Label.TabIndex = 3;
            this.FileName_Label.Text = "Insert_File_Name";
            // 
            // FilePath_Label
            // 
            this.FilePath_Label.AutoSize = true;
            this.FilePath_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePath_Label.ForeColor = System.Drawing.Color.White;
            this.FilePath_Label.Location = new System.Drawing.Point(411, 22);
            this.FilePath_Label.Name = "FilePath_Label";
            this.FilePath_Label.Size = new System.Drawing.Size(199, 20);
            this.FilePath_Label.TabIndex = 5;
            this.FilePath_Label.Text = "Insert_File_Path_BlahBlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Path:";
            // 
            // il
            // 
            this.il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il.ImageStream")));
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            this.il.Images.SetKeyName(0, "Image_TXT.png");
            this.il.Images.SetKeyName(1, "Image_PDF.png");
            this.il.Images.SetKeyName(2, "Icon_HWP.png");
            this.il.Images.SetKeyName(3, "Image_DOC.png");
            // 
            // Extension_Picture
            // 
            this.Extension_Picture.Location = new System.Drawing.Point(22, 18);
            this.Extension_Picture.Name = "Extension_Picture";
            this.Extension_Picture.Size = new System.Drawing.Size(64, 64);
            this.Extension_Picture.TabIndex = 8;
            this.Extension_Picture.TabStop = false;
            // 
            // Upload_Btn
            // 
            this.Upload_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(180)))), ((int)(((byte)(82)))));
            this.Upload_Btn.FlatAppearance.BorderSize = 0;
            this.Upload_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_Btn.ForeColor = System.Drawing.Color.White;
            this.Upload_Btn.Location = new System.Drawing.Point(109, 52);
            this.Upload_Btn.Name = "Upload_Btn";
            this.Upload_Btn.Size = new System.Drawing.Size(100, 30);
            this.Upload_Btn.TabIndex = 32;
            this.Upload_Btn.Text = "UPLOAD";
            this.Upload_Btn.UseVisualStyleBackColor = false;
            this.Upload_Btn.Click += new System.EventHandler(this.Upload_Btn_Click);
            // 
            // SearchedFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(814, 100);
            this.Controls.Add(this.Upload_Btn);
            this.Controls.Add(this.Extension_Picture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilePath_Label);
            this.Controls.Add(this.FileName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchedFile";
            this.Text = "SearchedFile";
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.SearchedFile_GiveFeedback);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SearchedFile_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchedFile_MouseDown);
            this.MouseLeave += new System.EventHandler(this.SearchedFile_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchedFile_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SearchedFile_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Extension_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label FileName_Label;
        public System.Windows.Forms.Label FilePath_Label;
        public System.Windows.Forms.ImageList il;
        public System.Windows.Forms.PictureBox Extension_Picture;
        private System.Windows.Forms.Button Upload_Btn;
    }
}