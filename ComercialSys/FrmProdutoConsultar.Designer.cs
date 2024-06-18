namespace ComercialSys
{
    partial class FrmProdutoConsultar
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
            groupBox2 = new GroupBox();
            label2 = new Label();
            dtpDataCad = new DateTimePicker();
            btnConsultar = new Button();
            btnEditar = new Button();
            txtValorUnit = new TextBox();
            cbmCategoria = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtClasseDesconto = new TextBox();
            txtEstoqueMinimo = new TextBox();
            label9 = new Label();
            txtCodBarras = new TextBox();
            label10 = new Label();
            txtUnidadeVenda = new TextBox();
            txtId = new TextBox();
            txtImagem = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label1 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtDescricao = new TextBox();
            dgvProdutos = new DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvCodBarras = new DataGridViewTextBoxColumn();
            dgvDescricao = new DataGridViewTextBoxColumn();
            dgvValorUnit = new DataGridViewTextBoxColumn();
            dgvUnidadeVenda = new DataGridViewTextBoxColumn();
            dgvCategoria = new DataGridViewTextBoxColumn();
            dgvEstoqueMinimo = new DataGridViewTextBoxColumn();
            dgvClasseDesconto = new DataGridViewTextBoxColumn();
            dgvDataCad = new DataGridViewTextBoxColumn();
            txtBusca = new TextBox();
            txtCatId = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCatId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtpDataCad);
            groupBox2.Controls.Add(btnConsultar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(txtValorUnit);
            groupBox2.Controls.Add(cbmCategoria);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtClasseDesconto);
            groupBox2.Controls.Add(txtEstoqueMinimo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtCodBarras);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtUnidadeVenda);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(txtImagem);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 235);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados de Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 108);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 20;
            label2.Text = "Data de Cadastro";
            // 
            // dtpDataCad
            // 
            dtpDataCad.Format = DateTimePickerFormat.Short;
            dtpDataCad.Location = new Point(312, 126);
            dtpDataCad.Name = "dtpDataCad";
            dtpDataCad.Size = new Size(101, 23);
            dtpDataCad.TabIndex = 19;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Image = Properties.Resources.Search1;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(383, 190);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(111, 39);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "&Consultar";
            btnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Image = Properties.Resources.Edit_Alt1;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(266, 190);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 39);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(152, 79);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 16;
            // 
            // cbmCategoria
            // 
            cbmCategoria.FormattingEnabled = true;
            cbmCategoria.Location = new Point(118, 126);
            cbmCategoria.Name = "cbmCategoria";
            cbmCategoria.Size = new Size(188, 23);
            cbmCategoria.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 155);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 11;
            label7.Text = "Classe Desconto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 155);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 10;
            label6.Text = "Estoque Mínimo";
            // 
            // txtClasseDesconto
            // 
            txtClasseDesconto.Location = new Point(110, 173);
            txtClasseDesconto.Name = "txtClasseDesconto";
            txtClasseDesconto.Size = new Size(93, 23);
            txtClasseDesconto.TabIndex = 9;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(10, 173);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(94, 23);
            txtEstoqueMinimo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 108);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 4;
            label9.Text = "Categoria";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(11, 79);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(135, 23);
            txtCodBarras.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 35);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 2;
            label10.Text = "ID";
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(10, 126);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(102, 23);
            txtUnidadeVenda.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(34, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(80, 23);
            txtId.TabIndex = 6;
            // 
            // txtImagem
            // 
            txtImagem.Location = new Point(258, 79);
            txtImagem.Name = "txtImagem";
            txtImagem.Size = new Size(155, 23);
            txtImagem.TabIndex = 2;
            txtImagem.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(120, 34);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 0;
            label11.Text = "Descrição";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 61);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 0;
            label12.Text = "Codigo de Barras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 61);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Caminho Imagem";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 108);
            label13.Name = "label13";
            label13.Size = new Size(102, 15);
            label13.TabIndex = 0;
            label13.Text = "Unidade de Venda";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(152, 61);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 0;
            label14.Text = "Valor Unitário";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(184, 26);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(253, 23);
            txtDescricao.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvCodBarras, dgvDescricao, dgvValorUnit, dgvUnidadeVenda, dgvCategoria, dgvEstoqueMinimo, dgvClasseDesconto, dgvDataCad });
            dgvProdutos.Location = new Point(12, 282);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(500, 150);
            dgvProdutos.TabIndex = 57;
            // 
            // dgvId
            // 
            dgvId.HeaderText = "Id";
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Width = 40;
            // 
            // dgvCodBarras
            // 
            dgvCodBarras.HeaderText = "Codigo de Barras";
            dgvCodBarras.Name = "dgvCodBarras";
            dgvCodBarras.ReadOnly = true;
            // 
            // dgvDescricao
            // 
            dgvDescricao.HeaderText = "Descrição";
            dgvDescricao.Name = "dgvDescricao";
            dgvDescricao.ReadOnly = true;
            // 
            // dgvValorUnit
            // 
            dgvValorUnit.HeaderText = "Valor Unitário";
            dgvValorUnit.Name = "dgvValorUnit";
            dgvValorUnit.ReadOnly = true;
            // 
            // dgvUnidadeVenda
            // 
            dgvUnidadeVenda.HeaderText = "Unidade de Venda";
            dgvUnidadeVenda.Name = "dgvUnidadeVenda";
            dgvUnidadeVenda.ReadOnly = true;
            // 
            // dgvCategoria
            // 
            dgvCategoria.HeaderText = "Categoria";
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            // 
            // dgvEstoqueMinimo
            // 
            dgvEstoqueMinimo.HeaderText = "Estoque Mínimo";
            dgvEstoqueMinimo.Name = "dgvEstoqueMinimo";
            dgvEstoqueMinimo.ReadOnly = true;
            // 
            // dgvClasseDesconto
            // 
            dgvClasseDesconto.HeaderText = "Classe de Desconto";
            dgvClasseDesconto.Name = "dgvClasseDesconto";
            dgvClasseDesconto.ReadOnly = true;
            // 
            // dgvDataCad
            // 
            dgvDataCad.HeaderText = "Data de Cadastro";
            dgvDataCad.Name = "dgvDataCad";
            dgvDataCad.ReadOnly = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 253);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite para pesquisar o usuário";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 56;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // txtCatId
            // 
            txtCatId.Location = new Point(438, 121);
            txtCatId.Name = "txtCatId";
            txtCatId.Size = new Size(24, 23);
            txtCatId.TabIndex = 21;
            txtCatId.Visible = false;
            // 
            // FrmProdutoConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 443);
            Controls.Add(groupBox2);
            Controls.Add(dgvProdutos);
            Controls.Add(txtBusca);
            Name = "FrmProdutoConsultar";
            Text = "FrmProdutoConsultar";
            Load += FrmProdutoConsultar_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtValorUnit;
        private ComboBox cbmCategoria;
        private Label label7;
        private Label label6;
        private TextBox txtClasseDesconto;
        private TextBox txtEstoqueMinimo;
        private Label label9;
        private TextBox txtCodBarras;
        private Label label10;
        private TextBox txtUnidadeVenda;
        private TextBox txtId;
        private TextBox txtImagem;
        private Label label11;
        private Label label12;
        private Label label1;
        private Label label13;
        private Label label14;
        private TextBox txtDescricao;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvCodBarras;
        private DataGridViewTextBoxColumn dgvDescricao;
        private DataGridViewTextBoxColumn dgvValorUnit;
        private DataGridViewTextBoxColumn dgvUnidadeVenda;
        private DataGridViewTextBoxColumn dgvCategoria;
        private DataGridViewTextBoxColumn dgvEstoqueMinimo;
        private DataGridViewTextBoxColumn dgvClasseDesconto;
        private DataGridViewTextBoxColumn dgvDataCad;
        private TextBox txtBusca;
        private Button btnConsultar;
        private Button btnEditar;
        private DateTimePicker dtpDataCad;
        private Label label2;
        private TextBox txtCatId;
    }
}