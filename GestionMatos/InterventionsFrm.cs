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
    public partial class InterventionsFrm : Form
    {
        public InterventionsFrm()
        {
            InitializeComponent();
        }
        GMDB db = new GMDB();
        private void InterventionsFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= db.Interventions.ToList();
            comboBox1.ValueMember="idMat";
            comboBox1.DisplayMember="nomMat";
            comboBox1.DataSource=db.Materiels.ToList();
            comboBox2.ValueMember="etat";
            comboBox2.DisplayMember="etat";
            comboBox2.DataSource= db.Interventions.ToList();
            comboBox3.ValueMember="etat";
            comboBox3.DisplayMember="etat";
            comboBox3.DataSource= db.Interventions.ToList();
        }
    }
}
