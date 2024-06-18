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
    public partial class FrmProdutoConsultar : Form
    {
        public FrmProdutoConsultar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtDescricao.Clear();
                txtCodBarras.Clear();
                txtValorUnit.Clear();
                txtImagem.Clear();
                txtUnidadeVenda.Clear();
                txtEstoqueMinimo.Clear();
                txtClasseDesconto.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    double valorUnit = double.Parse(txtValorUnit.Text);
                    double estoqueMinimo = double.Parse(txtEstoqueMinimo.Text);
                    double classeDesconto = double.Parse(txtClasseDesconto.Text);

                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    txtCodBarras.Text = produto.CodBarras;
                    txtDescricao.Text = produto.Descricao;
                    txtUnidadeVenda.Text = produto.UnidadeVenda;
                    valorUnit = produto.ValorUnit;
                    estoqueMinimo = produto.EstoqueMinimo;
                    classeDesconto = produto.ClasseDesconto;

                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";

                    cbmCategoria.SelectedValue = produto.Categoria.Id;
                    btnEditar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new();
            txtCatId.Text = Convert.ToString(categoria.Id);

            Produto produto = new (
                    int.Parse(txtId.Text),
                    txtCodBarras.Text,
                    txtDescricao.Text,
                    double.Parse(txtValorUnit.Text),
                    txtUnidadeVenda.Text,
                    Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue)),
                    double.Parse(txtEstoqueMinimo.Text),
                    double.Parse(txtClasseDesconto.Text)
            );

            if (produto.Editar(produto.Id))
            {
                FrmProdutoConsultar_Load(sender, e);
                MessageBox.Show($"O usuário {produto.Descricao} foi alterado com sucesso");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o usuário \" {produto.Descricao} \" !");
            }
        }

        private void FrmProdutoConsultar_Load(object sender, EventArgs e)
        {
            var categorias = Nivel.ObterLista();
            cbmCategoria.DataSource = categorias;
            cbmCategoria.DisplayMember = "descricao";
            cbmCategoria.ValueMember = "id";


            // List<Usuario> lista = Usuario.ObterLista(); <- tambem pode ser feito assim
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
                dgvProdutos.Rows[count].Cells[8].Value = produto.Imagem;
                dgvProdutos.Rows[count].Cells[9].Value = produto.DataCad;

                count++;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                var lista = Produto.ObterLista(txtBusca.Text);
                dgvProdutos.Rows.Clear();
                int count = 0;
                foreach (var produto in lista)
                {
                    dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                    dgvProdutos.Rows[count].Cells[1].Value = produto.CodBarras;
                    dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                    dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                    dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                    dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                    dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                    dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                    dgvProdutos.Rows[count].Cells[8].Value = produto.Imagem;
                    dgvProdutos.Rows[count].Cells[9].Value = produto.DataCad;

                    count++;
                }
            }
            else
            {
                FrmProdutoConsultar_Load(sender, e);
            }
        }
    }
}
