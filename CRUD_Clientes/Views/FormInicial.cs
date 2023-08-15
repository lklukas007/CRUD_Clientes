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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
