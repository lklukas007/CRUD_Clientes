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
using CRUD_Clientes.Controllers;

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

                Application.Run(new FormInicial());
            }
        }

        private void btnCadastro_AbrirForm_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }


        private void btnBuscar_AbrirForm_Click(object sender, EventArgs e)
        {
            FormLista formLista = new FormLista();
            formLista.ShowDialog();

        }
    }
}
