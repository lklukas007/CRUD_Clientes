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
using Microsoft.IdentityModel.Tokens;

namespace CRUD_Clientes.Views
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            PreencherComboBoxForm();

        }
        
        public void PreencherComboBoxForm() 
        {
            // Criando uma instância da classe Funcoes_CRUD
            var funcoesCrud = new Funcoes_CRUD();

            // Chamando o método RetornaComboBox da instância de Funcoes_CRUD
            List<Genero_Model> listaGeneros = funcoesCrud.RetornaComboBox();

            // Adiciona os itens da listaGeneros no ComboBox
            foreach (Genero_Model genero in listaGeneros)
            {
                comboBox_Genero.Items.Add(genero.Descricao);
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
                if (!string.IsNullOrEmpty(txtNome.Text))
                {
                    novoCliente.Nome = txtNome.Text;
                }
                else
                {
                    MessageBox.Show("Campo Nome é obrigatório.");
                    return; // Encerra o if para aguardar campo obrigatorio ser preenchido
                }

                // Capturando valores da TextBox
                if (!string.IsNullOrEmpty(txtSobrenome.Text))
                {
                    novoCliente.Sobrenome = txtSobrenome.Text;
                }
                else
                {
                    MessageBox.Show("Campo Sobrenome é obrigatório.");
                    return; // Encerra o if para aguardar campo obrigatorio ser preenchido
                }

                // Capturando valores da TextBox
                if (!string.IsNullOrEmpty(txtEndereco.Text))
                {
                    novoCliente.Endereco = txtEndereco.Text;
                }
                else
                {
                    MessageBox.Show("Campo Endereco é obrigatório.");
                    return; // Encerra o if para aguardar campo obrigatorio ser preenchido
                }

                // Capturando valores da TextBox
                if (!string.IsNullOrEmpty(txtNumero.Text))
                {
                    novoCliente.Numero = txtNumero.Text;
                }
                else
                {
                    MessageBox.Show("Campo Número é obrigatório.");
                    return; // Encerra o if para aguardar campo obrigatorio ser preenchido
                }


                // Tratamento genero da combobox, desde que o objeto nao seja nulo, ele vai converter: tostring
                string generoSelecionado = comboBox_Genero.SelectedItem?.ToString();
                if(generoSelecionado != null || !string.IsNullOrEmpty(generoSelecionado))
                {
                    Genero_Model genero = new Genero_Model { Descricao = generoSelecionado }; // Crie um objeto Genero com a descrição selecionada

                    int codigoGenero = funcoesCrud.RetornaCodigoGenero(genero);
                    novoCliente.Codigo_Genero = codigoGenero;
                }
                else
                {
                    MessageBox.Show("Campo Gênero é obrigatório.");
                    return; // Encerra o if para aguardar campo obrigatorio ser preenchido
                }

                // Convertendo a string da TextBox para DateTime
                if (DateTime.TryParse(txtDatanascimento.Text, out DateTime dataNascimento))
                {
                    novoCliente.DataNascimento = dataNascimento;
                }
                else
                {
                    MessageBox.Show("Campo Data de nascimento é obrigatório.");
                    return; // Encerra o if para aguardar campo obrigatorio ser preenchido
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