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
using System.Windows.Forms;
using System.Transactions;
using System.Data.Common;

namespace CRUD_Clientes.Controllers
{
    public class Controller {

        public class Funcoes_CRUD
        {
            // Usando a string de conexão da classe de configuração
            string connectionString = Config.ConnectionString;


            // Cadastrar:
            public void InserirCliente(Cliente_Model cliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO clientes (Nome, Sobrenome, DataNascimento, Endereco, Numero_Endereco, Codigo_Genero) " +
                                   "VALUES (@Nome, @Sobrenome, @DataNascimento, @Endereco, @Numero_Endereco, @Codigo_Genero)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 3600;

                        command.Parameters.AddWithValue("@Nome", cliente.Nome);
                        command.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);
                        command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                        command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                        command.Parameters.AddWithValue("@Numero_Endereco", cliente.Numero);
                        command.Parameters.AddWithValue("@Codigo_Genero", cliente.Codigo_Genero);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Buscar:
            public List<ListaCliente_Model> BuscarCliente()
            {
                List<ListaCliente_Model> listaClientes = new List<ListaCliente_Model>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT C.Codigo AS CodigoCliente, C.Nome + ' ' + C.Sobrenome AS NomeCompleto, DATEDIFF(YEAR, C.Datanascimento, GETDATE()) AS Idade, G.Descricao FROM Clientes C INNER JOIN Genero G ON G.Codigo = C.Codigo_Genero";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 3600;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListaCliente_Model cliente = new ListaCliente_Model
                                {
                                    CodigoCliente = (int)reader["CodigoCliente"],
                                    NomeCompleto = reader["NomeCompleto"].ToString(),
                                    Idade = (int)reader["Idade"],
                                    DescricaoGenero = reader["Descricao"].ToString()
                                };

                                listaClientes.Add(cliente);
                            }
                        }
                    }
                }

                return listaClientes;
            }

            // Editar:
            public void EditarCliente(Cliente_Model cliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {

                        string query = "UPDATE Clientes SET Nome = @Nome, Sobrenome = @Sobrenome, Datanascimento = @DataNascimento, Endereco = @Endereco, Numero_Endereco = @Numero_Endereco, Codigo_Genero = @Codigo_Genero WHERE Codigo = @CodigoCliente";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Transaction = transaction;
                            command.CommandTimeout = 3600;

                            command.Parameters.AddWithValue("@CodigoCliente", cliente.CodigoCliente);
                            command.Parameters.AddWithValue("@Nome", cliente.Nome);
                            command.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);
                            command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                            command.Parameters.AddWithValue("@Numero_Endereco", cliente.Numero);
                            command.Parameters.AddWithValue("@Codigo_Genero", cliente.Codigo_Genero);

                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao atualiar o cadastro: " + ex.Message);
                    }
                }
                
            }

            // Excluir:
            public void ExcluirCliente(int codigocliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Clientes WHERE Codigo = @CodigoCliente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 3600;

                        command.Parameters.AddWithValue("@CodigoCliente", codigocliente);

                        command.ExecuteNonQuery();
                    }
                }
            }

            // Validação do Descricao Genero:
            public int RetornaCodigoGenero(Genero_Model genero)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Codigo FROM Genero WHERE Descricao = @Descricao";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 3600;

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


            // Carregar cliente tela de alteração:
            public Cliente_Model RetornaClienteAlteracao(int codigocliente)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT C.Codigo ,Nome ,Sobrenome ,Datanascimento ,Endereco ,Numero_Endereco ,Codigo_Genero FROM Clientes C LEFT JOIN Genero G ON G.Codigo = C.Codigo_Genero WHERE C.Codigo = @CodigoCliente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 3600;

                        command.Parameters.AddWithValue("@CodigoCliente", codigocliente);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Verifica se há uma linha para ler
                            {
                                Cliente_Model cliente = new Cliente_Model();
                                cliente.CodigoCliente = reader.GetInt32(reader.GetOrdinal("Codigo"));
                                cliente.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                                cliente.Sobrenome = reader.GetString(reader.GetOrdinal("Sobrenome"));
                                cliente.DataNascimento = reader.GetDateTime(reader.GetOrdinal("Datanascimento"));
                                cliente.Endereco = reader.GetString(reader.GetOrdinal("Endereco"));
                                cliente.Numero = reader.GetString(reader.GetOrdinal("Numero_Endereco"));
                                cliente.Codigo_Genero = reader.GetInt32(reader.GetOrdinal("Codigo_Genero"));

                                return cliente;
                            }
                            else
                            {
                                return null; // Não encontrou cliente com o código especificado
                            }
                        }
                    }
                }
            }

            // Preencher combobox de genero:
            public List<Genero_Model> RetornaComboBox()
            {
                List<Genero_Model> listaGeneros = new List<Genero_Model>();

                string connectionString = Config.ConnectionString;
                string query = "SELECT Codigo,Descricao FROM Genero";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 3600;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Genero_Model genero = new Genero_Model();
                                {
                                    genero.Codigo = (int)reader["Codigo"];
                                    genero.Descricao = reader["Descricao"].ToString();
                                }
                                listaGeneros.Add(genero);
                            }
                        }
                    }
                }
                return listaGeneros;
            }

        }
    }
}