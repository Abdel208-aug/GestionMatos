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
    public partial class Materiels : Form
    {
        // Table pour les données de la dataCidView
        DataTable dt = new DataTable();
        // Table pour les données des comboBoxs
        DataTable dtc = new DataTable();
        BindingSource binding = new BindingSource();
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adapter=new SqlDataAdapter();
        SqlConn sql = new SqlConn();
        public Materiels()
        {
            InitializeComponent();
        }
        //Fonction pour remplir ou rafraichir la datagridview
        void FillGrid()
        {
            dt.Clear();
            string query = "select "+
                                "nomMat 'Nom Materiel',"+
                                "nSerieMat 'N° Serie',"+
                                "MTBFMat MBTF,"+
                                "FORMAT(Date_Installation, 'd', 'fr-FR') 'date Installation',"+
                                "nomType 'Type',"+
                                "nomMrq Marque,"+
                                "nomClient Client,"+
                                "mailClient 'mail client',"+
                                "telClient 'tel client',"+
                                "nomSite 'Site',"+
                                "adresseSite 'Adresse Site',"+
                                "CPSite 'Code Postale',"+
                                "departementSite 'departement site' "+
                                "from Materiel m "+
                            "join typeMateriel tm on m.#ID_TypeMat=tm.idType "+
                            "join Marque mrq on m.#ID_Marque=mrq.idMrq "+
                            "join Client c on m.#ID_Client=c.idClient "+
                            "join [dbo].[Site] s on m.#ID_Site=s.idSite;";

            command.CommandText = query;
            command.Connection = sql.Conn;
            dt.Load(command.ExecuteReader());            
            binding.DataSource = dt;
            dataGridView1.DataSource = binding;
            dataGridView1.Refresh();
        }
        
        //Fonction pour remplir les comboboxs
        void FillCombo()
        {
            dtc.Clear();
            //remplir Combobox de type materiel
            string queryC = "select * from typeMateriel;";
            command.CommandText = queryC;
            dtc.Load(command.ExecuteReader());
            comboType.ValueMember = "idType";
            comboType.DisplayMember = "nomType";
            comboType.DataSource = dtc;

            dtc = new DataTable();
            //remplir Combobox de type Marque
            queryC = "select * from Marque;";
            command.CommandText = queryC;
            dtc.Load(command.ExecuteReader());
            comboMarque.ValueMember = "idMrq";
            comboMarque.DisplayMember = "nomMrq";
            comboMarque.DataSource = dtc;

            dtc = new DataTable();
            //remplir Combobox de type Client
            queryC = "select * from Client;";
            command.CommandText = queryC;
            dtc.Load(command.ExecuteReader());
            comboClient.ValueMember = "idClient";
            comboClient.DisplayMember = "nomClient";
            comboClient.DataSource = dtc;

            dtc = new DataTable();
            //remplir Combobox de type Site
            queryC = "select * from [dbo].[Site];";
            command.CommandText = queryC;
            dtc.Load(command.ExecuteReader());
            comboSite.ValueMember = "idSite";
            comboSite.DisplayMember = "nomSite";
            comboSite.DataSource = dtc;
        }
        bool CheckNSerie()
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorNSerie.SetError(textBox2,"Saisie le numero de serie");
                return false;
            }
            else
            {
                errorNSerie.Clear();
                return true;
            }
        }
        private void Materiels_Load(object sender, EventArgs e)
        {
            sql.Connect();
            FillGrid();
            FillCombo();
        }
        //
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string nSerie = dataGridView1.Rows[e.RowIndex].Cells["N° Serie"].Value.ToString();
            string query = $"select * from Materiel where nSerieMat='{nSerie}';";

            command.CommandText = query;
            command.Connection = sql.Conn;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader[1].ToString();
                textBox2.Text = reader[2].ToString();
                textBox3.Text = reader[3].ToString();
                dateTimePicker1.Value = DateTime.Parse(reader[4].ToString());
                comboType.SelectedValue = reader[5].ToString();
                comboSite.SelectedValue = reader[6].ToString();
                comboClient.SelectedValue = reader[7].ToString();
                comboMarque.SelectedValue = reader[8].ToString();
            }
            reader.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!CheckNSerie())
                return;
            string query = $"insert into materiel " +
                $"values ('{textBox1.Text}','{textBox2.Text}'," +
                $"{textBox3.Text},'{dateTimePicker1.Value}',{comboType.SelectedValue}," +
                $"{comboSite.SelectedValue},{comboClient.SelectedValue},{comboMarque.SelectedValue})";
            command.CommandText = query;
            command.Connection = sql.Conn;
            try
            {
                command.ExecuteNonQuery();
                FillGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!CheckNSerie())
                return;
            string query = $"update materiel set " +
                $"nomMat='{textBox1.Text}'," +
                $"nSerieMat='{textBox2.Text}'," +
                $"MTBFMat={textBox3.Text}," +
                $"Date_Installation='{dateTimePicker1.Value}'," +
                $"#ID_TypeMat={comboType.SelectedValue}," +
                $"#ID_Site={comboSite.SelectedValue}," +
                $"#ID_Client={comboClient.SelectedValue}," +
                $"#ID_Marque={comboMarque.SelectedValue} " +
                $"where nSerieMat='{textBox2.Text}'";
            command.CommandText = query;
            command.Connection = sql.Conn;
            try
            {
                command.ExecuteNonQuery();
                FillGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!CheckNSerie())
                return;
            string query = $"delete from materiel " +
                $"where nSerieMat='{textBox2.Text}'";
            command.CommandText = query;
            command.Connection = sql.Conn;
            try
            {
                command.ExecuteNonQuery();
                FillGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Materiels_FormClosing(object sender, FormClosingEventArgs e)
        {
            sql.disconnect();

        }
    }
}
