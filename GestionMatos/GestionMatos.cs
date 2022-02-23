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
        Clients clients = new Clients();
        Materiels materiels = new Materiels();
        Sites sites = new Sites();
        public GestionMatos()
        {
            InitializeComponent();
        }
        private void GestionMatoscs_Load(object sender, EventArgs e)
        {

        }
        private void gestionClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            materiels.Dispose();
            sites.Dispose();
            clients = new Clients();
            clients.MdiParent = this;
            clients.Dock = DockStyle.Fill;
            clients.Show();
        }

        private void gestionMatérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sites.Dispose();
            clients.Dispose();
            materiels= new Materiels();
            materiels.MdiParent = this;
            materiels.Dock = DockStyle.Fill;
            materiels.Show();
        }

        private void sitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients.Dispose();
            materiels.Dispose();
            sites = new Sites();
            sites.MdiParent = this;
            sites.Dock = DockStyle.Fill;
            sites.Show();
        }
    }
}
