using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Clientes.Database
{
    public class ConectaDB
    {
        public static SqlConnection connectionString()
        {
            string connectionString = "Data Source=localhost,1434;Initial Catalog=CRUD_CLIENTES;User ID=sa;Password=inovafarmaI;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }


        public static void Iniciar_Conexao_BD()
        {
            var connection = connectionString();

            try
            {
                
                connection.Open();
                // Conexão bem-sucedida!
                MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!", "Conexão bem-sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Tratar possíveis erros de conexão.
                MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Certifique-se de fechar a conexão após o uso.
                connection.Close();
            }
        }
    }
}
