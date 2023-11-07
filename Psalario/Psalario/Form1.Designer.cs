namespace Psalario
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
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.nupdFilhos = new System.Windows.Forms.NumericUpDown();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.gbxEstCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbldados = new System.Windows.Forms.Label();
            this.mskbxAliINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxsalarioFam = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioLiq = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAssinatura = new System.Windows.Forms.Label();
            this.lblChefe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupdFilhos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            this.gbxEstCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(69, 126);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(178, 18);
            this.lblNomeFunc.TabIndex = 2;
            this.lblNomeFunc.Text = "Nome Funcionário:";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(69, 157);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(148, 18);
            this.lblSalBruto.TabIndex = 4;
            this.lblSalBruto.Text = "Salário Bruto:";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.Location = new System.Drawing.Point(69, 192);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(178, 18);
            this.lblFilhos.TabIndex = 6;
            this.lblFilhos.Text = "Número de Filhos:";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(69, 361);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(138, 18);
            this.lblINSS.TabIndex = 12;
            this.lblINSS.Text = "Alíquota INSS";
            this.lblINSS.Click += new System.EventHandler(this.lblINSS_Click);
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRPF.Location = new System.Drawing.Point(69, 401);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(138, 18);
            this.lblIRPF.TabIndex = 14;
            this.lblIRPF.Text = "Alíquita IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFamilia.Location = new System.Drawing.Point(69, 440);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(158, 18);
            this.lblSalFamilia.TabIndex = 16;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(455, 361);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(148, 18);
            this.lblDescINSS.TabIndex = 20;
            this.lblDescINSS.Text = "Desconto INSS:";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiq.Location = new System.Drawing.Point(69, 477);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(158, 18);
            this.lblSalLiq.TabIndex = 18;
            this.lblSalLiq.Text = "Salário Liquido";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(253, 121);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(161, 29);
            this.txtNomeFunc.TabIndex = 3;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(253, 227);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(161, 78);
            this.btnVerifica.TabIndex = 10;
            this.btnVerifica.Text = "Verifica Desconto";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRPF.Location = new System.Drawing.Point(456, 394);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(148, 18);
            this.lblDescIRPF.TabIndex = 22;
            this.lblDescIRPF.Text = "Desconto IRPF:";
            // 
            // nupdFilhos
            // 
            this.nupdFilhos.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdFilhos.Location = new System.Drawing.Point(253, 188);
            this.nupdFilhos.Name = "nupdFilhos";
            this.nupdFilhos.Size = new System.Drawing.Size(161, 29);
            this.nupdFilhos.TabIndex = 7;
            this.nupdFilhos.ValueChanged += new System.EventHandler(this.nupdFilhos_ValueChanged);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(456, 121);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(292, 105);
            this.gbxSexo.TabIndex = 8;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(144, 45);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(106, 22);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(25, 45);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(116, 22);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // gbxEstCivil
            // 
            this.gbxEstCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstCivil.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstCivil.Location = new System.Drawing.Point(459, 233);
            this.gbxEstCivil.Name = "gbxEstCivil";
            this.gbxEstCivil.Size = new System.Drawing.Size(289, 72);
            this.gbxEstCivil.TabIndex = 9;
            this.gbxEstCivil.TabStop = false;
            this.gbxEstCivil.Text = "Estado Civil";
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(149, 30);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(106, 22);
            this.rbtnSolteiro.TabIndex = 1;
            this.rbtnSolteiro.Text = "Solteiro";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Checked = true;
            this.rbtnCasado.Location = new System.Drawing.Point(22, 30);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(86, 22);
            this.rbtnCasado.TabIndex = 0;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalBruto.Location = new System.Drawing.Point(253, 152);
            this.mskbxSalBruto.Mask = "99999.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(161, 29);
            this.mskbxSalBruto.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(132, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(590, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atividade 6 LP2 - Psalário";
            // 
            // lbldados
            // 
            this.lbldados.AutoSize = true;
            this.lbldados.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldados.Location = new System.Drawing.Point(136, 327);
            this.lbldados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldados.Name = "lbldados";
            this.lbldados.Size = new System.Drawing.Size(0, 14);
            this.lbldados.TabIndex = 11;
            // 
            // mskbxAliINSS
            // 
            this.mskbxAliINSS.Enabled = false;
            this.mskbxAliINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliINSS.Location = new System.Drawing.Point(233, 362);
            this.mskbxAliINSS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxAliINSS.Name = "mskbxAliINSS";
            this.mskbxAliINSS.Size = new System.Drawing.Size(180, 23);
            this.mskbxAliINSS.TabIndex = 13;
            // 
            // mskbxAliIRPF
            // 
            this.mskbxAliIRPF.Enabled = false;
            this.mskbxAliIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliIRPF.Location = new System.Drawing.Point(233, 401);
            this.mskbxAliIRPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxAliIRPF.Name = "mskbxAliIRPF";
            this.mskbxAliIRPF.Size = new System.Drawing.Size(180, 23);
            this.mskbxAliIRPF.TabIndex = 15;
            // 
            // mskbxsalarioFam
            // 
            this.mskbxsalarioFam.Enabled = false;
            this.mskbxsalarioFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxsalarioFam.Location = new System.Drawing.Point(233, 440);
            this.mskbxsalarioFam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxsalarioFam.Name = "mskbxsalarioFam";
            this.mskbxsalarioFam.Size = new System.Drawing.Size(180, 23);
            this.mskbxsalarioFam.TabIndex = 17;
            // 
            // mskbxSalarioLiq
            // 
            this.mskbxSalarioLiq.Enabled = false;
            this.mskbxSalarioLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioLiq.Location = new System.Drawing.Point(233, 477);
            this.mskbxSalarioLiq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxSalarioLiq.Name = "mskbxSalarioLiq";
            this.mskbxSalarioLiq.Size = new System.Drawing.Size(180, 23);
            this.mskbxSalarioLiq.TabIndex = 19;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescINSS.Location = new System.Drawing.Point(608, 358);
            this.mskbxDescINSS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(141, 23);
            this.mskbxDescINSS.TabIndex = 21;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescIRPF.Location = new System.Drawing.Point(608, 391);
            this.mskbxDescIRPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(141, 23);
            this.mskbxDescIRPF.TabIndex = 23;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(68, 82);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(681, 21);
            this.lblNomeEmpresa.TabIndex = 1;
            this.lblNomeEmpresa.Text = "Empresa: Construtora FatecSOR LTDA - CNPJ: 23.526.778/0001-07";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Psalario.Properties.Resources.Rubrica_de_Carlos_Kenobi;
            this.pictureBox1.Location = new System.Drawing.Point(481, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblAssinatura
            // 
            this.lblAssinatura.AutoSize = true;
            this.lblAssinatura.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssinatura.Location = new System.Drawing.Point(495, 503);
            this.lblAssinatura.Name = "lblAssinatura";
            this.lblAssinatura.Size = new System.Drawing.Size(241, 22);
            this.lblAssinatura.TabIndex = 24;
            this.lblAssinatura.Text = "Levi Rodrigues Munhoz";
            // 
            // lblChefe
            // 
            this.lblChefe.AutoSize = true;
            this.lblChefe.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefe.Location = new System.Drawing.Point(464, 525);
            this.lblChefe.Name = "lblChefe";
            this.lblChefe.Size = new System.Drawing.Size(299, 19);
            this.lblChefe.TabIndex = 25;
            this.lblChefe.Text = "Gerente Dep. Recursos Humanos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.lblChefe);
            this.Controls.Add(this.lblAssinatura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxSalarioLiq);
            this.Controls.Add(this.mskbxsalarioFam);
            this.Controls.Add(this.mskbxAliIRPF);
            this.Controls.Add(this.mskbxAliINSS);
            this.Controls.Add(this.lbldados);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.gbxEstCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.nupdFilhos);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Psalário";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupdFilhos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstCivil.ResumeLayout(false);
            this.gbxEstCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.NumericUpDown nupdFilhos;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.GroupBox gbxEstCivil;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbldados;
        private System.Windows.Forms.MaskedTextBox mskbxAliINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxsalarioFam;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioLiq;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAssinatura;
        private System.Windows.Forms.Label lblChefe;
    }
}

