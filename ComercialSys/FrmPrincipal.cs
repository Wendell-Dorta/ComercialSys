using ComClassSys;

namespace ComercialSys
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(); /* objeto do tipo form de cliente */

            frmCliente.MdiParent = this; /* declara que esta instancia(c�pia) do form cliente, e filho do form principal,
                                            ent�o quando executar o form cliente ele aparece dentro do form principal */

            frmCliente.StartPosition = FormStartPosition.CenterScreen; /* Enum -> cole��o especial de valores para uma 
                                                                          determinada propriedade. */

            frmCliente.Show(); /* Como ShowDialog, so da para executar um conteudo depois de terminar a execu��o de outro
                                  bloqueando o uso de qualquer outra janela, exemplo, o programa so da para executar
                                  outras fun��es se fizer o login, pode ate ver as telas abaixo, porem n�o pode acessar */

        }

        private void usu�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin login = new();
            // login.MdiParent = this;
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
            // fazer uma variavel de conf que quando o login = true exibe a pagina principal
            this.Hide();
            tslUsuario.Text = Program.Usuario.Nome = " - " + Program.Usuario.Nivel.Nome;
        }
    }
}
