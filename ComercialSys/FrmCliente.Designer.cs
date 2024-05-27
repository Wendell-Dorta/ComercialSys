namespace ComercialSys
{
    partial class FrmCliente
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvUsuario = new DataGridView();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            txtNivel = new Label();
            btnConsultar = new Button();
            btnEditar = new Button();
            txtEmail = new TextBox();
            btnInserir = new Button();
            label1 = new Label();
            txtConfSenha = new TextBox();
            txtId = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtBusca = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1131, 594);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvUsuario);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(txtBusca);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1123, 566);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1123, 566);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereços";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnCpf, clnTelefone, clnDataNasc, clnDataCad, clnAtivo });
            dgvUsuario.Location = new Point(6, 314);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersVisible = false;
            dgvUsuario.Size = new Size(1111, 246);
            dgvUsuario.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtNivel);
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
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1111, 273);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 179);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 11;
            label7.Text = "Ativo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 171);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(80, 23);
            textBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(216, 34);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 9;
            label6.Text = "Data Cadastro";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 10;
            // 
            // txtNivel
            // 
            txtNivel.AutoSize = true;
            txtNivel.Location = new Point(10, 179);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(114, 15);
            txtNivel.TabIndex = 4;
            txtNivel.Text = "Data de Nascimento";
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Image = Properties.Resources.Search1;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(303, 228);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(111, 39);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "&Consultar";
            btnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Image = Properties.Resources.Edit_Alt1;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(186, 228);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 39);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(72, 228);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(111, 39);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 34);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(130, 142);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(197, 23);
            txtConfSenha.TabIndex = 3;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(80, 23);
            txtId.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(130, 113);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(197, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 92);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 150);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 0;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 121);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 0;
            label4.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(130, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(358, 23);
            txtNome.TabIndex = 0;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(6, 285);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite para pesquisar o usuário";
            txtBusca.Size = new Size(1111, 23);
            txtBusca.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewCheckBoxColumn1 });
            dataGridView1.Location = new Point(6, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1111, 246);
            dataGridView1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Frozen = true;
            dataGridViewTextBoxColumn3.HeaderText = "Email";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Frozen = true;
            dataGridViewTextBoxColumn4.HeaderText = "Nível";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.Frozen = true;
            dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1111, 273);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereços de Cliente";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(262, 179);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 11;
            label8.Text = "Ativo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(303, 171);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(80, 23);
            textBox5.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(216, 34);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 9;
            label9.Text = "Data Cadastro";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(303, 26);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(185, 23);
            textBox6.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 179);
            label10.Name = "label10";
            label10.Size = new Size(114, 15);
            label10.TabIndex = 4;
            label10.Text = "Data de Nascimento";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(130, 84);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(358, 23);
            textBox7.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(106, 34);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 2;
            label11.Text = "ID";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(130, 142);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(197, 23);
            textBox8.TabIndex = 3;
            textBox8.UseSystemPasswordChar = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(130, 26);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(80, 23);
            textBox9.TabIndex = 6;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(130, 113);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(197, 23);
            textBox10.TabIndex = 2;
            textBox10.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(83, 63);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 0;
            label12.Text = "Nome";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(87, 92);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 0;
            label13.Text = "Email";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(72, 150);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 0;
            label14.Text = "Telefone";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(95, 121);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 0;
            label15.Text = "CPF";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(130, 55);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(358, 23);
            textBox11.TabIndex = 0;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(6, 285);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "Digite para pesquisar o usuário";
            textBox12.Size = new Size(1111, 23);
            textBox12.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Search1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(303, 228);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 11;
            button1.Text = "&Consultar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.Edit_Alt1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(186, 228);
            button2.Name = "button2";
            button2.Size = new Size(111, 39);
            button2.TabIndex = 10;
            button2.Text = "&Editar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.Add;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(72, 228);
            button3.Name = "button3";
            button3.Size = new Size(111, 39);
            button3.TabIndex = 9;
            button3.Text = "&Inserir";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
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
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 180;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnDataNasc
            // 
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "Data de Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 618);
            Controls.Add(tabControl1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvUsuario;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label txtNivel;
        private Button btnConsultar;
        private Button btnEditar;
        private TextBox txtEmail;
        private Button btnInserir;
        private Label label1;
        private TextBox txtConfSenha;
        private TextBox txtId;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtBusca;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox4;
        private Button button2;
        private Label label8;
        private Button button3;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox11;
        private TextBox textBox12;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}