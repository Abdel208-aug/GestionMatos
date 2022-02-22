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
        ClientsOld clients = new ClientsOld();
        Intervention intervention = new Intervention();
        Materiels materiels = new Materiels();
        public GestionMatos()
        {
            InitializeComponent();
        }
        private void GestionMatoscs_Load(object sender, EventArgs e)
        {

        }
        private void gestionClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            intervention.Dispose();
            materiels.Dispose();
            clients = new ClientsOld();
            clients.MdiParent = this;
            clients.Dock = DockStyle.Fill;
            clients.Show();
        }
        private void gestionInterventionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clients.Dispose();
            materiels.Dispose();
            intervention = new Intervention();
            intervention.MdiParent = this;
            intervention.Dock = DockStyle.Fill;
            intervention.Show();
        }

        private void gestionMatérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients.Dispose();
            intervention.Dispose();
            materiels= new Materiels();
            materiels.MdiParent = this;
            materiels.Dock = DockStyle.Fill;
            materiels.Show();
        }
    }
}
