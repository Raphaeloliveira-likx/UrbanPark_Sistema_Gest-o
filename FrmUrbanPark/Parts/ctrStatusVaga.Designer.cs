namespace FrmUrbanPark.Parts
{
    partial class ctrStatusVaga
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblStatusVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carIconVerde;
            pictureBox1.Location = new Point(48, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblStatusVaga
            // 
            lblStatusVaga.AutoSize = true;
            lblStatusVaga.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusVaga.Location = new Point(46, 30);
            lblStatusVaga.Name = "lblStatusVaga";
            lblStatusVaga.Size = new Size(54, 19);
            lblStatusVaga.TabIndex = 1;
            lblStatusVaga.Text = "LIVRE";
            // 
            // ctrStatusVaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblStatusVaga);
            Controls.Add(pictureBox1);
            Name = "ctrStatusVaga";
            Size = new Size(148, 148);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblStatusVaga;
    }
}
