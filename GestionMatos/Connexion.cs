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
    public partial class Connexion : Form
    {
        
        public Connexion()
        {
            InitializeComponent();
        }
        GMDB db = new GMDB();
        bool verifLogins()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "L'identifiant est vide !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    errorProvider2.SetError(textBox2, "Mot de passe est vide");
                    return false;
                }
                errorProvider2.Clear();
                return true;
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (verifLogins())
            {
                string login = textBox1.Text, pass = textBox2.Text;
                User user = new User();
                user = db.Users.Where(u => u.loginUser==login && u.passwordUser==pass).FirstOrDefault();

                if (user==null)
                    MessageBox.Show("les identifiant incorrect !");
                else
                {
                    GestionMatos gestion = new GestionMatos();
                    this.Hide();
                    gestion.Show();
                }
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }
    }
}
