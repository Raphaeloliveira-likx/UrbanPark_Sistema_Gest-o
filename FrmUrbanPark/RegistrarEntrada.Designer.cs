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
            grpBuscarVeiculo = new GroupBox();
            lblPlacaVeiculo = new Label();
            mskPlacaVeiculo = new TextBox();
            btnBuscarPlacaVeiculo = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            picLogo = new PictureBox();
            pnlCabecalho.SuspendLayout();
            grpBuscarVeiculo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.ForeColor = Color.MediumBlue;
            groupBox2.Location = new Point(14, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 120);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Veiculo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(31, 98);
            label4.Name = "label4";
            label4.Size = new Size(85, 13);
            label4.TabIndex = 2;
            label4.Text = "Cor / Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(39, 64);
            label3.Name = "label3";
            label3.Size = new Size(43, 13);
            label3.TabIndex = 2;
            label3.Text = "Placa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(46, 13);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11.25F);
            textBox4.Location = new Point(138, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F);
            textBox3.Location = new Point(138, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F);
            textBox2.Location = new Point(138, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox5);
            groupBox3.ForeColor = Color.MediumBlue;
            groupBox3.Location = new Point(396, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(392, 120);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Movimentação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(32, 94);
            label7.Name = "label7";
            label7.Size = new Size(104, 13);
            label7.TabIndex = 2;
            label7.Text = "Hora de Entrada:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(184, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(97, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(184, 59);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(97, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(32, 64);
            label6.Name = "label6";
            label6.Size = new Size(104, 13);
            label6.TabIndex = 2;
            label6.Text = "Data de Entrada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(32, 29);
            label5.Name = "label5";
            label5.Size = new Size(114, 13);
            label5.TabIndex = 2;
            label5.Text = "Vaga Selecionada:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(184, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 27);
            textBox5.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Font = new Font("Segoe UI", 11.25F);
            panel2.Location = new Point(0, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 81);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.Location = new Point(569, 40);
            button3.Name = "button3";
            button3.Size = new Size(200, 28);
            button3.TabIndex = 0;
            button3.Text = "Cancelar ";
            button3.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(324, 40);
            button1.Name = "button1";
            button1.Size = new Size(200, 28);
            button1.TabIndex = 0;
            button1.Text = "Registro Entrada";
            button1.UseVisualStyleBackColor = true;
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
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(14, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(57, 50);
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            Name = "frmRegistrarEntrada";
            Text = "UrbanPark - Registrar Entrada";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private GroupBox grpBuscarVeiculo;
        private TextBox mskPlacaVeiculo;
        private Button btnBuscarPlacaVeiculo;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lblPlacaVeiculo;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox5;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Label label10;
        private Label label9;
        private PictureBox picLogo;
    }
}