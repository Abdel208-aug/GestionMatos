
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
            this.interventionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMatérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interventionsToolStripMenuItem,
            this.gestionMatérielToolStripMenuItem,
            this.gestionClientsToolStripMenuItem1,
            this.sitesToolStripMenuItem,
            this.marquesToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // interventionsToolStripMenuItem
            // 
            this.interventionsToolStripMenuItem.Name = "interventionsToolStripMenuItem";
            this.interventionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.interventionsToolStripMenuItem.Text = "Interventions";
            this.interventionsToolStripMenuItem.Click += new System.EventHandler(this.interventionsToolStripMenuItem_Click);
            // 
            // gestionMatérielToolStripMenuItem
            // 
            this.gestionMatérielToolStripMenuItem.Name = "gestionMatérielToolStripMenuItem";
            this.gestionMatérielToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.gestionMatérielToolStripMenuItem.Text = "Matériels";
            this.gestionMatérielToolStripMenuItem.Click += new System.EventHandler(this.gestionMatérielToolStripMenuItem_Click);
            // 
            // gestionClientsToolStripMenuItem1
            // 
            this.gestionClientsToolStripMenuItem1.Name = "gestionClientsToolStripMenuItem1";
            this.gestionClientsToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.gestionClientsToolStripMenuItem1.Text = "Clients";
            this.gestionClientsToolStripMenuItem1.Click += new System.EventHandler(this.gestionClientsToolStripMenuItem1_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "Sites";
            this.sitesToolStripMenuItem.Click += new System.EventHandler(this.sitesToolStripMenuItem_Click);
            // 
            // marquesToolStripMenuItem
            // 
            this.marquesToolStripMenuItem.Name = "marquesToolStripMenuItem";
            this.marquesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.marquesToolStripMenuItem.Text = "Marques";
            this.marquesToolStripMenuItem.Click += new System.EventHandler(this.marquesToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // GestionMatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionMatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionMatoscs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionMatos_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem marquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
    }
}