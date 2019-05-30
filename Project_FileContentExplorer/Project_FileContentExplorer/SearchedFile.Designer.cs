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
            ((System.ComponentModel.ISupportInitialize)(this.Extension_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // FileName_Label
            // 
            this.FileName_Label.AutoSize = true;
            this.FileName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName_Label.ForeColor = System.Drawing.Color.White;
            this.FileName_Label.Location = new System.Drawing.Point(120, 22);
            this.FileName_Label.Name = "FileName_Label";
            this.FileName_Label.Size = new System.Drawing.Size(204, 29);
            this.FileName_Label.TabIndex = 3;
            this.FileName_Label.Text = "Insert_File_Name";
            // 
            // FilePath_Label
            // 
            this.FilePath_Label.AutoSize = true;
            this.FilePath_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePath_Label.ForeColor = System.Drawing.Color.White;
            this.FilePath_Label.Location = new System.Drawing.Point(562, 26);
            this.FilePath_Label.Name = "FilePath_Label";
            this.FilePath_Label.Size = new System.Drawing.Size(242, 25);
            this.FilePath_Label.TabIndex = 5;
            this.FilePath_Label.Text = "Insert_File_Path_BlahBlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
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
            this.Extension_Picture.Location = new System.Drawing.Point(25, 22);
            this.Extension_Picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Extension_Picture.Name = "Extension_Picture";
            this.Extension_Picture.Size = new System.Drawing.Size(73, 80);
            this.Extension_Picture.TabIndex = 8;
            this.Extension_Picture.TabStop = false;
            // 
            // SearchedFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(930, 125);
            this.Controls.Add(this.Extension_Picture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilePath_Label);
            this.Controls.Add(this.FileName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchedFile";
            this.Text = "SearchedFile";
            this.DoubleClick += new System.EventHandler(this.SearchedFile_DoubleClick);
            this.MouseLeave += new System.EventHandler(this.SearchedFile_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchedFile_MouseMove);
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
    }
}