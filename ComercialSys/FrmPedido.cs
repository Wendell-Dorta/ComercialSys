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
            if (txtProdutoCodBarras.Text.Length > 4)
            {
                var produto = Produto.ObterPorCodigoDeBarras(int.Parse(txtProdutoCodBarras.Text));
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
                    double.Parse(txtProdQuantidade.Text),
                    0
                );
            itemPedido.Inserir();
        }
    }
}