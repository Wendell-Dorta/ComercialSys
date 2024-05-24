namespace ComercialSys
{
    partial class FrmLogin
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 162);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Image = Properties.Resources.Ok;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(51, 107);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(121, 39);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Image = Properties.Resources.Delete;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(178, 107);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 39);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancela&r";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 21);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(51, 50);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(238, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 29);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 58);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Senha";
            // 
            // FrmLogin
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            CancelButton = btnCancelar;
            ClientSize = new Size(368, 186);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "FrmLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label3;
        private Label label4;
    }
}