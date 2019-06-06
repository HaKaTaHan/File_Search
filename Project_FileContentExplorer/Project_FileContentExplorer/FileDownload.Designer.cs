namespace Project_FileContentExplorer
{
    partial class FileDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDownload));
            this.download_ListView = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.label = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // download_ListView
            // 
            this.download_ListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.download_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.download_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileExtension,
            this.FileURL});
            this.download_ListView.ForeColor = System.Drawing.Color.White;
            this.download_ListView.LargeImageList = this.il;
            this.download_ListView.Location = new System.Drawing.Point(12, 72);
            this.download_ListView.Name = "download_ListView";
            this.download_ListView.Size = new System.Drawing.Size(900, 517);
            this.download_ListView.SmallImageList = this.il;
            this.download_ListView.TabIndex = 0;
            this.download_ListView.UseCompatibleStateImageBehavior = false;
            this.download_ListView.DoubleClick += new System.EventHandler(this.download_ListView_DoubleClick);
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(12, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(428, 31);
            this.label.TabIndex = 21;
            this.label.Text = "DOUBLE-CLICK TO DOWNLOAD";
            // 
            // FileDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.label);
            this.Controls.Add(this.download_ListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileDownload";
            this.Text = "FileDownload";
            this.Load += new System.EventHandler(this.FileDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView download_ListView;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileExtension;
        private System.Windows.Forms.ColumnHeader FileURL;
        public System.Windows.Forms.ImageList il;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}