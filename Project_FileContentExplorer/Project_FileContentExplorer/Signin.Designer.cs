namespace Project_FileContentExplorer
{
    partial class Signin
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
            this.Signin_Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Signin_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Signin_Panel
            // 
            this.Signin_Panel.Controls.Add(this.label6);
            this.Signin_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signin_Panel.Location = new System.Drawing.Point(0, 0);
            this.Signin_Panel.Name = "Signin_Panel";
            this.Signin_Panel.Size = new System.Drawing.Size(924, 601);
            this.Signin_Panel.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(409, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "CHOOSE FILE TO DOWNLOAD";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.Signin_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signin";
            this.Text = "Signin";
            this.Signin_Panel.ResumeLayout(false);
            this.Signin_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Signin_Panel;
        private System.Windows.Forms.Label label6;
    }
}