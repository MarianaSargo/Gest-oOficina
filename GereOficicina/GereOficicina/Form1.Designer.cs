namespace GereOficicina
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtnovonif = new System.Windows.Forms.MaskedTextBox();
            this.btncriarcliente = new System.Windows.Forms.Button();
            this.txtnovonome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbclientes = new System.Windows.Forms.ListBox();
            this.btnremoveclientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.mtvalor = new System.Windows.Forms.MaskedTextBox();
            this.btncriarparcela = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.btncriarservico = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btncriarcarro = new System.Windows.Forms.Button();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.labelgasto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbparcelas = new System.Windows.Forms.ListBox();
            this.btnremoveparcelas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbservicos = new System.Windows.Forms.ListBox();
            this.btnremoveservicos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbcarros = new System.Windows.Forms.ListBox();
            this.btnremovecarros = new System.Windows.Forms.Button();
            this.txtnif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.lbclientes);
            this.groupBox1.Controls.Add(this.btnremoveclientes);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtnovonif);
            this.groupBox6.Controls.Add(this.btncriarcliente);
            this.groupBox6.Controls.Add(this.txtnovonome);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(6, 430);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 131);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Criar Novo Cliente";
            // 
            // txtnovonif
            // 
            this.txtnovonif.Location = new System.Drawing.Point(58, 57);
            this.txtnovonif.Mask = "000000000";
            this.txtnovonif.Name = "txtnovonif";
            this.txtnovonif.Size = new System.Drawing.Size(97, 22);
            this.txtnovonif.TabIndex = 5;
            // 
            // btncriarcliente
            // 
            this.btncriarcliente.Location = new System.Drawing.Point(80, 98);
            this.btncriarcliente.Name = "btncriarcliente";
            this.btncriarcliente.Size = new System.Drawing.Size(75, 23);
            this.btncriarcliente.TabIndex = 4;
            this.btncriarcliente.Text = "criar";
            this.btncriarcliente.UseVisualStyleBackColor = true;
            this.btncriarcliente.Click += new System.EventHandler(this.btncriarcliente_Click);
            // 
            // txtnovonome
            // 
            this.txtnovonome.Location = new System.Drawing.Point(58, 28);
            this.txtnovonome.Name = "txtnovonome";
            this.txtnovonome.Size = new System.Drawing.Size(190, 22);
            this.txtnovonome.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "NIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // lbclientes
            // 
            this.lbclientes.FormattingEnabled = true;
            this.lbclientes.ItemHeight = 16;
            this.lbclientes.Location = new System.Drawing.Point(6, 48);
            this.lbclientes.Name = "lbclientes";
            this.lbclientes.Size = new System.Drawing.Size(253, 356);
            this.lbclientes.TabIndex = 1;
            this.lbclientes.SelectedIndexChanged += new System.EventHandler(this.lbclientes_SelectedIndexChanged);
            // 
            // btnremoveclientes
            // 
            this.btnremoveclientes.Location = new System.Drawing.Point(0, 22);
            this.btnremoveclientes.Name = "btnremoveclientes";
            this.btnremoveclientes.Size = new System.Drawing.Size(259, 23);
            this.btnremoveclientes.TabIndex = 0;
            this.btnremoveclientes.Text = "Remover";
            this.btnremoveclientes.UseVisualStyleBackColor = true;
            this.btnremoveclientes.Click += new System.EventHandler(this.btnremoveclientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.labelgasto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtnif);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtnome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(288, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 561);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficha Client Selecionado";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.mtvalor);
            this.groupBox9.Controls.Add(this.btncriarparcela);
            this.groupBox9.Controls.Add(this.txtdescricao);
            this.groupBox9.Location = new System.Drawing.Point(683, 416);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(271, 139);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Criar Nova Parcela (Descriçao - Valor)";
            // 
            // mtvalor
            // 
            this.mtvalor.Location = new System.Drawing.Point(148, 28);
            this.mtvalor.Name = "mtvalor";
            this.mtvalor.Size = new System.Drawing.Size(117, 22);
            this.mtvalor.TabIndex = 8;
            // 
            // btncriarparcela
            // 
            this.btncriarparcela.Location = new System.Drawing.Point(6, 66);
            this.btncriarparcela.Name = "btncriarparcela";
            this.btncriarparcela.Size = new System.Drawing.Size(259, 55);
            this.btncriarparcela.TabIndex = 7;
            this.btncriarparcela.Text = "criar";
            this.btncriarparcela.UseVisualStyleBackColor = true;
            this.btncriarparcela.Click += new System.EventHandler(this.btncriarparcela_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(6, 28);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(136, 22);
            this.txtdescricao.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbtipo);
            this.groupBox8.Controls.Add(this.btncriarservico);
            this.groupBox8.Location = new System.Drawing.Point(280, 430);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(385, 131);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Criar Novo Serviço (Tipo)";
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Manutençao",
            "Oleo",
            "Limpeza"});
            this.cbtipo.Location = new System.Drawing.Point(6, 28);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(373, 24);
            this.cbtipo.TabIndex = 7;
            // 
            // btncriarservico
            // 
            this.btncriarservico.Location = new System.Drawing.Point(6, 66);
            this.btncriarservico.Name = "btncriarservico";
            this.btncriarservico.Size = new System.Drawing.Size(379, 55);
            this.btncriarservico.TabIndex = 6;
            this.btncriarservico.Text = "criar";
            this.btncriarservico.UseVisualStyleBackColor = true;
            this.btncriarservico.Click += new System.EventHandler(this.btncriarservico_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btncriarcarro);
            this.groupBox7.Controls.Add(this.txtmatricula);
            this.groupBox7.Location = new System.Drawing.Point(16, 430);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(246, 131);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Criar Novo Carro (Matricula)";
            // 
            // btncriarcarro
            // 
            this.btncriarcarro.Location = new System.Drawing.Point(17, 66);
            this.btncriarcarro.Name = "btncriarcarro";
            this.btncriarcarro.Size = new System.Drawing.Size(221, 55);
            this.btncriarcarro.TabIndex = 5;
            this.btncriarcarro.Text = "criar";
            this.btncriarcarro.UseVisualStyleBackColor = true;
            this.btncriarcarro.Click += new System.EventHandler(this.btncriarcarro_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(17, 28);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(223, 22);
            this.txtmatricula.TabIndex = 2;
            // 
            // labelgasto
            // 
            this.labelgasto.AutoSize = true;
            this.labelgasto.Location = new System.Drawing.Point(519, 11);
            this.labelgasto.Name = "labelgasto";
            this.labelgasto.Size = new System.Drawing.Size(0, 16);
            this.labelgasto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total gasto:";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(274, 11);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 60);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Guardar alteraçoes";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbparcelas);
            this.groupBox5.Controls.Add(this.btnremoveparcelas);
            this.groupBox5.Location = new System.Drawing.Point(677, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 329);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parcelas";
            // 
            // lbparcelas
            // 
            this.lbparcelas.FormattingEnabled = true;
            this.lbparcelas.ItemHeight = 16;
            this.lbparcelas.Location = new System.Drawing.Point(6, 48);
            this.lbparcelas.Name = "lbparcelas";
            this.lbparcelas.Size = new System.Drawing.Size(264, 276);
            this.lbparcelas.TabIndex = 1;
            // 
            // btnremoveparcelas
            // 
            this.btnremoveparcelas.Location = new System.Drawing.Point(0, 22);
            this.btnremoveparcelas.Name = "btnremoveparcelas";
            this.btnremoveparcelas.Size = new System.Drawing.Size(270, 23);
            this.btnremoveparcelas.TabIndex = 0;
            this.btnremoveparcelas.Text = "Remover";
            this.btnremoveparcelas.UseVisualStyleBackColor = true;
            this.btnremoveparcelas.Click += new System.EventHandler(this.btnremoveparcelas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbservicos);
            this.groupBox4.Controls.Add(this.btnremoveservicos);
            this.groupBox4.Location = new System.Drawing.Point(274, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 329);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serviços";
            // 
            // lbservicos
            // 
            this.lbservicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbservicos.FormattingEnabled = true;
            this.lbservicos.ItemHeight = 15;
            this.lbservicos.Location = new System.Drawing.Point(6, 48);
            this.lbservicos.Name = "lbservicos";
            this.lbservicos.Size = new System.Drawing.Size(385, 274);
            this.lbservicos.TabIndex = 1;
            this.lbservicos.SelectedIndexChanged += new System.EventHandler(this.lbservicos_SelectedIndexChanged);
            // 
            // btnremoveservicos
            // 
            this.btnremoveservicos.Location = new System.Drawing.Point(0, 22);
            this.btnremoveservicos.Name = "btnremoveservicos";
            this.btnremoveservicos.Size = new System.Drawing.Size(391, 23);
            this.btnremoveservicos.TabIndex = 0;
            this.btnremoveservicos.Text = "Remover";
            this.btnremoveservicos.UseVisualStyleBackColor = true;
            this.btnremoveservicos.Click += new System.EventHandler(this.btnremoveservicos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbcarros);
            this.groupBox3.Controls.Add(this.btnremovecarros);
            this.groupBox3.Location = new System.Drawing.Point(10, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 329);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carros";
            // 
            // lbcarros
            // 
            this.lbcarros.FormattingEnabled = true;
            this.lbcarros.ItemHeight = 16;
            this.lbcarros.Location = new System.Drawing.Point(6, 48);
            this.lbcarros.Name = "lbcarros";
            this.lbcarros.Size = new System.Drawing.Size(246, 276);
            this.lbcarros.TabIndex = 1;
            this.lbcarros.SelectedIndexChanged += new System.EventHandler(this.lbcarros_SelectedIndexChanged);
            // 
            // btnremovecarros
            // 
            this.btnremovecarros.Location = new System.Drawing.Point(0, 22);
            this.btnremovecarros.Name = "btnremovecarros";
            this.btnremovecarros.Size = new System.Drawing.Size(252, 23);
            this.btnremovecarros.TabIndex = 0;
            this.btnremovecarros.Text = "Remover";
            this.btnremovecarros.UseVisualStyleBackColor = true;
            this.btnremovecarros.Click += new System.EventHandler(this.btnremovecarros_Click);
            // 
            // txtnif
            // 
            this.txtnif.Location = new System.Drawing.Point(57, 47);
            this.txtnif.Name = "txtnif";
            this.txtnif.Size = new System.Drawing.Size(128, 22);
            this.txtnif.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIF:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(57, 19);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(197, 22);
            this.txtnome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btncriarcliente;
        private System.Windows.Forms.TextBox txtnovonome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbclientes;
        private System.Windows.Forms.Button btnremoveclientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.MaskedTextBox mtvalor;
        private System.Windows.Forms.Button btncriarparcela;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Button btncriarservico;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btncriarcarro;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label labelgasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lbparcelas;
        private System.Windows.Forms.Button btnremoveparcelas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbservicos;
        private System.Windows.Forms.Button btnremoveservicos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbcarros;
        private System.Windows.Forms.Button btnremovecarros;
        private System.Windows.Forms.TextBox txtnif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtnovonif;
    }
}

