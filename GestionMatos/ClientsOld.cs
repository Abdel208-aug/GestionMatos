using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class ClientsOld : Form
    {
        public ClientsOld()
        {
            InitializeComponent();
        }
        bool Verif()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Saisie Nom !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    errorProvider2.SetError(textBox2, "Saisie l'email !");
                    return false;
                }
                else
                {
                    errorProvider2.Clear();
                    if (string.IsNullOrEmpty(textBox3.Text))
                    {
                        errorProvider3.SetError(textBox3, "Saisie le Tel !");
                        return false;
                    }
                    else
                    {
                        errorProvider3.Clear();
                        return true;
                    }
                }
            }
        }
        void FillListboxe()
        {
            listBox1.Items.Clear();
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("select * from Client",Sql.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                listBox1.Items.Add(reader["nomClient"]);
            Sql.disconnect();
        }
        void lastItem()
        {
            if (listBox1.SelectedItem==null)
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        SqlConn Sql = new SqlConn();
        private void Clients_Load(object sender, EventArgs e)
        {
            FillListboxe();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastItem();
            string selected = ((ListBox)sender).SelectedItem.ToString();
            string query = $"select * from Client where nomClient='{selected}'";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query,Sql.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["nomClient"].ToString();
                textBox2.Text = reader["mailClient"].ToString();
                textBox3.Text = reader["telClient"].ToString();
                textBox4.Text= reader["idClient"].ToString();
            }
            Sql.disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Verif())
            {
                string query = $"INSERT INTO Client VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}');";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query,Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListboxe();
                MessageBox.Show("Client bien ajouté !", "Ajouter");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Selectionnez un Client");
                return;
            }
            if (Verif())
            {
                string query = $"update Client set nomClient='{textBox1.Text}',mailClient='{textBox2.Text}'," +
                    $"telClient='{textBox3.Text}' where idClient={textBox4.Text};";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListboxe();
                MessageBox.Show("Client bien modifié !", "Modifier");
            }         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Selectionnez un Client");
                return;
            }
            if (Verif())
            {
                string query = $"delete from Client where idClient={textBox4.Text};";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ce client ne peut pas être supprimé.\nIl fait reference à un autre objet! ");
                    return;
                }
                
                Sql.disconnect();
                FillListboxe();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = null;
                listBox1.SelectedIndex = 0;
                MessageBox.Show("Client Supprimé !", "Supprimer");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
