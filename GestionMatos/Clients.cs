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
    public partial class Clients : Form
    {
        GMDBEntities db = new GMDBEntities();
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Clients.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Clients.Add(new Client(){
            nomClient=textBox2.Text,
            mailClient=textBox3.Text,
            telClient=textBox4.Text
            });
            db.SaveChanges();
            dataGridView1.DataSource = db.Clients.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Selectionner un client !");
                return;
            }
            int idC = int.Parse(textBox1.Text);
            Client c= db.Clients.Find(idC);
            c.nomClient = textBox2.Text;
            c.mailClient = textBox3.Text;
            c.telClient = textBox4.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Clients.ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int idC = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Client c = db.Clients.Find(idC);
            textBox1.Text = c.idClient.ToString();
            textBox2.Text = c.nomClient;
            textBox3.Text = c.mailClient;
            textBox4.Text = c.telClient;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Selectionner un client !");
                return;
            }
            int idC = int.Parse(textBox1.Text);
            Client c = db.Clients.Find(idC);
            db.Clients.Remove(c);
            db.SaveChanges();
            dataGridView1.DataSource = db.Clients.ToList();
        }
    }
}
