namespace ComercialSys
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            operaçãoToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem2 = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            históricoToolStripMenuItem = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, operaçãoToolStripMenuItem, movimentoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtoToolStripMenuItem, usuárioToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem });
            clientesToolStripMenuItem.Image = Properties.Resources.User;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "C&lientes";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Image = Properties.Resources.AdItem2;
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "&Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem1, consultarToolStripMenuItem });
            produtoToolStripMenuItem.Image = Properties.Resources.skol;
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(180, 22);
            produtoToolStripMenuItem.Text = "&Produto";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Image = Properties.Resources.AdItem2;
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(180, 22);
            novoToolStripMenuItem1.Text = "&Novo";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Image = Properties.Resources.edicion_pegar_icono_4029_64;
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(180, 22);
            consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // operaçãoToolStripMenuItem
            // 
            operaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem });
            operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            operaçãoToolStripMenuItem.Size = new Size(70, 20);
            operaçãoToolStripMenuItem.Text = "&Operação";
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem2, buscarToolStripMenuItem, históricoToolStripMenuItem });
            pedidoToolStripMenuItem.Image = Properties.Resources._1911_64x64;
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(111, 22);
            pedidoToolStripMenuItem.Text = "&Pedido";
            // 
            // novoToolStripMenuItem2
            // 
            novoToolStripMenuItem2.Image = Properties.Resources.AdItem2;
            novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            novoToolStripMenuItem2.Size = new Size(122, 22);
            novoToolStripMenuItem2.Text = "&Novo";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Image = Properties.Resources.Search;
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(122, 22);
            buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // históricoToolStripMenuItem
            // 
            históricoToolStripMenuItem.Image = Properties.Resources.History;
            históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            históricoToolStripMenuItem.Size = new Size(122, 22);
            históricoToolStripMenuItem.Text = "&Histórico";
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.Image = Properties.Resources.caixareg_gif;
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(103, 22);
            caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Image = Properties.Resources.user_256;
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(180, 22);
            usuárioToolStripMenuItem.Text = "&Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "ComercialSys1.0 - Sistema de Adiministração Comercial";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem operaçãoToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem2;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem históricoToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
    }
}
