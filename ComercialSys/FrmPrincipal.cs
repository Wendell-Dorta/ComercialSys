namespace ComercialSys
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(); /* objeto do tipo form de cliente */

            frmCliente.MdiParent = this; /* declara que esta instancia(cópia) do form cliente, e filho do form principal,
                                            então quando executar o form cliente ele aparece dentro do form principal */

            frmCliente.StartPosition = FormStartPosition.CenterScreen; /* Enum -> coleção especial de valores para uma 
                                                                          determinada propriedade. */

            frmCliente.Show(); /* Como ShowDialog, so da para executar um conteudo depois de terminar a execução de outro
                                  bloqueando o uso de qualquer outra janela, exemplo, o programa so da para executar
                                  outras funções se fizer o login, pode ate ver as telas abaixo, porem não pode acessar */

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }
    }
}
