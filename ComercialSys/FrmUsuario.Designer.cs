namespace ComercialSys
{
    partial class FrmUsuario
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
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtBusca = new TextBox();
            label4 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            txtConfSenha = new TextBox();
            groupBox1 = new GroupBox();
            txtNivel = new Label();
            cmbNivel = new ComboBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            txtEmail = new TextBox();
            btnInserir = new Button();
            dgvUsuario = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 34);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(115, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(80, 23);
            txtId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(115, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 92);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 253);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite para pesquisar o usuário";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 1;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 121);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(115, 113);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(197, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 150);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 0;
            label5.Text = "Confirmar Senha";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(115, 142);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(197, 23);
            txtConfSenha.TabIndex = 3;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNivel);
            groupBox1.Controls.Add(cmbNivel);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtConfSenha);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Usuário";
            // 
            // txtNivel
            // 
            txtNivel.AutoSize = true;
            txtNivel.Location = new Point(333, 150);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(34, 15);
            txtNivel.TabIndex = 4;
            txtNivel.Text = "Nível";
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(373, 142);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 4;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Image = Properties.Resources.Search1;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(383, 190);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(111, 39);
            btnConsultar.TabIndex = 8;
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
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(149, 190);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(111, 39);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuario.Location = new Point(12, 282);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersVisible = false;
            dgvUsuario.Size = new Size(500, 150);
            dgvUsuario.TabIndex = 3;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 60;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 441);
            Controls.Add(dgvUsuario);
            Controls.Add(groupBox1);
            Controls.Add(txtBusca);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtBusca;
        private Label label4;
        private TextBox txtSenha;
        private Label label5;
        private TextBox txtConfSenha;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnInserir;
        private DataGridView dgvUsuario;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private TextBox txtEmail;
        private Label txtNivel;
        private ComboBox cmbNivel;
    }
}