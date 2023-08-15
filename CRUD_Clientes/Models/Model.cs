using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Clientes.Models
{
    public class Cliente_Model
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public int Codigo_Genero { get; set; }
    }

    public class Genero_Model
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }

    public class ListaCliente_Model
    {
        public int CodigoCliente { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string DescricaoGenero { get; set; }
    }


}
