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
            FrmClienteNovo frmClienteNovo = new FrmClienteNovo(); /* objeto do tipo form de cliente */

            frmClienteNovo.MdiParent = this; /* declara que esta instancia(cópia) do form cliente, e filho do form principal,
                                            então quando executar o form cliente ele aparece dentro do form principal */

            frmClienteNovo.StartPosition = FormStartPosition.CenterScreen; /* Enum -> coleção especial de valores para uma 
                                                                          determinada propriedade. */

            frmClienteNovo.Show(); /* Como ShowDialog, so da para executar um conteudo depois de terminar a execução de outro
                                  bloqueando o uso de qualquer outra janela, exemplo, o programa so da para executar
                                  outras funções se fizer o login, pode ate ver as telas abaixo, porem não pode acessar */

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
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
            //login.StartPosition = FormStartPosition.CenterScreen;
            //login.ShowDialog();
            // fazer uma variavel de conf que quando o login = true exibe a pagina principal
            //this.Hide();
            //tslUsuario.Text = Program.Usuario.Nome = " - " + Program.Usuario.Nivel.Nome;
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClienteConsulta frmClienteConsulta = new FrmClienteConsulta();
            frmClienteConsulta.MdiParent = this;
            frmClienteConsulta.Show();
        }
    }
}
