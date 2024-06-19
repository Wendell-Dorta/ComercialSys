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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            txtVendedor = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label8 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            button3 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 87);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
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
            // textBox3
            // 
            textBox3.Location = new Point(100, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(437, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 23);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(669, 18);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(669, 36);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(119, 50);
            textBox1.TabIndex = 2;
            textBox1.Text = "0";
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
            // button1
            // 
            button1.Location = new Point(496, 173);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 5;
            button1.Text = "&Abrir Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 113);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(603, 184);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(669, 480);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 7;
            button2.Text = "&Finalizar Pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 19F);
            textBox4.Location = new Point(669, 435);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(119, 41);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(669, 389);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(119, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(669, 343);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(119, 23);
            textBox6.TabIndex = 9;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 19);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 1;
            label7.Text = "Descrição";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 37);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(97, 23);
            textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(109, 37);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(488, 23);
            textBox8.TabIndex = 3;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(6, 81);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(97, 23);
            textBox9.TabIndex = 4;
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
            // textBox10
            // 
            textBox10.Location = new Point(109, 81);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(97, 23);
            textBox10.TabIndex = 4;
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
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(510, 69);
            button3.Name = "button3";
            button3.Size = new Size(87, 38);
            button3.TabIndex = 7;
            button3.Text = "&Inserir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 10;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(727, 416);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 11;
            label11.Text = "Valor Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(707, 324);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 12;
            label12.Text = "Valor SubTotal";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(702, 370);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 13;
            label13.Text = "Valor Desconto";
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(txtVendedor);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private TextBox txtVendedor;
        private Button button1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private Button button3;
        private TextBox textBox7;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}