using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace ComClassSys
{
    public class ItemPedido
    {
        // Propriedades
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        // Métodos Construtores
        public ItemPedido() 
        {
                
        }
        public ItemPedido(int id, int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int pedidoId, Produto produto, double quantidade, double desconto)
        {
            PedidoId = pedidoId;
            Produto = produto;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        //Métodos da classe

        // Manter Itens de Pedido

        // Inserir Itens
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id", PedidoId);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Consultar Item (Obter por id Pedido e id Produto)
        public static ItemPedido ObterItem(int pedidoId, int produtoId)
        {
            ItemPedido itemPedido = new();



            return itemPedido;
        }

        public static List<ItemPedido> ObterListaPorPedido(int pedidoId)
        {
            List<ItemPedido> itens = new();
            var cmd = Banco.Abrir();           
            cmd.CommandText = $"select * from itempedido where pedido_id = {pedidoId}";
            var dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                itens.Add(new(
                            dr.GetInt32(0),
                            dr.GetInt32(1),
                            Produto.ObterPorId(dr.GetInt32(2)),
                            dr.GetDouble(3),
                            dr.GetDouble(4),
                            dr.GetDouble(5)
                        )
                    );
            }
            

            return itens;
        }

        // Alterar Item
        public bool Alterar(int id)
        {
            return true;
        }

        // Excluir
        public void Remover(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }
    }
}