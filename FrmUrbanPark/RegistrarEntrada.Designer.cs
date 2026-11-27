namespace FrmUrbanPark
{
    partial class frmRegistrarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEntrada));
            pnlCabecalho = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            grpBuscarVeiculo = new GroupBox();
            lblPlacaVeiculo = new Label();
            mskPlacaVeiculo = new TextBox();
            btnBuscarPlacaVeiculo = new Button();
            grpDadosVeiculo = new GroupBox();
            lblCorModelo = new Label();
            lblCliente = new Label();
            txtCorModelo = new TextBox();
            txtNomeCliente = new TextBox();
            grpMovimentacao = new GroupBox();
            lblHoraEntrada = new Label();
            dtInfoHrEntrada = new DateTimePicker();
            dtInfoDtEntrada = new DateTimePicker();
            lblDataEntrada = new Label();
            lblVagaSelecionada = new Label();
            txtVagaSelecionada = new TextBox();
            panel2 = new Panel();
            btnCancelar = new Button();
            button2 = new Button();
            btnRegistrarEntrada = new Button();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.MediumBlue;
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(label10);
            pnlCabecalho.Controls.Add(label9);
            pnlCabecalho.Controls.Add(label8);
            pnlCabecalho.Location = new Point(0, 1);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(801, 87);
            pnlCabecalho.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(14, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(57, 50);
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.Control;
            lblSubtitulo.Location = new Point(307, 45);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(428, 20);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "inicia a movimentação do veiculo no estacionamento";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(307, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Registrar Entrada";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(286, 10);
            label10.Name = "label10";
            label10.Size = new Size(36, 55);
            label10.TabIndex = 1;
            label10.Text = "|";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(77, 10);
            label9.Name = "label9";
            label9.Size = new Size(36, 55);
            label9.TabIndex = 1;
            label9.Text = "|";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(104, 25);
            label8.Name = "label8";
            label8.Size = new Size(197, 37);
            label8.TabIndex = 0;
            label8.Text = "UrBanPark ";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(mskPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(btnBuscarPlacaVeiculo);
            grpBuscarVeiculo.ForeColor = Color.MediumBlue;
            grpBuscarVeiculo.Location = new Point(14, 103);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(774, 66);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veiculo";
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(81, 27);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(103, 13);
            lblPlacaVeiculo.TabIndex = 2;
            lblPlacaVeiculo.Text = "Placa do Veiculo";
            // 
            // mskPlacaVeiculo
            // 
            mskPlacaVeiculo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mskPlacaVeiculo.Location = new Point(228, 23);
            mskPlacaVeiculo.Name = "mskPlacaVeiculo";
            mskPlacaVeiculo.Size = new Size(161, 22);
            mskPlacaVeiculo.TabIndex = 1;
            // 
            // btnBuscarPlacaVeiculo
            // 
            btnBuscarPlacaVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarPlacaVeiculo.Image = (Image)resources.GetObject("btnBuscarPlacaVeiculo.Image");
            btnBuscarPlacaVeiculo.Location = new Point(445, 16);
            btnBuscarPlacaVeiculo.Name = "btnBuscarPlacaVeiculo";
            btnBuscarPlacaVeiculo.Size = new Size(220, 35);
            btnBuscarPlacaVeiculo.TabIndex = 0;
            btnBuscarPlacaVeiculo.Text = "Buscar Placa";
            btnBuscarPlacaVeiculo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarPlacaVeiculo.UseVisualStyleBackColor = true;
            btnBuscarPlacaVeiculo.Click += btnBuscarPlacaVeiculo_Click;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.ForeColor = Color.MediumBlue;
            grpDadosVeiculo.Location = new Point(14, 182);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(344, 120);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veiculo";
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblCorModelo.ForeColor = SystemColors.ActiveCaptionText;
            lblCorModelo.Location = new Point(31, 76);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(85, 13);
            lblCorModelo.TabIndex = 2;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblCliente.ForeColor = SystemColors.ActiveCaptionText;
            lblCliente.Location = new Point(31, 29);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(46, 13);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente";
            // 
            // txtCorModelo
            // 
            txtCorModelo.Font = new Font("Segoe UI", 11.25F);
            txtCorModelo.Location = new Point(138, 67);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(161, 27);
            txtCorModelo.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 11.25F);
            txtNomeCliente.Location = new Point(138, 27);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(161, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.ForeColor = Color.MediumBlue;
            grpMovimentacao.Location = new Point(396, 182);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(392, 120);
            grpMovimentacao.TabIndex = 2;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblHoraEntrada.ForeColor = SystemColors.ActiveCaptionText;
            lblHoraEntrada.Location = new Point(32, 94);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(104, 13);
            lblHoraEntrada.TabIndex = 2;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CustomFormat = "HH:mm";
            dtInfoHrEntrada.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoHrEntrada.Location = new Point(184, 90);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(97, 27);
            dtInfoHrEntrada.TabIndex = 2;
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(184, 59);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(97, 27);
            dtInfoDtEntrada.TabIndex = 2;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblDataEntrada.ForeColor = SystemColors.ActiveCaptionText;
            lblDataEntrada.Location = new Point(32, 64);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(104, 13);
            lblDataEntrada.TabIndex = 2;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblVagaSelecionada.ForeColor = SystemColors.ActiveCaptionText;
            lblVagaSelecionada.Location = new Point(32, 29);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(114, 13);
            lblVagaSelecionada.TabIndex = 2;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVagaSelecionada.Location = new Point(184, 27);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(97, 27);
            txtVagaSelecionada.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnRegistrarEntrada);
            panel2.Font = new Font("Segoe UI", 11.25F);
            panel2.Location = new Point(0, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 81);
            panel2.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(569, 40);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 28);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar ";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(569, 40);
            button2.Name = "button2";
            button2.Size = new Size(200, 28);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRegistrarEntrada.Location = new Point(324, 40);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(200, 28);
            btnRegistrarEntrada.TabIndex = 0;
            btnRegistrarEntrada.Text = "Registro Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(panel2);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            Name = "frmRegistrarEntrada";
            Text = "UrbanPark - Registrar Entrada";
            Load += frmRegistrarEntrada_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private GroupBox grpBuscarVeiculo;
        private TextBox mskPlacaVeiculo;
        private Button btnBuscarPlacaVeiculo;
        private GroupBox grpDadosVeiculo;
        private TextBox txtCorModelo;
        private TextBox txtNomeCliente;
        private GroupBox grpMovimentacao;
        private Panel panel2;
        private Button btnCancelar;
        private Button button2;
        private Button btnRegistrarEntrada;
        private Label lblPlacaVeiculo;
        private Label lblCorModelo;
        private Label lblCliente;
        private DateTimePicker dtInfoDtEntrada;
        private TextBox txtVagaSelecionada;
        private Label lblHoraEntrada;
        private Label lblDataEntrada;
        private Label lblVagaSelecionada;
        private DateTimePicker dtInfoHrEntrada;
        private Label label8;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Label label10;
        private Label label9;
        private PictureBox picLogo;
    }
}