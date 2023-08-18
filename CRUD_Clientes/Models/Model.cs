using Microsoft.IdentityModel.Tokens;
using System;
using System.Windows.Forms;

namespace CRUD_Clientes.Models
{
    public class Cliente_Model
    {
        public int CodigoCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public int Codigo_Genero { get; set; }

        public bool ValidaVazioNulo()
        {
            // Capturando valores da TextBox
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(Sobrenome))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(DataNascimento.ToString()))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(Endereco))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(Numero))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(Codigo_Genero.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class Genero_Model
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }

    public class ListaCliente_Model
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int CodigoCliente { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string DescricaoGenero { get; set; }
    }


}
