using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double? ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double? EstoqueMinimo { get; set; }
        public double? ClasseDesconto { get; set; }
        public string? Imagem { get; set; }
        public DateTime? DataCad { get; set; }

        public Produto()
        {
            Id = 0;
        }
        public Produto(int id, string codBarras, string descricao, double valorUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto, string imagem, DateTime dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public Produto(int id, string codBarras, string descricao, double valorUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto, DateTime dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            DataCad = dataCad;
        }
        public Produto(string codBarras)
        {
            CodBarras = codBarras;
        }
        public Produto(string codBarras, string descricao, double valorUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto, string imagem, DateTime dataCad)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public Produto(int id, string codBarras, string descricao, double valorUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }
        public Produto(string codBarras, string descricao, double valorUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Produto> ObterLista(string descricao = null)
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (descricao == null)
            {
                cmd.CommandText = "select * from produtos order by descricao";
            }
            else
            {
                cmd.CommandText = $"select * from produtos where nome like '%{descricao}%' order by descricao";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(
                    new Produto(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDouble(3),
                        dr.GetString(4),
                        Categoria.ObterPorId((5)),
                        dr.GetDouble(6),
                        dr.GetDouble(7),
                        dr.GetDateTime(8)
                    )
                );
            }

            return produto;
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId((5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    dr.GetDateTime(8)
                );
            }
            return produto;
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spId", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
    }
}