using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class GestionMatos : Form
    {
        InterventionsFrm interventions = new InterventionsFrm();
        Clients clients = new Clients();
        Materiels materiels = new Materiels();
        Sites sites = new Sites();
        Marques marque = new Marques();
        Connexion connexion = new Connexion();

        void CloseChildrens()
        {
            foreach (var it in MdiChildren)
            {
                it.Dispose();
            }
        }
        public GestionMatos()
        {
            InitializeComponent();
        }
        private void GestionMatoscs_Load(object sender, EventArgs e)
        {
            interventions = new InterventionsFrm();
            interventions.MdiParent = this;
            interventions.Dock = DockStyle.Fill;
            interventions.Show();
        }
        private void gestionClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseChildrens();
            clients = new Clients();
            clients.MdiParent = this;
            clients.Dock = DockStyle.Fill;
            clients.Show();
        }

        private void gestionMatérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildrens();
            materiels = new Materiels();
            materiels.MdiParent = this;
            materiels.Dock = DockStyle.Fill;
            materiels.Show();
        }

        private void sitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildrens();
            sites = new Sites();
            sites.MdiParent = this;
            sites.Dock = DockStyle.Fill;
            sites.Show();
        }

        private void marquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildrens();
            marque = new Marques();
            marque.MdiParent = this;
            marque.Dock = DockStyle.Fill;
            marque.Show();
        }

        private void interventionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildrens();
            interventions = new InterventionsFrm();
            interventions.MdiParent = this;
            interventions.Dock = DockStyle.Fill;
            interventions.Show();
        }

        private void GestionMatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connexion.Show();
            Dispose();
        }
    }
}
