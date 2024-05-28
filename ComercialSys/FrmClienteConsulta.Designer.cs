namespace ComercialSys
{
    partial class FrmClienteConsulta
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
            groupBox1 = new GroupBox();
            dgvEnderecos = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tbpCliente = new TabPage();
            button2 = new Button();
            chkAtivo = new CheckBox();
            dtpDataNasc = new DateTimePicker();
            mxtTelefone = new MaskedTextBox();
            mxtCpf = new MaskedTextBox();
            txtNivel = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            tbpEndereco = new TabPage();
            btnDeletear = new Button();
            btnEditar = new Button();
            label11 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textNumero = new TextBox();
            txtLogradouro = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnConsultar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            tabControl1.SuspendLayout();
            tbpCliente.SuspendLayout();
            tbpEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEnderecos);
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 440);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta Cliente";
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.AllowUserToDeleteRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(6, 284);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(456, 150);
            dgvEnderecos.TabIndex = 53;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 60;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 200;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 60;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 150;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 150;
            // 
            // clnUf
            // 
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 30;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.HeaderText = "Tipo";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 60;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpCliente);
            tabControl1.Controls.Add(tbpEndereco);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(460, 261);
            tabControl1.TabIndex = 0;
            // 
            // tbpCliente
            // 
            tbpCliente.BackColor = Color.Transparent;
            tbpCliente.Controls.Add(btnConsultar);
            tbpCliente.Controls.Add(button2);
            tbpCliente.Controls.Add(chkAtivo);
            tbpCliente.Controls.Add(dtpDataNasc);
            tbpCliente.Controls.Add(mxtTelefone);
            tbpCliente.Controls.Add(mxtCpf);
            tbpCliente.Controls.Add(txtNivel);
            tbpCliente.Controls.Add(txtEmail);
            tbpCliente.Controls.Add(label2);
            tbpCliente.Controls.Add(label3);
            tbpCliente.Controls.Add(label5);
            tbpCliente.Controls.Add(label4);
            tbpCliente.Controls.Add(txtNome);
            tbpCliente.Location = new Point(4, 24);
            tbpCliente.Name = "tbpCliente";
            tbpCliente.Padding = new Padding(3);
            tbpCliente.Size = new Size(452, 233);
            tbpCliente.TabIndex = 0;
            tbpCliente.Text = "Clientes";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Enabled = false;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.Edit_Alt1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(218, 189);
            button2.Name = "button2";
            button2.Size = new Size(111, 39);
            button2.TabIndex = 37;
            button2.Text = "&Editar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(137, 147);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 36;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(6, 144);
            dtpDataNasc.MaxDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dtpDataNasc.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(98, 23);
            dtpDataNasc.TabIndex = 35;
            dtpDataNasc.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // mxtTelefone
            // 
            mxtTelefone.Location = new Point(6, 100);
            mxtTelefone.Mask = "(99) 00000-0000";
            mxtTelefone.Name = "mxtTelefone";
            mxtTelefone.Size = new Size(98, 23);
            mxtTelefone.TabIndex = 34;
            // 
            // mxtCpf
            // 
            mxtCpf.Location = new Point(110, 100);
            mxtCpf.Mask = "000.000.000-00";
            mxtCpf.Name = "mxtCpf";
            mxtCpf.Size = new Size(98, 23);
            mxtCpf.TabIndex = 33;
            // 
            // txtNivel
            // 
            txtNivel.AutoSize = true;
            txtNivel.Location = new Point(4, 130);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(114, 15);
            txtNivel.TabIndex = 23;
            txtNivel.Text = "Data de Nascimento";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 23);
            txtEmail.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 5);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 17;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 44);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 16;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 86);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 15;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 86);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 18;
            label4.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 23);
            txtNome.TabIndex = 14;
            // 
            // tbpEndereco
            // 
            tbpEndereco.BackColor = Color.Transparent;
            tbpEndereco.BackgroundImageLayout = ImageLayout.None;
            tbpEndereco.Controls.Add(btnDeletear);
            tbpEndereco.Controls.Add(btnEditar);
            tbpEndereco.Controls.Add(label11);
            tbpEndereco.Controls.Add(label10);
            tbpEndereco.Controls.Add(comboBox1);
            tbpEndereco.Controls.Add(textBox4);
            tbpEndereco.Controls.Add(textBox3);
            tbpEndereco.Controls.Add(textBox2);
            tbpEndereco.Controls.Add(textNumero);
            tbpEndereco.Controls.Add(txtLogradouro);
            tbpEndereco.Controls.Add(maskedTextBox1);
            tbpEndereco.Controls.Add(label1);
            tbpEndereco.Controls.Add(label6);
            tbpEndereco.Controls.Add(label7);
            tbpEndereco.Controls.Add(label8);
            tbpEndereco.Controls.Add(label9);
            tbpEndereco.Location = new Point(4, 24);
            tbpEndereco.Name = "tbpEndereco";
            tbpEndereco.Padding = new Padding(3);
            tbpEndereco.Size = new Size(452, 233);
            tbpEndereco.TabIndex = 1;
            tbpEndereco.Text = "Endereço";
            // 
            // btnDeletear
            // 
            btnDeletear.AutoSize = true;
            btnDeletear.Enabled = false;
            btnDeletear.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletear.Image = Properties.Resources.Delete;
            btnDeletear.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletear.Location = new Point(250, 189);
            btnDeletear.Name = "btnDeletear";
            btnDeletear.Size = new Size(98, 38);
            btnDeletear.TabIndex = 52;
            btnDeletear.Text = "&Deletar";
            btnDeletear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeletear.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = true;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Image = Properties.Resources.Edit_Alt1;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(354, 189);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(92, 38);
            btnEditar.TabIndex = 51;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(418, 44);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 49;
            label11.Text = "UF";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(211, 44);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 49;
            label10.Text = "Bairro";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Reitrada", "TEMP - Temporário" });
            comboBox1.Location = new Point(6, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 48;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 59);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 23);
            textBox4.TabIndex = 47;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 47;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(28, 23);
            textBox2.TabIndex = 47;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(368, 18);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(78, 23);
            textNumero.TabIndex = 46;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(75, 18);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(287, 23);
            txtLogradouro.TabIndex = 45;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 18);
            maskedTextBox1.Mask = "00000-999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(63, 23);
            maskedTextBox1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 88);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 43;
            label1.Text = "Tipo de Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 40;
            label6.Text = "CEP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 3);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 39;
            label7.Text = "Logradouro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 44);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 38;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(368, 3);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 41;
            label9.Text = "Numero";
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Image = Properties.Resources.Search1;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(335, 188);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(111, 39);
            btnConsultar.TabIndex = 39;
            btnConsultar.Text = "&Consultar";
            btnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // FrmClienteConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 459);
            Controls.Add(groupBox1);
            Name = "FrmClienteConsulta";
            Text = "FrmClienteConsulta";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            tabControl1.ResumeLayout(false);
            tbpCliente.ResumeLayout(false);
            tbpCliente.PerformLayout();
            tbpEndereco.ResumeLayout(false);
            tbpEndereco.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvEnderecos;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
        private TabControl tabControl1;
        private TabPage tbpCliente;
        private Button button2;
        private CheckBox chkAtivo;
        private DateTimePicker dtpDataNasc;
        private MaskedTextBox mxtTelefone;
        private MaskedTextBox mxtCpf;
        private Label txtNivel;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtNome;
        private TabPage tbpEndereco;
        private Button btnDeletear;
        private Button btnEditar;
        private Label label11;
        private Label label10;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textNumero;
        private TextBox txtLogradouro;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnConsultar;
    }
}