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
            try
            {
                // Criando uma instância da classe Funcoes_CRUD
                var funcoesCrud = new Funcoes_CRUD();

                // Crindo um objeto Cliente
                Cliente_Model novoCliente = new Cliente_Model();
                // Capturando valores da TextBox
                novoCliente.Nome = txtNome.Text;
                novoCliente.Sobrenome = txtSobrenome.Text;
                novoCliente.Endereco = txtEndereco.Text;
                novoCliente.Numero = txtNumero.Text;

                string generoSelecionado = comboBox_Genero.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(generoSelecionado))
                {
                    Genero_Model genero = new Genero_Model { Descricao = generoSelecionado }; // Crie um objeto Genero com a descrição selecionada

                    int codigoGenero = funcoesCrud.RetornaGenero(genero);

                    if (codigoGenero != -1)
                    {
                        novoCliente.Codigo_Genero = codigoGenero;
                    }
                    else
                    {
                        MessageBox.Show("Gênero selecionado é inválido.");
                    }
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

                //Limpar campos:
                txtNome.Text = "";
                txtSobrenome.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtDatanascimento.Text = "";
                comboBox_Genero.SelectedItem = null;

                MessageBox.Show("Cadastro Realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar o cliente: ",ex.ToString());
            }

        }

    }
}