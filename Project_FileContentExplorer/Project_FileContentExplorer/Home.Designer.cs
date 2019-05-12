namespace Project_FileContentExplorer
{
    partial class Home
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Panel_Btns = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Setting_Btn = new System.Windows.Forms.Button();
            this.Account_Btn = new System.Windows.Forms.Button();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Display_Area = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_open = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Btns.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Btns
            // 
            this.Panel_Btns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Panel_Btns.Controls.Add(this.button4);
            this.Panel_Btns.Controls.Add(this.Setting_Btn);
            this.Panel_Btns.Controls.Add(this.Account_Btn);
            this.Panel_Btns.Controls.Add(this.Search_Btn);
            this.Panel_Btns.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Btns.Location = new System.Drawing.Point(0, 0);
            this.Panel_Btns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Btns.Name = "Panel_Btns";
            this.Panel_Btns.Size = new System.Drawing.Size(160, 751);
            this.Panel_Btns.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.button4.Location = new System.Drawing.Point(0, 450);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 150);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Setting_Btn
            // 
            this.Setting_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Setting_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Setting_Btn.FlatAppearance.BorderSize = 0;
            this.Setting_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Setting_Btn.Image = global::Project_FileContentExplorer.Properties.Resources.KakaoTalk_20190509_181414212;
            this.Setting_Btn.Location = new System.Drawing.Point(0, 300);
            this.Setting_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Setting_Btn.Name = "Setting_Btn";
            this.Setting_Btn.Size = new System.Drawing.Size(160, 150);
            this.Setting_Btn.TabIndex = 2;
            this.Setting_Btn.UseVisualStyleBackColor = false;
            this.Setting_Btn.Click += new System.EventHandler(this.Setting_Btn_Click);
            // 
            // Account_Btn
            // 
            this.Account_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Account_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Account_Btn.FlatAppearance.BorderSize = 0;
            this.Account_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Account_Btn.Image = global::Project_FileContentExplorer.Properties.Resources.KakaoTalk_20190509_181414334;
            this.Account_Btn.Location = new System.Drawing.Point(0, 150);
            this.Account_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Account_Btn.Name = "Account_Btn";
            this.Account_Btn.Size = new System.Drawing.Size(160, 150);
            this.Account_Btn.TabIndex = 1;
            this.Account_Btn.UseVisualStyleBackColor = false;
            this.Account_Btn.Click += new System.EventHandler(this.Account_Btn_Click);
            // 
            // Search_Btn
            // 
            this.Search_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.Search_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_Btn.FlatAppearance.BorderSize = 0;
            this.Search_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.Search_Btn.Image = global::Project_FileContentExplorer.Properties.Resources.KakaoTalk_20190509_181414085;
            this.Search_Btn.Location = new System.Drawing.Point(0, 0);
            this.Search_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(160, 150);
            this.Search_Btn.TabIndex = 0;
            this.Search_Btn.UseVisualStyleBackColor = false;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // Display_Area
            // 
            this.Display_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display_Area.Location = new System.Drawing.Point(160, 0);
            this.Display_Area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display_Area.Name = "Display_Area";
            this.Display_Area.Size = new System.Drawing.Size(1056, 751);
            this.Display_Area.TabIndex = 3;
            this.Display_Area.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Area_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "File Content Explorer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_open,
            this.btn_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // btn_open
            // 
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(108, 24);
            this.btn_open.Text = "열기";
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 24);
            this.btn_exit.Text = "종료";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1216, 751);
            this.Controls.Add(this.Display_Area);
            this.Controls.Add(this.Panel_Btns);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Text = "File Content Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.Panel_Btns.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Btns;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Setting_Btn;
        private System.Windows.Forms.Button Account_Btn;
        private System.Windows.Forms.Panel Display_Area;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_open;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
    }
}

