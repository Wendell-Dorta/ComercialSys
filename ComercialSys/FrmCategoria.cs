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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(txtCategoria.Text, txtSigla.Text);
            categoria.Inserir();
            FrmCategoria_Load(sender, e);
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            var lista = Categoria.ObterLista();
            dgvCategoria.Rows.Clear();
            int count = 0;
            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
            foreach (var categoria in lista)
            {
                dgvCategoria.Rows.Add();
                dgvCategoria.Rows[count].Cells[0].Value = categoria.Id;
                dgvCategoria.Rows[count].Cells[1].Value = categoria.Nome;
                dgvCategoria.Rows[count].Cells[2].Value = categoria.Sigla;

                count++;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtCategoria.Clear();
                txtSigla.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Categoria categoria = Categoria.ObterPorId(int.Parse(txtId.Text));
                    txtCategoria.Text = categoria.Nome;
                    txtSigla.Text = categoria.Sigla;
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";
                    btnEditar.Enabled = true;
                    btnDeletar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(
                    int.Parse(txtId.Text),
                    txtCategoria.Text,
                    txtSigla.Text
                    );
            if (categoria.Editar(categoria.Id))
            {
                FrmCategoria_Load(sender, e);
                MessageBox.Show($"A categoria \" {categoria.Nome} \" foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar a categoria \" {categoria.Nome} \" !");
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new();
            categoria.Id = int.Parse(txtId.Text);
            string nome = txtCategoria.Text;
            if(categoria.Deletar(categoria.Id))
            {
                FrmCategoria_Load(sender, e);
                MessageBox.Show($"A categoria \" {nome} \" foi excluido com sucesso!");
            }
        }
    }
}
