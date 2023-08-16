using CRUD_Clientes.Models;
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
            txtDatanascimento.Text = AlteraCliente.DataNascimento.ToString("dd/MM/yyyy");
            
        }

    }
}
