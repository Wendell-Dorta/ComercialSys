using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = $"{Program.Usuario.Id}  -  {Program.Usuario.Nome}";
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteId.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));

                txtClienteNome.Clear();
                if (cliente.Id > 0)
                {
                    txtClienteNome.Text = cliente.Nome;
                }
            }
        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new();
            pedido.Cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));
            pedido.Usuario = Program.Usuario;
            pedido.Status = "A";
            pedido.Desconto = 0;
            pedido.Inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbxProduto.Enabled = true;
            btnAbrirPedido.Enabled = false;
        }

        private void txtProdutoCodBarras_TextChanged(object sender, EventArgs e)
        {
            if (txtProdutoCodBarras.Text.Length > 0)
            {
                var produto = Produto.ObterPorId(int.Parse(txtProdutoCodBarras.Text));
                if (produto.Id > 0)
                {
                    txtProdDescricao.Text = produto.Descricao;
                    txtProdValorUnit.Text = produto.ValorUnit.ToString();
                }
            }
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new(int.Parse(txtNumeroPedido.Text),
                    Produto.ObterPorId(int.Parse(txtProdutoCodBarras.Text)),
                    double.Parse(txtProdValorUnit.Text),
                    double.Parse(txtProdQuantidade.Text),                    
                    double.Parse(txtDescontoItem.Text)
                );
            itemPedido.Inserir();

            // limpar o dataGrid
            dgvItensPedido.Rows.Clear();
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtNumeroPedido.Text));

            int count = 0;
            double subtotal = 0;
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[count].Cells[0].Value = $"#{count + 1}"; // seq
                dgvItensPedido.Rows[count].Cells[1].Value = item.Produto.CodBarras; // codbar
                dgvItensPedido.Rows[count].Cells[2].Value = item.Produto.Descricao; // descrição
                dgvItensPedido.Rows[count].Cells[3].Value = item.Produto.UnidadeVenda; // unidade venda
                dgvItensPedido.Rows[count].Cells[4].Value = item.ValorUnit; // valor unitario
                dgvItensPedido.Rows[count].Cells[5].Value = item.Quantidade; // quantidade
                dgvItensPedido.Rows[count].Cells[6].Value = item.Desconto; // desconto
                dgvItensPedido.Rows[count].Cells[7].Value = item.ValorUnit * item.Quantidade - item.Desconto; // valor item


                subtotal += item.ValorUnit * item.Quantidade - item.Desconto;

                count++;
            }


            txtProdutoCodBarras.Clear();
            txtProdDescricao.Clear();
            txtProdQuantidade.Clear();
            txtProdValorUnit.Clear();
            txtDescontoItem.Clear();
        }
    }
}