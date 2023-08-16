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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
            
        }


        private void FormLista_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.ColumnCount = 4; // Defina o número de colunas

            // Defina os cabeçalhos das colunas
            dataGridViewClientes.Columns[0].Name = "CodigoCliente";
            dataGridViewClientes.Columns[1].Name = "Nome Completo";
            dataGridViewClientes.Columns[2].Name = "Idade";
            dataGridViewClientes.Columns[3].Name = "Genero";
            CarregarLista();
        }
        public void CarregarLista()
        {
            dataGridViewClientes.Enabled = true;
            dataGridViewClientes.Visible = true;
            label_listaclientes.Enabled = true;
            label_listaclientes.Visible = true;
            // Criando uma instância da classe Funcoes_CRUD
            var funcoesCrud = new Funcoes_CRUD();

            List<ListaCliente_Model> listaClientes = funcoesCrud.BuscarCliente();

            dataGridViewClientes.Rows.Clear();

            foreach (ListaCliente_Model cliente in listaClientes)
            {
                dataGridViewClientes.Rows.Add(
                    cliente.CodigoCliente,
                    cliente.NomeCompleto,
                    cliente.Idade,
                    cliente.DescricaoGenero
                );
            }
        }

        private void btnAlterar_AbrirForm_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Crindo um objeto Cliente
                Cliente_Model alteraCliente = new Cliente_Model();

                DataGridViewRow selectedRow = dataGridViewClientes.SelectedRows[0];

                alteraCliente.CodigoCliente = Convert.ToInt32(selectedRow.Cells["CodigoCliente"].Value);
                int codigocliente = alteraCliente.CodigoCliente;
                FormAlterar formAlterar = new FormAlterar(codigocliente);
                formAlterar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para realizar a alteração!");
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Criando uma instância da classe Funcoes_CRUD
                var funcoesCrud = new Funcoes_CRUD();
                // Exibe uma MessageBox de confirmação
                DialogResult result = MessageBox.Show("Deseja realmente excluir este cadastro?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Crindo um objeto Cliente
                Cliente_Model alteraCliente = new Cliente_Model();

                DataGridViewRow selectedRow = dataGridViewClientes.SelectedRows[0];

                alteraCliente.CodigoCliente = Convert.ToInt32(selectedRow.Cells["CodigoCliente"].Value);
                if (result == DialogResult.Yes)
                {
                    funcoesCrud.ExcluirCliente(alteraCliente.CodigoCliente);
                    CarregarLista();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para realizar a exclusão!");
            }
        }
    }
}
