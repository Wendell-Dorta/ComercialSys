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
    public partial class FrmClienteConsulta : Form
    {
        public FrmClienteConsulta()
        {
            InitializeComponent();
        }

        private void FrmClienteConsulta_Load(object sender, EventArgs e)
        {
            CarregaGridCliente();
        }
        private void CarregaGridCliente()
        {
            var clientes = Cliente.ObterLista();
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var cliente in clientes)
            {
                int rowIndex = dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = cliente.Id;
                dgvEnderecos.Rows[count].Cells[1].Value = cliente.Nome;
                dgvEnderecos.Rows[count].Cells[2].Value = cliente.Cpf;
                dgvEnderecos.Rows[count].Cells[3].Value = cliente.Telefone;
                dgvEnderecos.Rows[count].Cells[4].Value = cliente.Email;
                dgvEnderecos.Rows[count].Cells[5].Value = cliente.DataNasc;
                dgvEnderecos.Rows[count].Cells[6].Value = cliente.DataCad;
                dgvEnderecos.Rows[count].Cells[7].Value = cliente.Ativo;
                count++;
            }
        }
        private void CarregaGridEndereco(int clienteId)
        {
            var listaEnderecos = Endereco.ObterListaPorCliente(clienteId);
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var endereco in listaEnderecos)
            {
                int rowIndex = dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = endereco.Cep;
                dgvEnderecos.Rows[count].Cells[1].Value = endereco.Logradouro;
                dgvEnderecos.Rows[count].Cells[2].Value = endereco.Numero;
                dgvEnderecos.Rows[count].Cells[3].Value = endereco.Complemento;
                dgvEnderecos.Rows[count].Cells[4].Value = endereco.Bairro;
                dgvEnderecos.Rows[count].Cells[5].Value = endereco.Cidade;
                dgvEnderecos.Rows[count].Cells[6].Value = endereco.Uf;
                dgvEnderecos.Rows[count].Cells[7].Value = endereco.TipoEndereco;
                count++;
            }
        }

        private void dgvEnderecos_SelectionChanged(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(dgvEnderecos.Rows[dgvEnderecos.CurrentRow.Index].Cells[0].Value);
            CarregaGridEndereco(clienteId);
        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletearEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}