namespace DotNet_QuanLyBanHang_NguyenDVinhKhang
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.quảnLýKhoToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip2";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themSảnPhẩmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // themSảnPhẩmToolStripMenuItem
            // 
            this.themSảnPhẩmToolStripMenuItem.Name = "themSảnPhẩmToolStripMenuItem";
            this.themSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themSảnPhẩmToolStripMenuItem.Text = "Thêm Sản Phẩm";
            this.themSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.themSảnPhẩmToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.quảnLýKhoToolStripMenuItem.Text = "Quản Lý Kho";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "Form Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}