using CRUD_Clientes.Controllers;
using CRUD_Clientes.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

                novoCliente.Nome = txtNome.Text;
                novoCliente.Sobrenome = txtSobrenome.Text;
                novoCliente.Endereco = txtEndereco.Text;
                novoCliente.Numero = txtNumero.Text;

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

                // Tratamento genero da combobox, desde que o objeto nao seja nulo, ele vai converter: tostring
                string generoSelecionado = comboBox_Genero.SelectedItem?.ToString();
                if (generoSelecionado != null || !string.IsNullOrEmpty(generoSelecionado))
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

                if (!novoCliente.ValidaVazioNulo())
                {
                    MessageBox.Show("É obrigatório preencher todos os campos!");
                    return;
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
                MessageBox.Show("Falha ao cadastrar o cliente: ", ex.ToString());
            }

        }

    }
}