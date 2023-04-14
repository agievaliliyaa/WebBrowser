namespace MyWebBrowser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackBtn = new System.Windows.Forms.ToolStripButton();
            this.ForwardBtn = new System.Windows.Forms.ToolStripButton();
            this.StopBtn = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.FavTabBtn = new System.Windows.Forms.ToolStripTextBox();
            this.GoBtn = new System.Windows.Forms.ToolStripButton();
            this.AddTabBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteTabBtn = new System.Windows.Forms.ToolStripButton();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackBtn,
            this.ForwardBtn,
            this.StopBtn,
            this.RefreshBtn,
            this.FavTabBtn,
            this.GoBtn,
            this.AddTabBtn,
            this.DeleteTabBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BackBtn
            // 
            this.BackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(34, 33);
            this.BackBtn.Text = "Назад";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("ForwardBtn.Image")));
            this.ForwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(34, 33);
            this.ForwardBtn.Text = "Вперед";
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopBtn.Image")));
            this.StopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(34, 33);
            this.StopBtn.Text = "Остановить загрузку";
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(34, 33);
            this.RefreshBtn.Text = "Обновить";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // FavTabBtn
            // 
            this.FavTabBtn.AutoSize = false;
            this.FavTabBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FavTabBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FavTabBtn.Name = "FavTabBtn";
            this.FavTabBtn.Size = new System.Drawing.Size(600, 38);
            this.FavTabBtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTB_KeyUp);
            // 
            // GoBtn
            // 
            this.GoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoBtn.Image = ((System.Drawing.Image)(resources.GetObject("GoBtn.Image")));
            this.GoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(34, 33);
            this.GoBtn.Text = "Поиск";
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // AddTabBtn
            // 
            this.AddTabBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AddTabBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTabBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddTabBtn.Image")));
            this.AddTabBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTabBtn.Name = "AddTabBtn";
            this.AddTabBtn.Size = new System.Drawing.Size(34, 33);
            this.AddTabBtn.Text = "Добавить вкладку";
            this.AddTabBtn.Click += new System.EventHandler(this.AddTabBtn_Click);
            // 
            // DeleteTabBtn
            // 
            this.DeleteTabBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DeleteTabBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteTabBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTabBtn.Image")));
            this.DeleteTabBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteTabBtn.Name = "DeleteTabBtn";
            this.DeleteTabBtn.Size = new System.Drawing.Size(34, 33);
            this.DeleteTabBtn.Text = "Удалить вкладку";
            this.DeleteTabBtn.Click += new System.EventHandler(this.DeleteTabBtn_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 38);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1013, 532);
            this.MainTabControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 570);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackBtn;
        private System.Windows.Forms.ToolStripButton ForwardBtn;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripTextBox FavTabBtn;
        private System.Windows.Forms.ToolStripButton GoBtn;
        private System.Windows.Forms.ToolStripButton AddTabBtn;
        private System.Windows.Forms.ToolStripButton DeleteTabBtn;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripButton StopBtn;
    }
}

