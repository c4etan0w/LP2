namespace PClasses
{
    partial class frmHorista
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
            this.lblMatri = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioHR = new System.Windows.Forms.Label();
            this.lblNumeroHoras = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtNumeroHoras = new System.Windows.Forms.TextBox();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatri
            // 
            this.lblMatri.AutoSize = true;
            this.lblMatri.BackColor = System.Drawing.Color.Transparent;
            this.lblMatri.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatri.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMatri.Location = new System.Drawing.Point(80, 107);
            this.lblMatri.Name = "lblMatri";
            this.lblMatri.Size = new System.Drawing.Size(86, 24);
            this.lblMatri.TabIndex = 0;
            this.lblMatri.Text = "Matrícula:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNome.Location = new System.Drawing.Point(80, 160);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblSalarioHR
            // 
            this.lblSalarioHR.AutoSize = true;
            this.lblSalarioHR.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarioHR.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSalarioHR.Location = new System.Drawing.Point(80, 212);
            this.lblSalarioHR.Name = "lblSalarioHR";
            this.lblSalarioHR.Size = new System.Drawing.Size(119, 24);
            this.lblSalarioHR.TabIndex = 4;
            this.lblSalarioHR.Text = "Salário (Hora):";
            // 
            // lblNumeroHoras
            // 
            this.lblNumeroHoras.AutoSize = true;
            this.lblNumeroHoras.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroHoras.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroHoras.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNumeroHoras.Location = new System.Drawing.Point(80, 269);
            this.lblNumeroHoras.Name = "lblNumeroHoras";
            this.lblNumeroHoras.Size = new System.Drawing.Size(141, 24);
            this.lblNumeroHoras.TabIndex = 6;
            this.lblNumeroHoras.Text = "Número de Horas:";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrada.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDataEntrada.Location = new System.Drawing.Point(80, 323);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(222, 24);
            this.lblDataEntrada.TabIndex = 8;
            this.lblDataEntrada.Text = "Data de Entrada na Empresa:";
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.BackColor = System.Drawing.Color.Transparent;
            this.lblFaltas.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFaltas.Location = new System.Drawing.Point(80, 376);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(119, 24);
            this.lblFaltas.TabIndex = 10;
            this.lblFaltas.Text = "Dias de Faltas:";
            // 
            // gbxHome
            // 
            this.gbxHome.BackColor = System.Drawing.Color.Transparent;
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbxHome.Location = new System.Drawing.Point(511, 110);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(192, 151);
            this.gbxHome.TabIndex = 12;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha em Home Office?";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnNao.Location = new System.Drawing.Point(6, 102);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(72, 38);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnSim.Location = new System.Drawing.Point(6, 54);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(72, 38);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(217, 110);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(262, 29);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtFaltas
            // 
            this.txtFaltas.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaltas.Location = new System.Drawing.Point(217, 376);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(262, 29);
            this.txtFaltas.TabIndex = 11;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrada.Location = new System.Drawing.Point(301, 323);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(178, 29);
            this.txtDataEntrada.TabIndex = 9;
            // 
            // txtNumeroHoras
            // 
            this.txtNumeroHoras.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHoras.Location = new System.Drawing.Point(217, 269);
            this.txtNumeroHoras.Name = "txtNumeroHoras";
            this.txtNumeroHoras.Size = new System.Drawing.Size(262, 29);
            this.txtNumeroHoras.TabIndex = 7;
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioHora.Location = new System.Drawing.Point(217, 212);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(262, 29);
            this.txtSalarioHora.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(217, 163);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 29);
            this.txtNome.TabIndex = 3;
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanciar.Location = new System.Drawing.Point(511, 269);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(192, 136);
            this.btnInstanciar.TabIndex = 13;
            this.btnInstanciar.Text = "Instanciar";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.btnInstanciar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(74, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(629, 81);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Funcionário Horista";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PClasses.Properties.Resources.Plano_de_fundo_dinheiro;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.txtNumeroHoras);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblNumeroHoras);
            this.Controls.Add(this.lblSalarioHR);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatri);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatri;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioHR;
        private System.Windows.Forms.Label lblNumeroHoras;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtNumeroHoras;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.Label lblTitulo;
    }
}