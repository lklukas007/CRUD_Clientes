using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Clientes.Database;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Clientes.Views
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnRealizaCadastro_Click(object sender, EventArgs e)
        {

            try {
                string Nome = txtNome.Text;
                string Sobrenome = txtSobrenome.Text;
                string Datanascimento = txtDatanascimento.Text;
                string Endereco = txtEndereco.Text;
                string Numero_Endereco = txtNumero.Text;
                //string Codigo_Genero = 1;
                string sqlInsert = "INSERT INTO Clientes(Nome ,Sobrenome ,Datanascimento ,Endereco ,Numero_Endereco ,Codigo_Genero) VALUES (@Nome, @Sobrenome, @Datanascimento, @Endereco, @Numero_Endereco, @Codigo_Genero)";
                
                SqlCommand command = new SqlCommand(sqlInsert);
                command.Parameters.AddWithValue("@Nome", Nome);
                command.Parameters.AddWithValue("@Sobrenome", Sobrenome);
                command.Parameters.AddWithValue("@Datanascimento", Datanascimento);
                command.Parameters.AddWithValue("@Endereco", Endereco);
                command.Parameters.AddWithValue("@Numero_Endereco", Numero_Endereco);
                //command.Parameters.AddWithValue("@Codigo_Genero", Codigo_Genero);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex){
                MessageBox.Show("Erro ao realizar o cadastro do cliente: " + ex.Message, " - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void FormCadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRUD_CLIENTESDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.cRUD_CLIENTESDataSet.Genero);

        }
    }
}
