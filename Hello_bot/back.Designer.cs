
namespace Hello_bot
{
    partial class back
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(back));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moons挨拶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moons挨拶ToolStripMenuItem,
            this.オプションToolStripMenuItem1,
            this.終了ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 100);
            // 
            // moons挨拶ToolStripMenuItem
            // 
            this.moons挨拶ToolStripMenuItem.Name = "moons挨拶ToolStripMenuItem";
            this.moons挨拶ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.moons挨拶ToolStripMenuItem.Text = "Moons 挨拶";
            this.moons挨拶ToolStripMenuItem.Click += new System.EventHandler(this.moons挨拶ToolStripMenuItem_Click);
            // 
            // オプションToolStripMenuItem1
            // 
            this.オプションToolStripMenuItem1.Name = "オプションToolStripMenuItem1";
            this.オプションToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.オプションToolStripMenuItem1.Text = "オプション";
            this.オプションToolStripMenuItem1.Click += new System.EventHandler(this.オプションToolStripMenuItem1_Click);
            // 
            // 終了ToolStripMenuItem1
            // 
            this.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            this.終了ToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.終了ToolStripMenuItem1.Text = "終了";
            this.終了ToolStripMenuItem1.Click += new System.EventHandler(this.終了ToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Moons 挨拶";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "back";
            this.Text = "挨拶Bot";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moons挨拶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オプションToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}