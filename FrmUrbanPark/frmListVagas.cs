using BackUrbanPark.Model;
using BackUrbanPark.Repository;
using FrmUrbanPark.Parts;
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
    public partial class frmListVagas : Form
    {
        public frmListVagas()
        {
            InitializeComponent();
        }

        private void frmListVagas_Load(object sender, EventArgs e)
        {
            carregarDadosEMontarVisualizacao();
        }
        private void carregarDadosEMontarVisualizacao()
        {
            List<Vaga> listaDeVagas = VagaRepository.ListarTodas();

            flwCardVagas.Controls.Clear();

            foreach(Vaga vaga in listaDeVagas)
            {
                string strNumeroVaga = vaga.Numero_vaga.ToString();
                StatusVaga statusVaga = Enum.Parse<StatusVaga>(vaga.TipoStatus.ToString());
                int idVaga = vaga.Id;

                ctrStatusVaga cardVaga = new ctrStatusVaga();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;

                flwCardVagas.Controls.Add(cardVaga);
            }
        }
    }
}
