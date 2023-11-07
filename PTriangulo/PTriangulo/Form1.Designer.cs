namespace PTriangulo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lemon", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(253, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(536, 49);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atividade 4 - Triângulo";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Lemon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(241, 92);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(565, 31);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "\"Welcome to the Dark Side of The Moon\"";
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.BackColor = System.Drawing.Color.Transparent;
            this.lblLadoA.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLadoA.ForeColor = System.Drawing.Color.White;
            this.lblLadoA.Location = new System.Drawing.Point(174, 453);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(59, 18);
            this.lblLadoA.TabIndex = 2;
            this.lblLadoA.Text = "Lado A";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.BackColor = System.Drawing.Color.Transparent;
            this.lblLadoB.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLadoB.ForeColor = System.Drawing.Color.White;
            this.lblLadoB.Location = new System.Drawing.Point(174, 489);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(59, 18);
            this.lblLadoB.TabIndex = 3;
            this.lblLadoB.Text = "Lado B";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.BackColor = System.Drawing.Color.Transparent;
            this.lblLadoC.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLadoC.ForeColor = System.Drawing.Color.White;
            this.lblLadoC.Location = new System.Drawing.Point(174, 530);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(57, 18);
            this.lblLadoC.TabIndex = 4;
            this.lblLadoC.Text = "Lado C";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(253, 449);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(199, 23);
            this.txtLadoA.TabIndex = 5;
            this.txtLadoA.TextChanged += new System.EventHandler(this.txtLadoA_TextChanged);
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(253, 530);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(199, 23);
            this.txtLadoC.TabIndex = 6;
            this.txtLadoC.TextChanged += new System.EventHandler(this.txtLadoC_TextChanged);
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(253, 488);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(199, 23);
            this.txtLadoB.TabIndex = 7;
            this.txtLadoB.TextChanged += new System.EventHandler(this.txtLadoB_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(484, 447);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 110);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(758, 447);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 110);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(621, 447);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 110);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PTriangulo.Properties.Resources.DarkSideOfTheMoon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1056, 660);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Atividade 4 - Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblLadoA;
        private Label lblLadoB;
        private Label lblLadoC;
        private TextBox txtLadoA;
        private TextBox txtLadoC;
        private TextBox txtLadoB;
        private Button btnCalcular;
        private Button btnSair;
        private Button btnLimpar;
    }
}