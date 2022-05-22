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
        GMDB db = new GMDB();
        public int idUser { get; set; }
        public InterventionsFrm()
        {
            InitializeComponent();
        }
        void remplirGV()
        {
            dataGridView1.DataSource=db.Interventions.Select(i => new
            {
                i.idInter,
                i.datePlanifie,
                i.Materiel.nSerieMat,
                i.Materiel.Client.nomClient,
                i.etat,
                i.Commentaire
            }).ToList();
        }
        private void InterventionsFrm_Load(object sender, EventArgs e)
        {
            comboBox3.ValueMember="etat";
            comboBox3.DisplayMember="etat";
            comboBox3.DataSource= db.Interventions.Select(iq =>new { iq.etat }).Distinct().ToList();

            remplirGV();
            
            comboBox1.ValueMember="idMat";
            comboBox1.DisplayMember="nomMat";
            comboBox1.DataSource=db.Materiels.ToList();

            comboBox2.Items.Clear();
            comboBox2.Items.Add("réalisé");
            comboBox2.Items.Add("prévue");
            comboBox2.SelectedIndex=0;

            textBox1.Text="";
            dateTimePicker1.Value=DateTime.Now;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string etat = comboBox3.SelectedValue.ToString();
            dataGridView1.DataSource=db.Interventions.Select(i => new {
                i.idInter,
                i.datePlanifie,
                i.Materiel.nSerieMat,
                i.Materiel.Client.nomClient,
                i.etat,
                i.Commentaire
            }).Where(i => i.etat==etat).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int idMat = int.Parse(comboBox1.SelectedValue.ToString());
            db.Interventions.Add(new Intervention()
            {
                datePlanifie=dateTimePicker1.Value,
                C_idMat=idMat,
                C_idUser=idUser,
                Commentaire=textBox1.Text
            });
            db.SaveChanges();
            remplirGV();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int idInter = (int)dataGridView1.Rows[e.RowIndex].Cells["idInter"].Value;
            Intervention intervention = new Intervention();
            intervention = db.Interventions.Find(idInter);
            ModifIntervention modif = new ModifIntervention();
            modif.remplirText(intervention);
            if (modif.ShowDialog()==DialogResult.OK)
                remplirGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remplirGV();
        }
    }
}
