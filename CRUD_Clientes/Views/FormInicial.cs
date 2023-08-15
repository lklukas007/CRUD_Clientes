using CRUD_Clientes.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Clientes.DB;
using CRUD_Clientes.Models;
using System.Reflection;
using static CRUD_Clientes.Controllers.Controller;

namespace CRUD_Clientes
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Config.ConnectionString = "Data Source=localhost,1434;Initial Catalog=CRUD_CLIENTES;User ID=sa;Password=inovafarmaI;TrustServerCertificate=True;";

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Crie uma instância do seu Form principal aqui e o exiba
                Application.Run(new FormInicial());
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void FormCRUD_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.ColumnCount = 4; // Defina o número de colunas

            // Defina os cabeçalhos das colunas
            dataGridViewClientes.Columns[0].Name = "Código Cliente";
            dataGridViewClientes.Columns[1].Name = "Nome Completo";
            dataGridViewClientes.Columns[2].Name = "Idade";
            dataGridViewClientes.Columns[3].Name = "Gënero";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
    }
}
