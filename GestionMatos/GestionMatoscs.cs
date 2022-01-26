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
    public partial class GestionMatoscs : Form
    {
        public GestionMatoscs()
        {
            InitializeComponent();
        }
        Form form = new Form();
        private void gestionClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Clients clients = new Clients();
            clients.MdiParent = this;
            clients.Dock = DockStyle.Fill;
            clients.Show();
        }

        private void gestionInterventionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Intervention intervention = new Intervention();
            intervention.MdiParent = this;
            intervention.Dock = DockStyle.Fill;
            intervention.Show();
        }
    }
}
