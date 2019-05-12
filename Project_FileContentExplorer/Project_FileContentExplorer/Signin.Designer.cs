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
            this.welcome = new System.Windows.Forms.Label();
            this.Item_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(41, 32);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(161, 31);
            this.welcome.TabIndex = 22;
            this.welcome.Text = "WELCOME!";
            // 
            // Item_Panel
            // 
            this.Item_Panel.AutoScroll = true;
            this.Item_Panel.Location = new System.Drawing.Point(47, 104);
            this.Item_Panel.Name = "Item_Panel";
            this.Item_Panel.Size = new System.Drawing.Size(814, 469);
            this.Item_Panel.TabIndex = 23;
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.Item_Panel);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signin";
            this.Text = "Signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel Item_Panel;
    }
}