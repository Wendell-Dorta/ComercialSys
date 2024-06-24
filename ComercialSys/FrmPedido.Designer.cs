namespace ComercialSys
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gbxCliente = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            txtClienteNome = new TextBox();
            txtClienteId = new TextBox();
            label2 = new Label();
            txtNumeroPedido = new TextBox();
            label5 = new Label();
            txtVendedor = new TextBox();
            btnAbrirPedido = new Button();
            gbxProduto = new GroupBox();
            txtProdQuantidade = new TextBox();
            txtProdValorUnit = new TextBox();
            txtProdDescricao = new TextBox();
            btnInserirItem = new Button();
            txtProdutoCodBarras = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnUnitVenda = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            btnFinalizarPedido = new Button();
            txtTotal = new TextBox();
            txtDesconto = new TextBox();
            txtOutros = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtSubTotal = new TextBox();
            label10 = new Label();
            txtDescontoItem = new TextBox();
            label14 = new Label();
            gbxCliente.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Pedido";
            // 
            // gbxCliente
            // 
            gbxCliente.Controls.Add(label4);
            gbxCliente.Controls.Add(label3);
            gbxCliente.Controls.Add(txtClienteNome);
            gbxCliente.Controls.Add(txtClienteId);
            gbxCliente.Location = new Point(12, 80);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Size = new Size(603, 87);
            gbxCliente.TabIndex = 1;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Dados Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 28);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 3;
            label3.Text = "ID";
            // 
            // txtClienteNome
            // 
            txtClienteNome.Location = new Point(100, 46);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.Size = new Size(437, 23);
            txtClienteNome.TabIndex = 1;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(6, 46);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(88, 23);
            txtClienteId.TabIndex = 0;
            txtClienteId.TextChanged += txtClienteId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(821, 18);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Número";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 24F);
            txtNumeroPedido.ForeColor = Color.Red;
            txtNumeroPedido.Location = new Point(821, 36);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(119, 50);
            txtNumeroPedido.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 54);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 3;
            label5.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(75, 51);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(296, 23);
            txtVendedor.TabIndex = 4;
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Location = new Point(496, 173);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(119, 30);
            btnAbrirPedido.TabIndex = 5;
            btnAbrirPedido.Text = "&Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            btnAbrirPedido.Click += btnAbrirPedido_Click;
            // 
            // gbxProduto
            // 
            gbxProduto.Controls.Add(label14);
            gbxProduto.Controls.Add(txtDescontoItem);
            gbxProduto.Controls.Add(txtProdQuantidade);
            gbxProduto.Controls.Add(txtProdValorUnit);
            gbxProduto.Controls.Add(txtProdDescricao);
            gbxProduto.Controls.Add(btnInserirItem);
            gbxProduto.Controls.Add(txtProdutoCodBarras);
            gbxProduto.Controls.Add(label7);
            gbxProduto.Controls.Add(label9);
            gbxProduto.Controls.Add(label8);
            gbxProduto.Controls.Add(label6);
            gbxProduto.Enabled = false;
            gbxProduto.Location = new Point(12, 202);
            gbxProduto.Name = "gbxProduto";
            gbxProduto.Size = new Size(603, 113);
            gbxProduto.TabIndex = 6;
            gbxProduto.TabStop = false;
            gbxProduto.Text = "Produto";
            // 
            // txtProdQuantidade
            // 
            txtProdQuantidade.Location = new Point(109, 81);
            txtProdQuantidade.Name = "txtProdQuantidade";
            txtProdQuantidade.Size = new Size(97, 23);
            txtProdQuantidade.TabIndex = 4;
            // 
            // txtProdValorUnit
            // 
            txtProdValorUnit.Location = new Point(6, 81);
            txtProdValorUnit.Name = "txtProdValorUnit";
            txtProdValorUnit.Size = new Size(97, 23);
            txtProdValorUnit.TabIndex = 4;
            // 
            // txtProdDescricao
            // 
            txtProdDescricao.Location = new Point(109, 37);
            txtProdDescricao.Name = "txtProdDescricao";
            txtProdDescricao.Size = new Size(488, 23);
            txtProdDescricao.TabIndex = 3;
            // 
            // btnInserirItem
            // 
            btnInserirItem.Font = new Font("Segoe UI", 10F);
            btnInserirItem.Location = new Point(484, 69);
            btnInserirItem.Name = "btnInserirItem";
            btnInserirItem.Size = new Size(113, 38);
            btnInserirItem.TabIndex = 7;
            btnInserirItem.Text = "&Inserir";
            btnInserirItem.UseVisualStyleBackColor = true;
            btnInserirItem.Click += btnInserirItem_Click;
            // 
            // txtProdutoCodBarras
            // 
            txtProdutoCodBarras.Location = new Point(6, 37);
            txtProdutoCodBarras.Name = "txtProdutoCodBarras";
            txtProdutoCodBarras.Size = new Size(97, 23);
            txtProdutoCodBarras.TabIndex = 2;
            txtProdutoCodBarras.TextChanged += txtProdutoCodBarras_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 19);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 1;
            label7.Text = "Descrição";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(109, 63);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 0;
            label9.Text = "Quantidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 63);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 0;
            label8.Text = "Valor Unitário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 0;
            label6.Text = "Código de Barras";
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnUnitVenda, clnValorUnit, clnQuantidade, clnDesconto, clnValorItem });
            dgvItensPedido.Location = new Point(12, 321);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPedido.Size = new Size(740, 184);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "Seq";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "CodBar";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnUnitVenda
            // 
            clnUnitVenda.Frozen = true;
            clnUnitVenda.HeaderText = "Unidade";
            clnUnitVenda.Name = "clnUnitVenda";
            clnUnitVenda.ReadOnly = true;
            clnUnitVenda.Width = 60;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 70;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 75;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 95;
            // 
            // clnValorItem
            // 
            clnValorItem.Frozen = true;
            clnValorItem.HeaderText = "Valor Item";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Location = new Point(821, 480);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(119, 25);
            btnFinalizarPedido.TabIndex = 7;
            btnFinalizarPedido.Text = "&Finalizar Pedido";
            btnFinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 19F);
            txtTotal.Location = new Point(821, 436);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(119, 41);
            txtTotal.TabIndex = 8;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(821, 348);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(119, 23);
            txtDesconto.TabIndex = 9;
            // 
            // txtOutros
            // 
            txtOutros.Location = new Point(821, 392);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(119, 23);
            txtOutros.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(879, 418);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 11;
            label11.Text = "Valor Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(897, 374);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 12;
            label12.Text = "Outros";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(854, 330);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 13;
            label13.Text = "Valor Desconto";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(821, 304);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(119, 23);
            txtSubTotal.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(859, 286);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 12;
            label10.Text = "Valor SubTotal";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Enabled = false;
            txtDescontoItem.Location = new Point(212, 81);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(100, 23);
            txtDescontoItem.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Enabled = false;
            label14.Location = new Point(212, 63);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 9;
            label14.Text = "Desconto";
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 517);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtSubTotal);
            Controls.Add(txtOutros);
            Controls.Add(txtDesconto);
            Controls.Add(txtTotal);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(dgvItensPedido);
            Controls.Add(gbxProduto);
            Controls.Add(btnAbrirPedido);
            Controls.Add(txtVendedor);
            Controls.Add(label5);
            Controls.Add(txtNumeroPedido);
            Controls.Add(gbxCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            gbxCliente.ResumeLayout(false);
            gbxCliente.PerformLayout();
            gbxProduto.ResumeLayout(false);
            gbxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbxCliente;
        private Label label2;
        private TextBox txtNumeroPedido;
        private Label label4;
        private Label label3;
        private TextBox txtClienteNome;
        private TextBox txtClienteId;
        private Label label5;
        private TextBox txtVendedor;
        private Button btnAbrirPedido;
        private GroupBox gbxProduto;
        private DataGridView dgvItensPedido;
        private Button btnFinalizarPedido;
        private TextBox txtTotal;
        private TextBox txtDesconto;
        private TextBox txtOutros;
        private TextBox txtProdQuantidade;
        private TextBox txtProdValorUnit;
        private TextBox txtProdDescricao;
        private Button btnInserirItem;
        private TextBox txtProdutoCodBarras;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtSubTotal;
        private Label label10;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnUnitVenda;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValorItem;
        private Label label14;
        private TextBox txtDescontoItem;
    }
}