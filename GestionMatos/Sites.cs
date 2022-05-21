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
    public partial class Sites : Form
    {
        public Sites()
        {
            InitializeComponent();
        }
        GMDB db = new GMDB();

        private void Sites_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=db.Sites.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Sites.Add(new Site() {
                nomSite=textBox2.Text,
                departementSite=textBox3.Text,
                CPSite=textBox4.Text,
                adresseSite=textBox5.Text,
            });
            db.SaveChanges();
            dataGridView1.DataSource = db.Sites.ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int idS = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Site s = db.Sites.Find(idS);
            textBox1.Text = s.idSite.ToString();
            textBox2.Text = s.nomSite;
            textBox3.Text = s.departementSite;
            textBox4.Text = s.CPSite;
            textBox5.Text = s.adresseSite;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Selectionner un client !");
                return;
            }

            int idS = int.Parse(textBox1.Text);
            Site s = db.Sites.Find(idS);
            s.nomSite = textBox2.Text;
            s.departementSite = textBox3.Text;
            s.CPSite = textBox4.Text;
            s.adresseSite = textBox5.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Sites.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Selectionner un client !");
                return;
            }

            int idS = int.Parse(textBox1.Text);
            Site s = db.Sites.Find(idS);
            db.Sites.Remove(s);
            db.SaveChanges();
            dataGridView1.DataSource = db.Sites.ToList();
        }
    }
}
