using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUrbanPark.Model
{
    public class Vaga
    {
        // direito sobre vaga, acoes rapidas e refatoração
        //gerar construtor a partir de membros 
        private int _id;
        private int _numero_vaga;
        private TipoVaga tipoVaga;
        private TipoStatus tipoStatus;

        public Vaga(int numero_vaga, TipoVaga tipoVaga, TipoStatus tipoStatus)
        {
            Numero_vaga = numero_vaga;
            this.TipoVaga = tipoVaga;
            this.TipoStatus = tipoStatus;
        }

        public Vaga(int id, int numero_vaga, TipoVaga tipoVaga, TipoStatus tipoStatus)
        {
            Id = id;
            Numero_vaga = numero_vaga;
            this.TipoVaga = tipoVaga;
            this.TipoStatus = tipoStatus;
        }

        public int Id { get => _id; set => _id = value; }
        public int Numero_vaga { get => _numero_vaga; set => _numero_vaga = value; }
        public TipoVaga TipoVaga { get => tipoVaga; set => tipoVaga = value; }
        public TipoStatus TipoStatus { get => tipoStatus; set => tipoStatus = value; }
    }
}
