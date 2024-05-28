using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Net.Http.Headers;
using MySqlX.XDevAPI;

namespace ComClassSys
{
    public class Endereco
    {
        // propriedades da classe
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        // metodos contrutores
        public Endereco() { }
        public Endereco(int id, int cliente, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipoEndereco)
        {
            Id = id;
            ClienteId = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco(int clienteId,string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipoEndereco)
        {
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        // metodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);
            cmd.ExecuteNonQuery();
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);
            // if (se) ternário
            //     [      condição      ] [?] então [:] senão
            return cmd.ExecuteNonQuery() > -1 ? true : false;


        }
        public bool Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            // if (se) ternário
            //     [      condição      ] [?] então [:] senão
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static List<Endereco> ObterListaPorCliente(int clientId)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"select * from enderecos where cliente_id = {clientId} order by logradouro";
            var dr = cmd.ExecuteReader();

            return enderecos;
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9)
                    );
            }
            return endereco;
        }
    }
}
