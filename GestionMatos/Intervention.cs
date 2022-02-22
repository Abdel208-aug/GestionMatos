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
        DataTable InterTable = new DataTable();
        BindingSource InterBind = new BindingSource();
        SqlCommand sqlCommand = new SqlCommand();
        SqlConn Sql = new SqlConn();

        void FillGrid()
        {
            listIntr.Items.Clear();
            comboMateriel.Items.Clear();
            Sql.Connect();
            string drop = "select * from Intervention;";
            sqlCommand.CommandText = drop;
            sqlCommand.Connection = Sql.Conn;
            InterTable.Load(sqlCommand.ExecuteReader());
            InterBind.DataSource = InterTable;
            dataGridView1.DataSource = InterBind;

            Sql.disconnect();
        }
        private void Intervention_Load(object sender, EventArgs e)
        {
            FillGrid();
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

        private void btnAjt_Click(object sender, EventArgs e)
        {

        }
    }
}
