using BackUrbanPark.Model.DTO;
using BackUrbanPark.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUrbanPark
{
    public partial class frmRegistrarEntrada : Form
    {
        private string _numeroVaga;
        private int _idVaga;
        public frmRegistrarEntrada()
        {
            InitializeComponent();
        }

        public frmRegistrarEntrada(string numeroVaga, int idVaga) : this()
        {
            _numeroVaga = numeroVaga;
            _idVaga = idVaga;
        }

        private void frmRegistrarEntrada_Load(object sender, EventArgs e)
        {
            txtVagaSelecionada.Text = _numeroVaga;
            txtVagaSelecionada.Enabled = false;
        }

        private void btnBuscarPlacaVeiculo_Click(object sender, EventArgs e)
        {
            DadosEntradaVeiculo? dadosVeiculo = new DadosEntradaVeiculo();
            dadosVeiculo = EntradaRepository.BuscarDadosPorPlaca(mskPlacaVeiculo.Text);

            if (dadosVeiculo == null)
            {
                MessageBox.Show("Veiculo nao encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            txtNomeCliente.Text = dadosVeiculo.NomeCliente;
            txtCorModelo.Text = $"{dadosVeiculo.Cor} / {dadosVeiculo.Modelo }";
        }
       
    }
}
