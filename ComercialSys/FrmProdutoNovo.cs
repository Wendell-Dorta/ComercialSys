using ComClassSys;
using MySql.Data.MySqlClient;
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
    public partial class FrmProdutoNovo : Form
    {
        public FrmProdutoNovo()
        {
            InitializeComponent();
        }
        private void FrmProdutoNovo_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cbmCategoria.DataSource = categorias;
            cbmCategoria.DisplayMember = "nome";
            cbmCategoria.ValueMember = "id";
        }
        private void bntInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                txtCodBarras.Text,
                txtDescricao.Text,
                Convert.ToDouble(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue)),
                double.Parse(txtEstoqueMinimo.Text),
                double.Parse(txtClasseDesconto.Text),
                txtImagem.Text,
                DateTime.Now
            );

            produto.Inserir();
            FrmProdutoNovo_Load(sender, e);
        } 
    }
}
