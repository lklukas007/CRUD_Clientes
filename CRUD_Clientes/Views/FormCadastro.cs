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
using static CRUD_Clientes.Controllers.Controller;

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
            string query = "SELECT Codigo,Descricao FROM Genero";

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
            // Criando uma instância da classe Funcoes_CRUD
            var funcoesCrud = new Funcoes_CRUD();

            // Crindo um objeto Cliente
            Cliente novoCliente = new Cliente();
            // Capturando valores da TextBox
            novoCliente.Nome = txtNome.Text;
            novoCliente.Sobrenome = txtSobrenome.Text;
            novoCliente.Endereco = txtEndereco.Text;
            novoCliente.Numero = txtNumero.Text;

            string generoselecionado = comboBox_Genero.SelectedItem.ToString();
            // Verificando se algum item foi selecionado
            if (generoselecionado != null)
            {

                // Chamando o método de validação de genero
                funcoesCrud.RetornaGenero(generoselecionado);
            }
            else
            {
                MessageBox.Show("Selecione um gênero.");
            }

            // Convertendo a string da TextBox para DateTime
            if (DateTime.TryParse(txtDatanascimento.Text, out DateTime dataNascimento))
            {
                novoCliente.DataNascimento = dataNascimento;
            }
            else
            {
                MessageBox.Show("Data de nascimento inválida");
                return; // Sai do evento, pois a data é inválida
            }

            
            // Chamando o método InserirCliente da instância de Funcoes_CRUD
            funcoesCrud.InserirCliente(novoCliente);

        }

    }
}