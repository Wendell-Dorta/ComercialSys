﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComClassSys
{
    public class Pedido
    {
        // Propriedades
        public int Id { get; set; }
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime? Data { get; set; }
        public string? Status { get; set; }
        public double? Desconto { get; set; }
        List<ItemPedido> Itens { get; set; }

        // Métodos Construtores
        public Pedido () { }
        public Pedido (int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido (Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido (int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Itens = itens;
        }

        // Métodos da Classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar()); 
        }

        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            return cmd.ExecuteNonQuery()>0?true:false;
        }

        public bool Alterar(string status)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update pedidos set status = {status} where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        public static double CalcularPedido(int id)
        {

            return 0;
        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                pedido = new(
                        dr.GetInt32(0),
                        Usuario.ObterPorId((dr.GetInt32(1))),
                        Cliente.ObterPorId(dr.GetInt32(2)),
                        dr.GetDateTime(3),
                        dr.GetString(4),
                        dr.GetDouble(5),
                        ItemPedido.ObterListaPorPedido(dr.GetInt32(0)) 
                    );
            }

            return pedido;
        }

        public static List<Pedido> ObterPorClienteId(int ClienteId)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where cliente_id = {ClienteId}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pedidos.Add(new(
                        dr.GetInt32(0),
                        Usuario.ObterPorId((dr.GetInt32(1))),
                        Cliente.ObterPorId(dr.GetInt32(2)),
                        dr.GetDateTime(3),
                        dr.GetString(4),
                        dr.GetDouble(5),
                        ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    ));
            }

            return pedidos;
        }

        public static List<Pedido> ObterLista(string status = "")
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();

            if (status == "")
            {
                cmd.CommandText = "select * from pedidos";
            }
            else
            {          
                cmd.CommandText = $"select * from pedidos where status = {status}";              
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pedidos.Add(new(
                        dr.GetInt32(0),
                        Usuario.ObterPorId((dr.GetInt32(1))),
                        Cliente.ObterPorId(dr.GetInt32(2)),
                        dr.GetDateTime(3),
                        dr.GetString(4),
                        dr.GetDouble(5),
                        ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    ));
            }

            return pedidos;
        }
    }
}