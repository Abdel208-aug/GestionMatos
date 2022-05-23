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
    public partial class ModifIntervention : Form
    {
        private int idIntervention { get; set; }
        GMDB db = new GMDB();
        bool edited = false;
        public ModifIntervention()
        {
            InitializeComponent();
        }
        public void remplirText(Intervention intervention)
        {
            idIntervention=intervention.idInter;
            dateTimePicker1.Value=intervention.datePlanifie;
            comboBox1.SelectedValue=intervention.C_idMat;
            comboBox2.SelectedValue=intervention.etat;
            textBox1.Text=intervention.etat;
        }
        private void ModifIntervention_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember="idMat";
            comboBox1.DisplayMember="nomMat";
            comboBox1.DataSource=db.Materiels.ToList();
            
            comboBox2.ValueMember="etat";
            comboBox2.DisplayMember="etat";
            comboBox2.DataSource=db.Interventions.Select(i=>i.etat).Distinct().ToList();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vaiment modifier cette intervention ?","Modification d'intervention",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var modifInterv = db.Interventions.Find(idIntervention);
                modifInterv.datePlanifie=dateTimePicker1.Value;
                modifInterv.C_idMat=int.Parse(comboBox1.SelectedValue.ToString());
                modifInterv.etat=comboBox2.SelectedValue.ToString();
                modifInterv.Commentaire=textBox1.Text;
                db.SaveChanges();
                edited=true;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vaiment supprimer cette intervention ?","Suppression d'intervention",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var sprmInterv = db.Interventions.Find(idIntervention);
                db.Interventions.Remove(sprmInterv);
                db.SaveChanges();
                edited=true;
            }

        }

        private void ModifIntervention_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(edited)
                DialogResult=DialogResult.OK;
        }
    }
}
