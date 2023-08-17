using CRUD_Clientes.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD_Clientes.Controllers.Controller;

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
            txtDatanascimento.Text = AlteraCliente.DataNascimento.Value.ToString("dd/MM/yyyy");
            

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
                MessageBox.Show("Campo nome é obrigatório.");
                return; // Encerra o if para aguardar campo obrigatorio ser preenchido
            }
            alteraCliente.CodigoCliente = codigocliente;
            alteraCliente.Sobrenome = txtSobrenome.Text;
            alteraCliente.Endereco = txtEndereco.Text;
            alteraCliente.Numero = txtNumero.Text;
            // Convertendo a string da TextBox para DateTime
            if (DateTime.TryParse(txtDatanascimento.Text, out DateTime dataNascimento))
            {
                alteraCliente.DataNascimento = dataNascimento;
            }
            else
            {
                txtDatanascimento.Text = null;
            }

            // Tratamento genero da combobox, desde que o objeto nao seja nulo, ele vai converter: tostring
            string generoSelecionado = comboBox_Genero.SelectedItem?.ToString();

            Genero_Model genero = new Genero_Model { Descricao = generoSelecionado }; // Crie um objeto Genero com a descrição selecionada

            int? codigoGenero = funcoesCrud.RetornaCodigoGenero(genero);

            alteraCliente.Codigo_Genero = codigoGenero;

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
