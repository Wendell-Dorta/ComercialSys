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
    public partial class FrmClienteNovo : Form
    {
        public FrmClienteNovo()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cliente cliente = new Cliente(txtNome.Text, mxtCpf.Text, mxtTelefone.Text, txtEmail.Text, dtpDataNasc.Value);
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                MessageBox.Show($"Cliente {cliente.GetHashCode()} cadastrado com sucesso");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipoEnd = cmbTipoEndereco.SelectedText;
            tipoEnd = tipoEnd.Substring(0, 3);
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                    int.Parse(txtClienteId.Text),
                    mxtCep.Text,
                    txtLogradouro.Text,
                    txtNumero.Text,
                    txtComplemento.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    txtUf.Text,
                    tipoEnd
                    );
        }
    }
}