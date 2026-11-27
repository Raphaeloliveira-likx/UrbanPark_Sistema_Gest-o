namespace FrmUrbanPark
{
    partial class frmRegistrarSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarSaida));
            pnlCabecalho = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            grpBuscarVeiculo = new GroupBox();
            btnBuscarPorPlaca = new Button();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            lblNumeroVaga = new TextBox();
            txtCorModelo = new TextBox();
            textBox3 = new TextBox();
            lblNomeCliente = new TextBox();
            lblVaga = new Label();
            lblCorModelo = new Label();
            lblPlaca = new Label();
            lblCliente = new Label();
            grpMovimentacao = new GroupBox();
            panel2 = new Panel();
            lblValorAPagar = new Label();
            label18 = new Label();
            lblInfoTarifa = new TextBox();
            lblInfoTempoPermanencia = new TextBox();
            dtInfoHrSaida = new DateTimePicker();
            dtInfoDtSaida = new DateTimePicker();
            lblDtHoraEntrada = new DateTimePicker();
            lblTarifaVigente = new Label();
            lblTempoPermanencia = new Label();
            grpCalculo = new Label();
            label9 = new Label();
            lblHoraSaida = new Label();
            lblDataSaida = new Label();
            lblDataHoraEntrada = new Label();
            btnRegistrarSaida = new Button();
            btnCancelar = new Button();
            mskPlacaveiculo = new MaskedTextBox();
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
            pnlCabecalho.Controls.Add(label15);
            pnlCabecalho.Controls.Add(label14);
            pnlCabecalho.Controls.Add(label13);
            pnlCabecalho.Font = new Font("Consolas", 36F, FontStyle.Bold);
            pnlCabecalho.Location = new Point(2, 1);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(850, 88);
            pnlCabecalho.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(22, 22);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(57, 50);
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.Control;
            lblSubtitulo.Location = new Point(293, 50);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(549, 19);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Finaliza a movimentação e calcula o valor do estacionamento.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(293, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(255, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Saida";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Consolas", 36F, FontStyle.Bold);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(264, 18);
            label15.Name = "label15";
            label15.Size = new Size(50, 56);
            label15.TabIndex = 0;
            label15.Text = "|";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(95, 31);
            label14.Name = "label14";
            label14.Size = new Size(179, 37);
            label14.TabIndex = 0;
            label14.Text = "UrbanPark";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 36F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(68, 16);
            label13.Name = "label13";
            label13.Size = new Size(50, 56);
            label13.TabIndex = 0;
            label13.Text = "|";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.MidnightBlue;
            grpBuscarVeiculo.Location = new Point(5, 97);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(835, 72);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veiculo";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.BackColor = Color.SteelBlue;
            btnBuscarPorPlaca.ForeColor = Color.AliceBlue;
            btnBuscarPorPlaca.Image = (Image)resources.GetObject("btnBuscarPorPlaca.Image");
            btnBuscarPorPlaca.Location = new Point(269, 26);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(186, 30);
            btnBuscarPorPlaca.TabIndex = 4;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarPorPlaca.UseVisualStyleBackColor = false;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            lblPlacaVeiculo.Location = new Point(12, 34);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(126, 15);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa do Veiculo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(lblNumeroVaga);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(textBox3);
            grpDadosVeiculo.Controls.Add(lblNomeCliente);
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.MidnightBlue;
            grpDadosVeiculo.Location = new Point(6, 182);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(337, 263);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veiculo";
            // 
            // lblNumeroVaga
            // 
            lblNumeroVaga.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            lblNumeroVaga.Location = new Point(129, 173);
            lblNumeroVaga.Name = "lblNumeroVaga";
            lblNumeroVaga.Size = new Size(93, 25);
            lblNumeroVaga.TabIndex = 1;
            // 
            // txtCorModelo
            // 
            txtCorModelo.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            txtCorModelo.Location = new Point(129, 128);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(180, 25);
            txtCorModelo.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            textBox3.Location = new Point(129, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 25);
            textBox3.TabIndex = 1;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            lblNomeCliente.Location = new Point(129, 47);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(180, 25);
            lblNomeCliente.TabIndex = 1;
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            lblVaga.ForeColor = SystemColors.ActiveCaptionText;
            lblVaga.Location = new Point(19, 176);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(48, 18);
            lblVaga.TabIndex = 0;
            lblVaga.Text = "Vaga:";
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            lblCorModelo.ForeColor = SystemColors.ActiveCaptionText;
            lblCorModelo.Location = new Point(11, 133);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(112, 18);
            lblCorModelo.TabIndex = 0;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            lblPlaca.ForeColor = SystemColors.ActiveCaptionText;
            lblPlaca.Location = new Point(19, 89);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(56, 18);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            lblCliente.ForeColor = SystemColors.ActiveCaptionText;
            lblCliente.Location = new Point(19, 50);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(72, 18);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(panel2);
            grpMovimentacao.Controls.Add(lblInfoTarifa);
            grpMovimentacao.Controls.Add(lblInfoTempoPermanencia);
            grpMovimentacao.Controls.Add(dtInfoHrSaida);
            grpMovimentacao.Controls.Add(dtInfoDtSaida);
            grpMovimentacao.Controls.Add(lblDtHoraEntrada);
            grpMovimentacao.Controls.Add(lblTarifaVigente);
            grpMovimentacao.Controls.Add(lblTempoPermanencia);
            grpMovimentacao.Controls.Add(grpCalculo);
            grpMovimentacao.Controls.Add(label9);
            grpMovimentacao.Controls.Add(lblHoraSaida);
            grpMovimentacao.Controls.Add(lblDataSaida);
            grpMovimentacao.Controls.Add(lblDataHoraEntrada);
            grpMovimentacao.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = Color.MidnightBlue;
            grpMovimentacao.Location = new Point(364, 182);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(476, 263);
            grpMovimentacao.TabIndex = 3;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(lblValorAPagar);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(20, 225);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 32);
            panel2.TabIndex = 3;
            // 
            // lblValorAPagar
            // 
            lblValorAPagar.AutoSize = true;
            lblValorAPagar.Location = new Point(212, 6);
            lblValorAPagar.Name = "lblValorAPagar";
            lblValorAPagar.Size = new Size(81, 19);
            lblValorAPagar.TabIndex = 0;
            lblValorAPagar.Text = "R$ 26,50";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 6);
            label18.Name = "label18";
            label18.Size = new Size(135, 19);
            label18.TabIndex = 0;
            label18.Text = "Valor a Pagar:";
            // 
            // lblInfoTarifa
            // 
            lblInfoTarifa.Location = new Point(232, 195);
            lblInfoTarifa.Name = "lblInfoTarifa";
            lblInfoTarifa.Size = new Size(150, 26);
            lblInfoTarifa.TabIndex = 2;
            // 
            // lblInfoTempoPermanencia
            // 
            lblInfoTempoPermanencia.Location = new Point(232, 161);
            lblInfoTempoPermanencia.Name = "lblInfoTempoPermanencia";
            lblInfoTempoPermanencia.Size = new Size(150, 26);
            lblInfoTempoPermanencia.TabIndex = 2;
            // 
            // dtInfoHrSaida
            // 
            dtInfoHrSaida.CustomFormat = "HH:mm";
            dtInfoHrSaida.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInfoHrSaida.Format = DateTimePickerFormat.Custom;
            dtInfoHrSaida.Location = new Point(357, 62);
            dtInfoHrSaida.Name = "dtInfoHrSaida";
            dtInfoHrSaida.Size = new Size(67, 23);
            dtInfoHrSaida.TabIndex = 1;
            // 
            // dtInfoDtSaida
            // 
            dtInfoDtSaida.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInfoDtSaida.Format = DateTimePickerFormat.Short;
            dtInfoDtSaida.Location = new Point(115, 62);
            dtInfoDtSaida.Name = "dtInfoDtSaida";
            dtInfoDtSaida.Size = new Size(129, 23);
            dtInfoDtSaida.TabIndex = 1;
            // 
            // lblDtHoraEntrada
            // 
            lblDtHoraEntrada.CustomFormat = "00/00/0000 HH:mm";
            lblDtHoraEntrada.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDtHoraEntrada.Format = DateTimePickerFormat.Custom;
            lblDtHoraEntrada.Location = new Point(199, 24);
            lblDtHoraEntrada.Name = "lblDtHoraEntrada";
            lblDtHoraEntrada.Size = new Size(200, 23);
            lblDtHoraEntrada.TabIndex = 1;
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            lblTarifaVigente.ForeColor = SystemColors.ActiveCaptionText;
            lblTarifaVigente.Location = new Point(25, 201);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(112, 15);
            lblTarifaVigente.TabIndex = 0;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // lblTempoPermanencia
            // 
            lblTempoPermanencia.AutoSize = true;
            lblTempoPermanencia.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            lblTempoPermanencia.ForeColor = SystemColors.ActiveCaptionText;
            lblTempoPermanencia.Location = new Point(20, 167);
            lblTempoPermanencia.Name = "lblTempoPermanencia";
            lblTempoPermanencia.Size = new Size(154, 15);
            lblTempoPermanencia.TabIndex = 0;
            lblTempoPermanencia.Text = "Tempo de Permanência:";
            // 
            // grpCalculo
            // 
            grpCalculo.AutoSize = true;
            grpCalculo.Location = new Point(25, 132);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Size = new Size(234, 19);
            grpCalculo.TabIndex = 0;
            grpCalculo.Text = "Cálculo do Estacionamento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 105);
            label9.Name = "label9";
            label9.Size = new Size(495, 19);
            label9.TabIndex = 0;
            label9.Text = "______________________________________________________";
            // 
            // lblHoraSaida
            // 
            lblHoraSaida.AutoSize = true;
            lblHoraSaida.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            lblHoraSaida.ForeColor = SystemColors.ActiveCaptionText;
            lblHoraSaida.Location = new Point(250, 68);
            lblHoraSaida.Name = "lblHoraSaida";
            lblHoraSaida.Size = new Size(105, 15);
            lblHoraSaida.TabIndex = 0;
            lblHoraSaida.Text = "Hora de Saida:";
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            lblDataSaida.ForeColor = SystemColors.ActiveCaptionText;
            lblDataSaida.Location = new Point(6, 68);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(105, 15);
            lblDataSaida.TabIndex = 0;
            lblDataSaida.Text = "Data de Saida:";
            // 
            // lblDataHoraEntrada
            // 
            lblDataHoraEntrada.AutoSize = true;
            lblDataHoraEntrada.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            lblDataHoraEntrada.ForeColor = SystemColors.ActiveCaptionText;
            lblDataHoraEntrada.Location = new Point(6, 29);
            lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            lblDataHoraEntrada.Size = new Size(168, 15);
            lblDataHoraEntrada.TabIndex = 0;
            lblDataHoraEntrada.Text = "Data / Hora de Entrada:";
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.BackColor = Color.Green;
            btnRegistrarSaida.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarSaida.ForeColor = SystemColors.Control;
            btnRegistrarSaida.Image = (Image)resources.GetObject("btnRegistrarSaida.Image");
            btnRegistrarSaida.Location = new Point(389, 463);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(186, 31);
            btnRegistrarSaida.TabIndex = 4;
            btnRegistrarSaida.Text = "Registrar Saida";
            btnRegistrarSaida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarSaida.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(596, 463);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Location = new Point(144, 28);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(100, 26);
            mskPlacaveiculo.TabIndex = 5;
            // 
            // frmRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 514);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarSaida);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmRegistrarSaida";
            Text = "Urbanpark - Registrar Saida";
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
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private GroupBox grpBuscarVeiculo;
        private Label lblPlacaVeiculo;
        private GroupBox grpDadosVeiculo;
        private TextBox lblNumeroVaga;
        private TextBox txtCorModelo;
        private TextBox textBox3;
        private TextBox lblNomeCliente;
        private Label lblVaga;
        private Label lblCorModelo;
        private Label lblPlaca;
        private Label lblCliente;
        private GroupBox grpMovimentacao;
        private DateTimePicker dtInfoDtSaida;
        private DateTimePicker lblDtHoraEntrada;
        private Label lblTarifaVigente;
        private Label lblTempoPermanencia;
        private Label grpCalculo;
        private Label label9;
        private Label lblHoraSaida;
        private Label lblDataSaida;
        private Label lblDataHoraEntrada;
        private TextBox lblInfoTarifa;
        private TextBox lblInfoTempoPermanencia;
        private DateTimePicker dtInfoHrSaida;
        private Button btnRegistrarSaida;
        private Button btnCancelar;
        private Button btnBuscarPorPlaca;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Label label15;
        private Label label14;
        private Label label13;
        private PictureBox picLogo;
        private Panel panel2;
        private Label lblValorAPagar;
        private Label label18;
        private MaskedTextBox mskPlacaveiculo;
    }
}