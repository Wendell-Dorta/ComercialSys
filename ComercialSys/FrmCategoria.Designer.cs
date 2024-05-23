namespace ComercialSys
{
    partial class FrmCategoria
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
            txtId = new TextBox();
            label1 = new Label();
            txtCategoria = new TextBox();
            label2 = new Label();
            txtSigla = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnDeletar = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            dgvCategoria = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clncCategoria = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(75, 23);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(75, 53);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(298, 23);
            txtCategoria.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Categorias";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(75, 82);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(53, 23);
            txtSigla.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 86);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Sigla";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeletar);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 202);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Categoria";
            // 
            // btnDeletar
            // 
            btnDeletar.Enabled = false;
            btnDeletar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletar.Image = Properties.Resources.Delete;
            btnDeletar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletar.Location = new Point(381, 157);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(111, 39);
            btnDeletar.TabIndex = 12;
            btnDeletar.Text = "&Deletar";
            btnDeletar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Image = Properties.Resources.Search1;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(264, 157);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(111, 39);
            btnConsultar.TabIndex = 11;
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
            btnEditar.Location = new Point(147, 157);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 39);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(30, 157);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(111, 39);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "&Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.AllowUserToDeleteRows = false;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { clnId, clncCategoria, clnSigla });
            dgvCategoria.Location = new Point(12, 220);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.RowHeadersVisible = false;
            dgvCategoria.Size = new Size(498, 209);
            dgvCategoria.TabIndex = 9;
            // 
            // clnId
            // 
            clnId.FillWeight = 10F;
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clncCategoria
            // 
            clncCategoria.Frozen = true;
            clncCategoria.HeaderText = "Categoria";
            clncCategoria.Name = "clncCategoria";
            clncCategoria.ReadOnly = true;
            clncCategoria.Width = 360;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 441);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private TextBox txtCategoria;
        private Label label2;
        private TextBox txtSigla;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnInserir;
        private DataGridView dgvCategoria;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clncCategoria;
        private DataGridViewTextBoxColumn clnSigla;
        private Button btnDeletar;
    }
}