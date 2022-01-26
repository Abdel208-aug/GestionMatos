
namespace GestionMatos
{
    partial class GestionMatoscs
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
            this.parametrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionInterventionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametrageToolStripMenuItem
            // 
            this.parametrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientsToolStripMenuItem,
            this.gestionInterventionsToolStripMenuItem});
            this.parametrageToolStripMenuItem.Name = "parametrageToolStripMenuItem";
            this.parametrageToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.parametrageToolStripMenuItem.Text = "Parametrage";
            // 
            // gestionClientsToolStripMenuItem
            // 
            this.gestionClientsToolStripMenuItem.Name = "gestionClientsToolStripMenuItem";
            this.gestionClientsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionClientsToolStripMenuItem.Text = "Gestion Clients";
            this.gestionClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionClientsToolStripMenuItem_Click);
            // 
            // gestionInterventionsToolStripMenuItem
            // 
            this.gestionInterventionsToolStripMenuItem.Name = "gestionInterventionsToolStripMenuItem";
            this.gestionInterventionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionInterventionsToolStripMenuItem.Text = "Gestion Interventions";
            this.gestionInterventionsToolStripMenuItem.Click += new System.EventHandler(this.gestionInterventionsToolStripMenuItem_Click);
            // 
            // GestionMatoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionMatoscs";
            this.Text = "GestionMatoscs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionInterventionsToolStripMenuItem;
    }
}