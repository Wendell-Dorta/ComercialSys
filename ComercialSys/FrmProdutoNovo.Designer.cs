namespace ComercialSys
{
    partial class FrmProdutoNovo
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
            txtValorUnit = new TextBox();
            cbmCategoria = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtClasseDesconto = new TextBox();
            txtEstoqueMinimo = new TextBox();
            label9 = new Label();
            txtCodBarras = new TextBox();
            bntInserir = new Button();
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
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtValorUnit);
            groupBox2.Controls.Add(cbmCategoria);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtClasseDesconto);
            groupBox2.Controls.Add(txtEstoqueMinimo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtCodBarras);
            groupBox2.Controls.Add(bntInserir);
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
            groupBox2.Size = new Size(500, 426);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados de Produto";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(119, 189);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(94, 23);
            txtValorUnit.TabIndex = 16;
            // 
            // cbmCategoria
            // 
            cbmCategoria.FormattingEnabled = true;
            cbmCategoria.Location = new Point(119, 137);
            cbmCategoria.Name = "cbmCategoria";
            cbmCategoria.Size = new Size(253, 23);
            cbmCategoria.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 251);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 11;
            label7.Text = "Classe Desconto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 224);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 10;
            label6.Text = "Estoque Mínimo";
            // 
            // txtClasseDesconto
            // 
            txtClasseDesconto.Location = new Point(119, 241);
            txtClasseDesconto.Name = "txtClasseDesconto";
            txtClasseDesconto.Size = new Size(94, 23);
            txtClasseDesconto.TabIndex = 9;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(119, 215);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(94, 23);
            txtEstoqueMinimo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 143);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 4;
            label9.Text = "Categoria";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(119, 59);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(253, 23);
            txtCodBarras.TabIndex = 1;
            // 
            // bntInserir
            // 
            bntInserir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntInserir.Image = Properties.Resources.Add;
            bntInserir.ImageAlign = ContentAlignment.MiddleLeft;
            bntInserir.Location = new Point(383, 381);
            bntInserir.Name = "bntInserir";
            bntInserir.Size = new Size(111, 39);
            bntInserir.TabIndex = 5;
            bntInserir.Text = "&Inserir";
            bntInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntInserir.UseVisualStyleBackColor = true;
            bntInserir.Click += bntInserir_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(95, 35);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 2;
            label10.Text = "ID";
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(119, 111);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(253, 23);
            txtUnidadeVenda.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(119, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(94, 23);
            txtId.TabIndex = 6;
            // 
            // txtImagem
            // 
            txtImagem.Location = new Point(119, 163);
            txtImagem.Name = "txtImagem";
            txtImagem.Size = new Size(253, 23);
            txtImagem.TabIndex = 2;
            txtImagem.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 89);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 0;
            label11.Text = "Descrição";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 62);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 0;
            label12.Text = "Codigo de Barras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 170);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Caminho Imagem";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 116);
            label13.Name = "label13";
            label13.Size = new Size(102, 15);
            label13.TabIndex = 0;
            label13.Text = "Unidade de Venda";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 197);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 0;
            label14.Text = "Valor Unitário";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(119, 85);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(253, 23);
            txtDescricao.TabIndex = 0;
            // 
            // FrmProdutoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(groupBox2);
            Name = "FrmProdutoNovo";
            Text = "FrmProduto";
            Load += FrmProdutoNovo_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private TextBox txtClasseDesconto;
        private TextBox txtEstoqueMinimo;
        private Label label9;
        private TextBox txtCodBarras;
        private Button bntInserir;
        private Label label10;
        private TextBox txtUnidadeVenda;
        private TextBox txtId;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtDescricao;
        private ComboBox cbmCategoria;
        private TextBox txtImagem;
        private Label label1;
        private TextBox txtValorUnit;
    }
}