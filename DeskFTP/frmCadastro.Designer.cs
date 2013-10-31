namespace DeskFTP
{
    partial class frmCadastro
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
            this.grpNumeroContrato = new System.Windows.Forms.GroupBox();
            this.txtNumeroContrato = new System.Windows.Forms.TextBox();
            this.grpTipoProjeto = new System.Windows.Forms.GroupBox();
            this.ddlTipoProjeto = new System.Windows.Forms.ComboBox();
            this.grpNomeProjeto = new System.Windows.Forms.GroupBox();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.grpDataRealizacao = new System.Windows.Forms.GroupBox();
            this.grpLocalRealizacao = new System.Windows.Forms.GroupBox();
            this.txtLocalRealizacao = new System.Windows.Forms.TextBox();
            this.txtDataRealizacao = new System.Windows.Forms.MaskedTextBox();
            this.grpNomeCliente = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.grpEmailCliente = new System.Windows.Forms.GroupBox();
            this.grpCaminhoFotos = new System.Windows.Forms.GroupBox();
            this.txtLocalFotos = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.fbdLocalizadorPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.btnLocalizarDiretorio = new System.Windows.Forms.Button();
            this.chkEncadernadas = new System.Windows.Forms.CheckBox();
            this.pnlEncadernadas = new System.Windows.Forms.Panel();
            this.ddlDimensoes = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pnlBrutasCD = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chkBrutasCD = new System.Windows.Forms.CheckBox();
            this.grpOrientacoesGerais = new System.Windows.Forms.GroupBox();
            this.txtOrientacoesGerais = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCriarProjeto = new System.Windows.Forms.Button();
            this.btnAdicionarFotos = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQtdFotosEncadernadas = new System.Windows.Forms.TextBox();
            this.txtQtFotosBrutas = new System.Windows.Forms.TextBox();
            this.grpNumeroContrato.SuspendLayout();
            this.grpTipoProjeto.SuspendLayout();
            this.grpNomeProjeto.SuspendLayout();
            this.grpDataRealizacao.SuspendLayout();
            this.grpLocalRealizacao.SuspendLayout();
            this.grpNomeCliente.SuspendLayout();
            this.grpEmailCliente.SuspendLayout();
            this.grpCaminhoFotos.SuspendLayout();
            this.pnlEncadernadas.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.pnlBrutasCD.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.grpOrientacoesGerais.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNumeroContrato
            // 
            this.grpNumeroContrato.Controls.Add(this.txtNumeroContrato);
            this.grpNumeroContrato.Location = new System.Drawing.Point(12, 36);
            this.grpNumeroContrato.Name = "grpNumeroContrato";
            this.grpNumeroContrato.Size = new System.Drawing.Size(262, 48);
            this.grpNumeroContrato.TabIndex = 0;
            this.grpNumeroContrato.TabStop = false;
            this.grpNumeroContrato.Text = "Contrato nº:";
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.Location = new System.Drawing.Point(15, 19);
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.Size = new System.Drawing.Size(226, 20);
            this.txtNumeroContrato.TabIndex = 1;
            // 
            // grpTipoProjeto
            // 
            this.grpTipoProjeto.Controls.Add(this.ddlTipoProjeto);
            this.grpTipoProjeto.Location = new System.Drawing.Point(12, 90);
            this.grpTipoProjeto.Name = "grpTipoProjeto";
            this.grpTipoProjeto.Size = new System.Drawing.Size(262, 48);
            this.grpTipoProjeto.TabIndex = 2;
            this.grpTipoProjeto.TabStop = false;
            this.grpTipoProjeto.Text = "Tipo Projeto";
            // 
            // ddlTipoProjeto
            // 
            this.ddlTipoProjeto.FormattingEnabled = true;
            this.ddlTipoProjeto.Items.AddRange(new object[] {
            "aniversário",
            "batizado",
            "casamento",
            "corporativo ",
            "ensaio",
            "esportivo"});
            this.ddlTipoProjeto.Location = new System.Drawing.Point(15, 20);
            this.ddlTipoProjeto.Name = "ddlTipoProjeto";
            this.ddlTipoProjeto.Size = new System.Drawing.Size(226, 21);
            this.ddlTipoProjeto.TabIndex = 0;
            // 
            // grpNomeProjeto
            // 
            this.grpNomeProjeto.Controls.Add(this.txtNomeProjeto);
            this.grpNomeProjeto.Location = new System.Drawing.Point(12, 144);
            this.grpNomeProjeto.Name = "grpNomeProjeto";
            this.grpNomeProjeto.Size = new System.Drawing.Size(262, 48);
            this.grpNomeProjeto.TabIndex = 2;
            this.grpNomeProjeto.TabStop = false;
            this.grpNomeProjeto.Text = "Nome Projeto:";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Location = new System.Drawing.Point(15, 19);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(226, 20);
            this.txtNomeProjeto.TabIndex = 1;
            // 
            // grpDataRealizacao
            // 
            this.grpDataRealizacao.Controls.Add(this.button1);
            this.grpDataRealizacao.Controls.Add(this.txtDataRealizacao);
            this.grpDataRealizacao.Location = new System.Drawing.Point(12, 198);
            this.grpDataRealizacao.Name = "grpDataRealizacao";
            this.grpDataRealizacao.Size = new System.Drawing.Size(262, 48);
            this.grpDataRealizacao.TabIndex = 3;
            this.grpDataRealizacao.TabStop = false;
            this.grpDataRealizacao.Text = "Data Realização:";
            // 
            // grpLocalRealizacao
            // 
            this.grpLocalRealizacao.Controls.Add(this.txtLocalRealizacao);
            this.grpLocalRealizacao.Location = new System.Drawing.Point(12, 409);
            this.grpLocalRealizacao.Name = "grpLocalRealizacao";
            this.grpLocalRealizacao.Size = new System.Drawing.Size(262, 48);
            this.grpLocalRealizacao.TabIndex = 3;
            this.grpLocalRealizacao.TabStop = false;
            this.grpLocalRealizacao.Text = "Local Realizacao:";
            // 
            // txtLocalRealizacao
            // 
            this.txtLocalRealizacao.Location = new System.Drawing.Point(15, 19);
            this.txtLocalRealizacao.Name = "txtLocalRealizacao";
            this.txtLocalRealizacao.Size = new System.Drawing.Size(226, 20);
            this.txtLocalRealizacao.TabIndex = 1;
            // 
            // txtDataRealizacao
            // 
            this.txtDataRealizacao.Location = new System.Drawing.Point(15, 19);
            this.txtDataRealizacao.Mask = "00/00/0000";
            this.txtDataRealizacao.Name = "txtDataRealizacao";
            this.txtDataRealizacao.Size = new System.Drawing.Size(196, 20);
            this.txtDataRealizacao.TabIndex = 4;
            this.txtDataRealizacao.ValidatingType = typeof(System.DateTime);
            // 
            // grpNomeCliente
            // 
            this.grpNomeCliente.Controls.Add(this.txtNomeCliente);
            this.grpNomeCliente.Location = new System.Drawing.Point(12, 463);
            this.grpNomeCliente.Name = "grpNomeCliente";
            this.grpNomeCliente.Size = new System.Drawing.Size(262, 48);
            this.grpNomeCliente.TabIndex = 4;
            this.grpNomeCliente.TabStop = false;
            this.grpNomeCliente.Text = "Nome Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(15, 19);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(225, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // grpEmailCliente
            // 
            this.grpEmailCliente.Controls.Add(this.txtEmailCliente);
            this.grpEmailCliente.Location = new System.Drawing.Point(12, 517);
            this.grpEmailCliente.Name = "grpEmailCliente";
            this.grpEmailCliente.Size = new System.Drawing.Size(262, 48);
            this.grpEmailCliente.TabIndex = 4;
            this.grpEmailCliente.TabStop = false;
            this.grpEmailCliente.Text = "E-mail Cliente:";
            // 
            // grpCaminhoFotos
            // 
            this.grpCaminhoFotos.Controls.Add(this.btnLocalizarDiretorio);
            this.grpCaminhoFotos.Controls.Add(this.txtLocalFotos);
            this.grpCaminhoFotos.Location = new System.Drawing.Point(12, 571);
            this.grpCaminhoFotos.Name = "grpCaminhoFotos";
            this.grpCaminhoFotos.Size = new System.Drawing.Size(262, 48);
            this.grpCaminhoFotos.TabIndex = 4;
            this.grpCaminhoFotos.TabStop = false;
            this.grpCaminhoFotos.Text = "Caminho Fotos Cliente:";
            // 
            // txtLocalFotos
            // 
            this.txtLocalFotos.Location = new System.Drawing.Point(15, 19);
            this.txtLocalFotos.Name = "txtLocalFotos";
            this.txtLocalFotos.Size = new System.Drawing.Size(211, 20);
            this.txtLocalFotos.TabIndex = 1;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(15, 19);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(226, 20);
            this.txtEmailCliente.TabIndex = 2;
            // 
            // fbdLocalizadorPasta
            // 
            this.fbdLocalizadorPasta.ShowNewFolderButton = false;
            // 
            // btnLocalizarDiretorio
            // 
            this.btnLocalizarDiretorio.Location = new System.Drawing.Point(235, 16);
            this.btnLocalizarDiretorio.Name = "btnLocalizarDiretorio";
            this.btnLocalizarDiretorio.Size = new System.Drawing.Size(21, 23);
            this.btnLocalizarDiretorio.TabIndex = 5;
            this.btnLocalizarDiretorio.Text = "...";
            this.btnLocalizarDiretorio.UseVisualStyleBackColor = true;
            this.btnLocalizarDiretorio.Click += new System.EventHandler(this.btnLocalizarDiretorio_Click);
            // 
            // chkEncadernadas
            // 
            this.chkEncadernadas.AutoSize = true;
            this.chkEncadernadas.Location = new System.Drawing.Point(15, 15);
            this.chkEncadernadas.Name = "chkEncadernadas";
            this.chkEncadernadas.Size = new System.Drawing.Size(95, 17);
            this.chkEncadernadas.TabIndex = 6;
            this.chkEncadernadas.Text = "Encadernadas";
            this.chkEncadernadas.UseVisualStyleBackColor = true;
            this.chkEncadernadas.CheckedChanged += new System.EventHandler(this.chkEncadernadas_CheckedChanged);
            // 
            // pnlEncadernadas
            // 
            this.pnlEncadernadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncadernadas.Controls.Add(this.groupBox9);
            this.pnlEncadernadas.Controls.Add(this.ddlDimensoes);
            this.pnlEncadernadas.Controls.Add(this.chkEncadernadas);
            this.pnlEncadernadas.Location = new System.Drawing.Point(12, 264);
            this.pnlEncadernadas.Name = "pnlEncadernadas";
            this.pnlEncadernadas.Size = new System.Drawing.Size(128, 125);
            this.pnlEncadernadas.TabIndex = 7;
            // 
            // ddlDimensoes
            // 
            this.ddlDimensoes.FormattingEnabled = true;
            this.ddlDimensoes.Items.AddRange(new object[] {
            "24 x 60",
            "20 x 25"});
            this.ddlDimensoes.Location = new System.Drawing.Point(15, 38);
            this.ddlDimensoes.Name = "ddlDimensoes";
            this.ddlDimensoes.Size = new System.Drawing.Size(99, 21);
            this.ddlDimensoes.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtQtdFotosEncadernadas);
            this.groupBox9.Location = new System.Drawing.Point(15, 65);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(90, 48);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Qtde Fotos:";
            // 
            // pnlBrutasCD
            // 
            this.pnlBrutasCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrutasCD.Controls.Add(this.groupBox10);
            this.pnlBrutasCD.Controls.Add(this.chkBrutasCD);
            this.pnlBrutasCD.Location = new System.Drawing.Point(146, 264);
            this.pnlBrutasCD.Name = "pnlBrutasCD";
            this.pnlBrutasCD.Size = new System.Drawing.Size(128, 125);
            this.pnlBrutasCD.TabIndex = 8;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtQtFotosBrutas);
            this.groupBox10.Location = new System.Drawing.Point(15, 65);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(90, 48);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Qtde Fotos:";
            // 
            // chkBrutasCD
            // 
            this.chkBrutasCD.AutoSize = true;
            this.chkBrutasCD.Location = new System.Drawing.Point(15, 15);
            this.chkBrutasCD.Name = "chkBrutasCD";
            this.chkBrutasCD.Size = new System.Drawing.Size(91, 17);
            this.chkBrutasCD.TabIndex = 6;
            this.chkBrutasCD.Text = "Brutas em CD";
            this.chkBrutasCD.UseVisualStyleBackColor = true;
            this.chkBrutasCD.CheckedChanged += new System.EventHandler(this.chkBrutasCD_CheckedChanged);
            // 
            // grpOrientacoesGerais
            // 
            this.grpOrientacoesGerais.Controls.Add(this.calendario);
            this.grpOrientacoesGerais.Controls.Add(this.txtOrientacoesGerais);
            this.grpOrientacoesGerais.Location = new System.Drawing.Point(295, 31);
            this.grpOrientacoesGerais.Name = "grpOrientacoesGerais";
            this.grpOrientacoesGerais.Size = new System.Drawing.Size(357, 593);
            this.grpOrientacoesGerais.TabIndex = 9;
            this.grpOrientacoesGerais.TabStop = false;
            this.grpOrientacoesGerais.Text = "Orientações Gerais:";
            // 
            // txtOrientacoesGerais
            // 
            this.txtOrientacoesGerais.Location = new System.Drawing.Point(22, 24);
            this.txtOrientacoesGerais.Multiline = true;
            this.txtOrientacoesGerais.Name = "txtOrientacoesGerais";
            this.txtOrientacoesGerais.Size = new System.Drawing.Size(315, 555);
            this.txtOrientacoesGerais.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnAdicionarFotos);
            this.panel1.Controls.Add(this.btnCriarProjeto);
            this.panel1.Location = new System.Drawing.Point(672, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 111);
            this.panel1.TabIndex = 10;
            // 
            // btnCriarProjeto
            // 
            this.btnCriarProjeto.Location = new System.Drawing.Point(19, 14);
            this.btnCriarProjeto.Name = "btnCriarProjeto";
            this.btnCriarProjeto.Size = new System.Drawing.Size(119, 23);
            this.btnCriarProjeto.TabIndex = 11;
            this.btnCriarProjeto.Text = "Criar Projeto";
            this.btnCriarProjeto.UseVisualStyleBackColor = true;
            this.btnCriarProjeto.Click += new System.EventHandler(this.btnCriarProjeto_Click);
            // 
            // btnAdicionarFotos
            // 
            this.btnAdicionarFotos.Location = new System.Drawing.Point(19, 43);
            this.btnAdicionarFotos.Name = "btnAdicionarFotos";
            this.btnAdicionarFotos.Size = new System.Drawing.Size(119, 23);
            this.btnAdicionarFotos.TabIndex = 12;
            this.btnAdicionarFotos.Text = "Adicionar Fotos";
            this.btnAdicionarFotos.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(19, 71);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 23);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(12, 177);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 11;
            this.calendario.Visible = false;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.calendario.MouseLeave += new System.EventHandler(this.calendario_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQtdFotosEncadernadas
            // 
            this.txtQtdFotosEncadernadas.Location = new System.Drawing.Point(7, 20);
            this.txtQtdFotosEncadernadas.MaxLength = 5;
            this.txtQtdFotosEncadernadas.Name = "txtQtdFotosEncadernadas";
            this.txtQtdFotosEncadernadas.Size = new System.Drawing.Size(77, 20);
            this.txtQtdFotosEncadernadas.TabIndex = 0;
            // 
            // txtQtFotosBrutas
            // 
            this.txtQtFotosBrutas.Location = new System.Drawing.Point(7, 20);
            this.txtQtFotosBrutas.MaxLength = 5;
            this.txtQtFotosBrutas.Name = "txtQtFotosBrutas";
            this.txtQtFotosBrutas.Size = new System.Drawing.Size(77, 20);
            this.txtQtFotosBrutas.TabIndex = 1;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpOrientacoesGerais);
            this.Controls.Add(this.pnlBrutasCD);
            this.Controls.Add(this.pnlEncadernadas);
            this.Controls.Add(this.grpNomeCliente);
            this.Controls.Add(this.grpEmailCliente);
            this.Controls.Add(this.grpCaminhoFotos);
            this.Controls.Add(this.grpLocalRealizacao);
            this.Controls.Add(this.grpDataRealizacao);
            this.Controls.Add(this.grpNomeProjeto);
            this.Controls.Add(this.grpTipoProjeto);
            this.Controls.Add(this.grpNumeroContrato);
            this.Name = "frmCadastro";
            this.Text = "Cadastro Projeto";
            this.grpNumeroContrato.ResumeLayout(false);
            this.grpNumeroContrato.PerformLayout();
            this.grpTipoProjeto.ResumeLayout(false);
            this.grpNomeProjeto.ResumeLayout(false);
            this.grpNomeProjeto.PerformLayout();
            this.grpDataRealizacao.ResumeLayout(false);
            this.grpDataRealizacao.PerformLayout();
            this.grpLocalRealizacao.ResumeLayout(false);
            this.grpLocalRealizacao.PerformLayout();
            this.grpNomeCliente.ResumeLayout(false);
            this.grpNomeCliente.PerformLayout();
            this.grpEmailCliente.ResumeLayout(false);
            this.grpEmailCliente.PerformLayout();
            this.grpCaminhoFotos.ResumeLayout(false);
            this.grpCaminhoFotos.PerformLayout();
            this.pnlEncadernadas.ResumeLayout(false);
            this.pnlEncadernadas.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.pnlBrutasCD.ResumeLayout(false);
            this.pnlBrutasCD.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.grpOrientacoesGerais.ResumeLayout(false);
            this.grpOrientacoesGerais.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNumeroContrato;
        private System.Windows.Forms.TextBox txtNumeroContrato;
        private System.Windows.Forms.GroupBox grpTipoProjeto;
        private System.Windows.Forms.ComboBox ddlTipoProjeto;
        private System.Windows.Forms.GroupBox grpNomeProjeto;
        private System.Windows.Forms.TextBox txtNomeProjeto;
        private System.Windows.Forms.GroupBox grpDataRealizacao;
        private System.Windows.Forms.MaskedTextBox txtDataRealizacao;
        private System.Windows.Forms.GroupBox grpLocalRealizacao;
        private System.Windows.Forms.TextBox txtLocalRealizacao;
        private System.Windows.Forms.GroupBox grpNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox grpEmailCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.GroupBox grpCaminhoFotos;
        private System.Windows.Forms.TextBox txtLocalFotos;
        private System.Windows.Forms.FolderBrowserDialog fbdLocalizadorPasta;
        private System.Windows.Forms.Button btnLocalizarDiretorio;
        private System.Windows.Forms.CheckBox chkEncadernadas;
        private System.Windows.Forms.Panel pnlEncadernadas;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox ddlDimensoes;
        private System.Windows.Forms.Panel pnlBrutasCD;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox chkBrutasCD;
        private System.Windows.Forms.GroupBox grpOrientacoesGerais;
        private System.Windows.Forms.TextBox txtOrientacoesGerais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCriarProjeto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionarFotos;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtQtdFotosEncadernadas;
        private System.Windows.Forms.TextBox txtQtFotosBrutas;
    }
}