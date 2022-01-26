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
    public partial class Intervention : Form
    {
        public Intervention()
        {
            InitializeComponent();
        }
        SqlConn Sql = new SqlConn();

        void FillListboxe()
        {
            listIntr.Items.Clear();
            comboMateriel.Items.Clear();
            Sql.Connect();
            string drop = "select idMat,nomMat from Materiel";
            SqlCommand command = new SqlCommand(drop, Sql.Conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboMateriel.Items.Add(reader["nomMat"].ToString());
            }

            reader.Close();

            string query = "select * from Intervention";
            command.CommandText = query;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                listIntr.Items.Add(reader["datePlanifie"].ToString());
            }

            Sql.disconnect();
        }
        private void Intervention_Load(object sender, EventArgs e)
        {
            FillListboxe();
        }

        private void listIntr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sql.Connect();

            string query = "select * from Intervention i inner join Materiel m on i.#idMat=m.idMat where ";
            SqlCommand command = new SqlCommand(query,Sql.Conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listIntr.Items.Add(reader["datePlanifie"].ToString());
            }

            Sql.disconnect();
        }
    }
}
