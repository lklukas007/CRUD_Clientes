using CRUD_Clientes.Models;
using CRUD_Clientes.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CRUD_Clientes.DB;
using CRUD_Clientes.Views;

namespace CRUD_Clientes.Controllers
{
    public class Controller {

        public class Funcoes_CRUD
        {
            // Usando a string de conexão da classe de configuração
            string connectionString = Config.ConnectionString;


            // Cadastrar:
            public void InserirCliente(Cliente cliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO clientes (Nome, Sobrenome, DataNascimento, Endereco, Numero, Codigo_Genero) " +
                                   "VALUES (@Nome, @Sobrenome, @DataNascimento, @Endereco, @Numero, @Codigo_Genero)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", cliente.Nome);
                        command.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);
                        command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                        command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                        command.Parameters.AddWithValue("@Numero", cliente.Numero);
                        command.Parameters.AddWithValue("@Codigo_Genero", cliente.Codigo_Genero);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Atualizar:
            public void AtualizarCliente(Cliente cliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO clientes (Nome, Sobrenome, DataNascimento, Endereco, Numero, Codigo_Genero) " +
                                    "VALUES (@Nome, @Sobrenome, @DataNascimento, @Endereco, @Numero, @Codigo_Genero)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", cliente.Nome);
                        command.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);
                        command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                        command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                        command.Parameters.AddWithValue("@Numero", cliente.Numero);
                        command.Parameters.AddWithValue("@Codigo_Genero", cliente.Codigo_Genero);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Editar:
            public void EditarCliente(Cliente cliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO clientes (Nome, Sobrenome, DataNascimento, Endereco, Numero, Codigo_Genero) " +
                                   "VALUES (@Nome, @Sobrenome, @DataNascimento, @Endereco, @Numero, @Codigo_Genero)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", cliente.Nome);
                        command.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);
                        command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                        command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                        command.Parameters.AddWithValue("@Numero", cliente.Numero);
                        command.Parameters.AddWithValue("@Codigo_Genero", cliente.Codigo_Genero);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Excluir:
            public void ExcluirCliente(Cliente cliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO clientes (Nome, Sobrenome, GeneroId, DataNascimento, Endereco, Numero) " +
                                   "VALUES (@Nome, @Sobrenome, @GeneroId, @DataNascimento, @Endereco, @Numero)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", cliente.Nome);
                        command.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);

                        command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                        command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                        command.Parameters.AddWithValue("@Numero", cliente.Numero);
                        command.Parameters.AddWithValue("@Codigo_Genero", cliente.Codigo_Genero);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Validação do Genero:
            public int ValidaGenero(Genero genero)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Codigo FROM Genero WHERE Descicao = @Descricao";
                    int codigoGenero;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descricao", genero.Descricao);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int codigoGenero))
                        {
                            return codigoGenero; // Retorna o código do gênero válido
                        }
                        else
                        {
                            return -1; // Retorna um valor de código inválido, indicando que o gênero não foi encontrado ou ocorreu um erro de conversão
                        }
                    }
                }
            }

        }
    }
}