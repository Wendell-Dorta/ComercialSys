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


            // List<Usuario> lista = Usuario.ObterLista(); <- tambem pode ser feito assim
            var lista = Usuario.ObterLista();
            dgvUsuarios.Rows.Clear();
            int count = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                // dgvUsuarios.CurrentRow.Index
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[count].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[count].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";
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
                }
            }
        }
    }
}