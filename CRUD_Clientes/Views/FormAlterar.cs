using CRUD_Clientes.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUD_Clientes.Controllers;

namespace CRUD_Clientes.Views
{
    public partial class FormAlterar : Form
    {
        private int codigocliente;
        public FormAlterar(int codigocliente)
        {
            InitializeComponent();
            this.codigocliente = codigocliente;
            CarregarCampos();
            PreencherComboBoxForm();
        }

        public void PreencherComboBoxForm()
        {
            // Criando uma instância da classe Funcoes_CRUD
            var funcoesCrud = new Funcoes_CRUD();

            // Chamando o método RetornaComboBox da instância de Funcoes_CRUD
            List<Genero_Model> listaGeneros = funcoesCrud.RetornaComboBox();

            Cliente_Model cliente = new Cliente_Model();
            cliente = funcoesCrud.RetornaClienteAlteracao(codigocliente);

            // Adiciona os itens da listaGeneros no ComboBox
            foreach (Genero_Model genero in listaGeneros)
            {
                comboBox_Genero.Items.Add(genero.Descricao);

                if (cliente.Codigo_Genero == genero.Codigo)
                {
                    comboBox_Genero.SelectedItem = genero.Descricao;
                }
            }

        }
        public void CarregarCampos()
        {
            // Criando uma instância da classe Funcoes_CRUD
            var funcoesCrud = new Funcoes_CRUD();
            // Crindo um objeto Cliente
            Cliente_Model AlteraCliente = new Cliente_Model();

            AlteraCliente = funcoesCrud.RetornaClienteAlteracao(codigocliente);

            //Atribuir valores aos campos:
            txtNome.Text = AlteraCliente.Nome;
            txtSobrenome.Text = AlteraCliente.Sobrenome;
            txtEndereco.Text = AlteraCliente.Endereco;
            txtNumero.Text = AlteraCliente.Numero;
            labelCodigoCliente.Text = "Código Cliente: " + codigocliente.ToString();
            txtDatanascimento.Text = AlteraCliente.DataNascimento.ToString("dd/MM/yyyy");


        }

        private void btnRealizaAlteracao_Click(object sender, EventArgs e)
        {
            var funcoesCrud = new Funcoes_CRUD();

            Cliente_Model alteraCliente = new Cliente_Model();

            // Capturando valores da TextBox
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                alteraCliente.Nome = txtNome.Text;
            }
            else
            {
                MessageBox.Show("Campo Nome é obrigatório.");
                return; // Encerra o if para aguardar campo obrigatorio ser preenchido
            }

            // Capturando valores da TextBox
            if (!string.IsNullOrEmpty(txtSobrenome.Text))
            {
                alteraCliente.Sobrenome = txtSobrenome.Text;
            }
            else
            {
                MessageBox.Show("Campo Sobrenome é obrigatório.");
                return; // Encerra o if para aguardar campo obrigatorio ser preenchido
            }

            // Capturando valores da TextBox
            if (!string.IsNullOrEmpty(txtEndereco.Text))
            {
                alteraCliente.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Campo Endereco é obrigatório.");
                return; // Encerra o if para aguardar campo obrigatorio ser preenchido
            }

            // Capturando valores da TextBox
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                alteraCliente.Numero = txtNumero.Text;
            }
            else
            {
                MessageBox.Show("Campo Número é obrigatório.");
                return; // Encerra o if para aguardar campo obrigatorio ser preenchido
            }

            // Convertendo a string da TextBox para DateTime
            if (DateTime.TryParse(txtDatanascimento.Text, out DateTime dataNascimento))
            {
                alteraCliente.DataNascimento = dataNascimento;
            }
            else
            {
                MessageBox.Show("Campo Data de nascimento é obrigatório.");
                return; // Encerra o if para aguardar campo obrigatorio ser preenchido
            }


            alteraCliente.CodigoCliente = codigocliente;
            // Tratamento genero da combobox, desde que o objeto nao seja nulo, ele vai converter: tostring
            string generoSelecionado = comboBox_Genero.SelectedItem?.ToString();
            if (generoSelecionado != null || !string.IsNullOrEmpty(generoSelecionado))
            {
                Genero_Model genero = new Genero_Model { Descricao = generoSelecionado }; // Crie um objeto Genero com a descrição selecionada

                int codigoGenero = funcoesCrud.RetornaCodigoGenero(genero);
                alteraCliente.Codigo_Genero = codigoGenero;
            }
            else
            {
                MessageBox.Show("Campo Gênero é obrigatório.");
                return; // Encerra o if para aguardar campo obrigatorio ser preenchido
            }

            // Exibe uma MessageBox de confirmação
            DialogResult result = MessageBox.Show("Deseja salvar alteração?", "Confirmação de Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Chamando o método EditarCliente da instância de Funcoes_CRUD
            if (result == DialogResult.Yes)
            {
                funcoesCrud.EditarCliente(alteraCliente);
                MessageBox.Show("Alteração salva com sucesso!");
                this.Close();
            }
            else
            {
                return;
            }

        }
    }
}
