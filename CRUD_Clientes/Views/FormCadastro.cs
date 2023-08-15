using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CRUD_Clientes.Controllers;
using CRUD_Clientes.DB;
using CRUD_Clientes.Models;

namespace CRUD_Clientes.Views
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            PreencherComboBox();

        }
        // Preencher combobox de genero:
        public void PreencherComboBox()
        {
            string connectionString = Config.ConnectionString;
            string query = "SELECT Descricao FROM Genero";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_Genero.Items.Add(reader["Descricao"].ToString());
                    }
                }
            }
        }


        private void btnRealizaCadastro_Click(object sender, EventArgs e)
        {
            Genero generoSelecionado = comboBox_Genero.SelectedItem as Genero;
            if (generoSelecionado != null)
            {
                int codigo = generoSelecionado.Codigo;
                string descricao = generoSelecionado.Descricao;
                MessageBox.Show(generoSelecionado.ToString());
            }
            


        }

    }
}
