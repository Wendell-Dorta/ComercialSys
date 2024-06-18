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

            frmClienteNovo.MdiParent = this; /* declara que esta instancia(c�pia) do form cliente, e filho do form principal,
                                            ent�o quando executar o form cliente ele aparece dentro do form principal */

            frmClienteNovo.StartPosition = FormStartPosition.CenterScreen; /* Enum -> cole��o especial de valores para uma 
                                                                          determinada propriedade. */

            frmClienteNovo.Show(); /* Como ShowDialog, so da para executar um conteudo depois de terminar a execu��o de outro
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

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdutoNovo frmProdutoNovo = new FrmProdutoNovo();
            frmProdutoNovo.MdiParent = this;
            frmProdutoNovo.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoConsultar frmProdutoConsultar = new FrmProdutoConsultar();
            frmProdutoConsultar.MdiParent = this;
            frmProdutoConsultar.Show();
        }
    }
}
