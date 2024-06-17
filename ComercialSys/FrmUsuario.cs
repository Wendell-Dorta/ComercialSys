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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //string nivel = String.Empty;
            //nivel = cmbNivel.SelectedIndex == 0 ? "A" : "G"; // if ternario
            /* linhas retiradas, deixei aq so pra poder estudar depois */

            Usuario usuario = new Usuario(
                                          txtNome.Text,
                                          txtEmail.Text,
                                          txtSenha.Text,
                                          Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                                         );
            usuario.Inserir();

            FrmUsuario_Load(sender, e); // <- Recarrega o formulario quando cadastra

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "nome";
            cmbNivel.ValueMember = "id";


            // List<Usuario> lista = Usuario.ObterLista(); <- tambem pode ser feito assim
            var lista = Usuario.ObterLista();
            dgvUsuario.Rows.Clear();
            int count = 0;
            foreach (var usuario in lista)
            {
                dgvUsuario.Rows.Add();
                // dgvUsuarios.CurrentRow.Index
                dgvUsuario.Rows[count].Cells[0].Value = usuario.Id;
                dgvUsuario.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUsuario.Rows[count].Cells[2].Value = usuario.Email;
                dgvUsuario.Rows[count].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuario.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtNome.Clear(); // limpa o campo Nome
                txtEmail.Clear();// limpa o campo Email
                txtSenha.Clear(); // limpa o campo Senha
                txtConfSenha.Clear(); // limpa o campo Confirmar Senha
                txtId.ReadOnly = false; // Habilita a edição no campo Id
                txtId.Focus(); // deixa o campo id com foco
                btnConsultar.Text = "&Obter por ID";
                txtSenha.PlaceholderText = string.Empty;
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Usuario usuario = Usuario.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";
                    txtSenha.PlaceholderText = "[senha não alterada]";

                    cmbNivel.SelectedValue = usuario.Nivel.Id;
                    btnEditar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(
                    int.Parse(txtId.Text),
                    txtNome.Text,
                    txtEmail.Text,
                    txtSenha.Text,
                    Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)),
                    true);
            if (usuario.Editar(usuario.Id))
            {
                FrmUsuario_Load(sender, e);
                MessageBox.Show($"O usuário {usuario.Nome} foi alterado com sucesso");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o usuário \" {usuario.Nome} \" !");
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                var lista = Usuario.ObterLista(txtBusca.Text);
                dgvUsuario.Rows.Clear();
                int count = 0;
                foreach (var usuario in lista)
                {
                    dgvUsuario.Rows.Add();
                    dgvUsuario.Rows[count].Cells[0].Value = usuario.Id;
                    dgvUsuario.Rows[count].Cells[1].Value = usuario.Nome;
                    dgvUsuario.Rows[count].Cells[2].Value = usuario.Email;
                    dgvUsuario.Rows[count].Cells[3].Value = usuario.Nivel.Nome;
                    dgvUsuario.Rows[count].Cells[4].Value = usuario.Ativo;

                    count++;
                }
            }
            else
            {
                FrmUsuario_Load(sender, e);
            }
        }
    }
}