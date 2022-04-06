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
    public partial class Marques : Form
    {
        GMDBEntities db = new GMDBEntities();
        int id=-1;
        bool CheckClicked(int id)
        {
            if (id==-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Marques()
        {
            InitializeComponent();
        }

        private void Marques_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Marques.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Marques.Add(new Marque() { nomMrq = textBox1.Text });
            db.SaveChanges();
            dataGridView1.DataSource = db.Marques.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckClicked(id))
            {
                MessageBox.Show("Aucun maeriel est selectionné dans la liste !", "Suppression marque", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                Marque marque = db.Marques.Find(id);
                marque.nomMrq = textBox1.Text;
                db.SaveChanges();
                id = -1;
                dataGridView1.DataSource = db.Marques.ToList();
            }
            else
                errorProvider1.SetError(textBox1, "Chanmp vide !");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!CheckClicked(id))
            {
                MessageBox.Show("Aucun maeriel est selectionné dans la liste !","Suppression marque",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Voulez-vous vraiment continuer la suppression !","Suppression marque",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Marque marque = new Marque();
                marque = db.Marques.Find(id);
                db.Marques.Remove(marque);
                db.SaveChanges();
                id = -1;
                dataGridView1.DataSource = db.Marques.ToList();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
