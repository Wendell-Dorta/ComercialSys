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

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBarras;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[8].Value = produto.DataCad;

                count++;
            }
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
                double.Parse(txtClasseDesconto.Text)
            );

            produto.Inserir();
            FrmProdutoNovo_Load(sender, e);
        } 
    }
}
