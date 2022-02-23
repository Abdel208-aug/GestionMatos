
namespace GestionMatos
{
    partial class GestionMatos
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
            this.gestionMatérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionMatérielToolStripMenuItem,
            this.gestionClientsToolStripMenuItem1,
            this.sitesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionMatérielToolStripMenuItem
            // 
            this.gestionMatérielToolStripMenuItem.Name = "gestionMatérielToolStripMenuItem";
            this.gestionMatérielToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.gestionMatérielToolStripMenuItem.Text = "Gestion Matériel";
            this.gestionMatérielToolStripMenuItem.Click += new System.EventHandler(this.gestionMatérielToolStripMenuItem_Click);
            // 
            // gestionClientsToolStripMenuItem1
            // 
            this.gestionClientsToolStripMenuItem1.Name = "gestionClientsToolStripMenuItem1";
            this.gestionClientsToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.gestionClientsToolStripMenuItem1.Text = "Gestion Clients";
            this.gestionClientsToolStripMenuItem1.Click += new System.EventHandler(this.gestionClientsToolStripMenuItem1_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "Sites";
            this.sitesToolStripMenuItem.Click += new System.EventHandler(this.sitesToolStripMenuItem_Click);
            // 
            // GestionMatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionMatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionMatoscs";
            this.Load += new System.EventHandler(this.GestionMatoscs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionClientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionMatérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
    }
}