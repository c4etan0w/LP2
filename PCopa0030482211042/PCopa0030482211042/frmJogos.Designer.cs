namespace PCopa0030482211042
{
    partial class frmJogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
            this.bnvJogo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbJogo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvJogo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dtpDatahora = new System.Windows.Forms.DateTimePicker();
            this.cbxEstadio = new System.Windows.Forms.ComboBox();
            this.cbxPais2 = new System.Windows.Forms.ComboBox();
            this.cbxPais1 = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblObservaçao = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.lblPais2 = new System.Windows.Forms.Label();
            this.lblPais1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bnvJogo)).BeginInit();
            this.bnvJogo.SuspendLayout();
            this.tbJogo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvJogo
            // 
            this.bnvJogo.AddNewItem = null;
            this.bnvJogo.CountItem = this.bindingNavigatorCountItem;
            this.bnvJogo.DeleteItem = null;
            this.bnvJogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvJogo.Location = new System.Drawing.Point(0, 0);
            this.bnvJogo.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvJogo.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvJogo.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvJogo.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvJogo.Name = "bnvJogo";
            this.bnvJogo.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvJogo.Size = new System.Drawing.Size(844, 25);
            this.bnvJogo.TabIndex = 0;
            this.bnvJogo.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Incluir Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbJogo
            // 
            this.tbJogo.Controls.Add(this.tabPage1);
            this.tbJogo.Controls.Add(this.tabPage2);
            this.tbJogo.Location = new System.Drawing.Point(63, 136);
            this.tbJogo.Name = "tbJogo";
            this.tbJogo.SelectedIndex = 0;
            this.tbJogo.Size = new System.Drawing.Size(719, 331);
            this.tbJogo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvJogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(711, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvJogo
            // 
            this.dgvJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogo.Location = new System.Drawing.Point(-4, 0);
            this.dgvJogo.Name = "dgvJogo";
            this.dgvJogo.ReadOnly = true;
            this.dgvJogo.Size = new System.Drawing.Size(715, 354);
            this.dgvJogo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtObservacao);
            this.tabPage2.Controls.Add(this.dtpDatahora);
            this.tabPage2.Controls.Add(this.cbxEstadio);
            this.tabPage2.Controls.Add(this.cbxPais2);
            this.tabPage2.Controls.Add(this.cbxPais1);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.lblObservaçao);
            this.tabPage2.Controls.Add(this.lblDataHora);
            this.tabPage2.Controls.Add(this.lblEstadio);
            this.tabPage2.Controls.Add(this.lblPais2);
            this.tabPage2.Controls.Add(this.lblPais1);
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(711, 357);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Detalhes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(87, 255);
            this.txtObservacao.MaxLength = 30;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(200, 20);
            this.txtObservacao.TabIndex = 12;
            // 
            // dtpDatahora
            // 
            this.dtpDatahora.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDatahora.Enabled = false;
            this.dtpDatahora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatahora.Location = new System.Drawing.Point(87, 213);
            this.dtpDatahora.Name = "dtpDatahora";
            this.dtpDatahora.Size = new System.Drawing.Size(200, 20);
            this.dtpDatahora.TabIndex = 11;
            // 
            // cbxEstadio
            // 
            this.cbxEstadio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadio.Enabled = false;
            this.cbxEstadio.FormattingEnabled = true;
            this.cbxEstadio.Location = new System.Drawing.Point(87, 173);
            this.cbxEstadio.Name = "cbxEstadio";
            this.cbxEstadio.Size = new System.Drawing.Size(200, 21);
            this.cbxEstadio.TabIndex = 10;
            // 
            // cbxPais2
            // 
            this.cbxPais2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPais2.Enabled = false;
            this.cbxPais2.FormattingEnabled = true;
            this.cbxPais2.Location = new System.Drawing.Point(87, 124);
            this.cbxPais2.Name = "cbxPais2";
            this.cbxPais2.Size = new System.Drawing.Size(200, 21);
            this.cbxPais2.TabIndex = 8;
            // 
            // cbxPais1
            // 
            this.cbxPais1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPais1.Enabled = false;
            this.cbxPais1.FormattingEnabled = true;
            this.cbxPais1.Location = new System.Drawing.Point(87, 78);
            this.cbxPais1.Name = "cbxPais1";
            this.cbxPais1.Size = new System.Drawing.Size(200, 21);
            this.cbxPais1.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(87, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 20);
            this.txtId.TabIndex = 6;
            // 
            // lblObservaçao
            // 
            this.lblObservaçao.AutoSize = true;
            this.lblObservaçao.Enabled = false;
            this.lblObservaçao.Location = new System.Drawing.Point(23, 258);
            this.lblObservaçao.Name = "lblObservaçao";
            this.lblObservaçao.Size = new System.Drawing.Size(65, 13);
            this.lblObservaçao.TabIndex = 5;
            this.lblObservaçao.Text = "Observaçao";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Enabled = false;
            this.lblDataHora.Location = new System.Drawing.Point(23, 213);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(56, 13);
            this.lblDataHora.TabIndex = 4;
            this.lblDataHora.Text = "Data Hora";
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Enabled = false;
            this.lblEstadio.Location = new System.Drawing.Point(23, 173);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(42, 13);
            this.lblEstadio.TabIndex = 3;
            this.lblEstadio.Text = "Estadio";
            // 
            // lblPais2
            // 
            this.lblPais2.AutoSize = true;
            this.lblPais2.Enabled = false;
            this.lblPais2.Location = new System.Drawing.Point(23, 127);
            this.lblPais2.Name = "lblPais2";
            this.lblPais2.Size = new System.Drawing.Size(36, 13);
            this.lblPais2.TabIndex = 2;
            this.lblPais2.Text = "Pais 2";
            // 
            // lblPais1
            // 
            this.lblPais1.AutoSize = true;
            this.lblPais1.Enabled = false;
            this.lblPais1.Location = new System.Drawing.Point(23, 81);
            this.lblPais1.Name = "lblPais1";
            this.lblPais1.Size = new System.Drawing.Size(36, 13);
            this.lblPais1.TabIndex = 1;
            this.lblPais1.Text = "Pais 1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(23, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PCopa0030482211042.Properties.Resources.WC2022_TicketsHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.tbJogo);
            this.Controls.Add(this.bnvJogo);
            this.DoubleBuffered = true;
            this.Name = "frmJogo";
            this.Text = "frmJogos";
            this.Load += new System.EventHandler(this.frmJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvJogo)).EndInit();
            this.bnvJogo.ResumeLayout(false);
            this.bnvJogo.PerformLayout();
            this.tbJogo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvJogo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TabControl tbJogo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvJogo;
        private System.Windows.Forms.DateTimePicker dtpDatahora;
        private System.Windows.Forms.ComboBox cbxEstadio;
        private System.Windows.Forms.ComboBox cbxPais2;
        private System.Windows.Forms.ComboBox cbxPais1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblObservaçao;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.Label lblPais2;
        private System.Windows.Forms.Label lblPais1;
        private System.Windows.Forms.Label lblID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtObservacao;
    }
}