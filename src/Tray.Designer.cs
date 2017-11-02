namespace Seb.NET.WeekTray
{
    partial class Tray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tray));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
            this.trayIcon.Text = "WeekTray";
            this.trayIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.Add(this.menuItemClose);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 76);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(145, 22);
            this.menuItemClose.Text = "&Close";
            this.menuItemClose.Click += this.OnMenuItemCloseClick;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300000;
            this.timer.Tick += this.OnTimerTick;
            // 
            // Tray
            // 
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrayForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Time Tray";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
        public System.Windows.Forms.Timer timer;
    }
}