using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using MySqlX.XDevAPI;

namespace ComClassSys
{
    public class Cliente
    {
        // propriedades da classe
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public List<Endereco>? Enderecos { get; set; }
        public DateTime? DataNasc { get; set; }
        public DateTime DataCad { get; set; }
        public bool Ativo { get; set; }

        // metodos contrutores
        public Cliente() 
        {
            Id = 0;
        }
        public Cliente(int id, string nome, string cpf, string telefone, string email, List<Endereco> enderecos, DateTime dataNasc, DateTime dataCad, bool ativo) 
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Enderecos = enderecos;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;
        }
        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;
        }
        public Cliente(string nome, string cpf, string telefone, string email, DateTime dataNasc)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
        }
        public Cliente(string nome, string cpf, string telefone, string email, List<Endereco> enderecos, DateTime dataNasc, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Enderecos = enderecos;
            DataNasc = dataNasc;
            Ativo = ativo;
        }

        // metodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_cpf", Cpf);
            cmd.Parameters.AddWithValue("sp_telefone", Telefone);
            cmd.Parameters.AddWithValue("sp_email", Email);
            cmd.Parameters.AddWithValue("sp_data_nasc", DataNasc);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            // if (se) ternário
            //     [      condição      ] [?] então [:] senão
            return cmd.ExecuteNonQuery() > -1 ? true : false;

        }
        public static List<Cliente> ObterLista(string nome = null)
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == null)
            {
                cmd.CommandText = "select * from usuarios order by nome";
            }
            else
            {
                cmd.CommandText = $"select * from usuarios where nome like '%{nome}%' order by nome";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                                      dr.GetInt32(0),
                                      dr.GetString(1),
                                      dr.GetString(2),
                                      dr.GetString(3),
                                      dr.GetString(4),
                                      Endereco.ObterListaPorCliente(dr.GetInt32(0)),
                                      dr.GetDateTime(5),
                                      dr.GetDateTime(6),
                                      dr.GetBoolean(7)
                                     )
                         );
            }

            return lista;
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cliente = new(dr.GetInt32(0),
                              dr.GetString(1),
                              dr.GetString(2),
                              dr.GetString(3),
                              dr.GetString(4),
                              Endereco.ObterListaPorCliente(dr.GetInt32(0)),
                              dr.GetDateTime(5),
                              dr.GetDateTime(6),
                              dr.GetBoolean(7)
                             );
            }
            return cliente;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DataCad);
        }
    }
}
