using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Cliente
    {
        // propriedades da classe
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataCad { get; set; }
        public bool Ativo { get; set; }

        // metodos contrutores
        public Cliente() { }
        public Cliente(int id, string nome, string cpf, string telefone, List<Endereco> enderecos, DateTime dataNasc, DateTime dataCad, bool ativo) 
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Enderecos = enderecos;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;
        }
        public Cliente(string nome, string cpf, string telefone, List<Endereco> enderecos, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Enderecos = enderecos;
            DataNasc = dataNasc;
            DataCad = dataCad;
        }

        // metodos da classe
    }
}
