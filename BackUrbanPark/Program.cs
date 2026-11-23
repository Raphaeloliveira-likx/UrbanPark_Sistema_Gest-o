using BackUrbanPark.Model;
using BackUrbanPark.Repository;

namespace BackUrbanPark
{
    public class Program
    {
        static void Main(string[] args)
        {
            Banco.TestarConexao();

            VagaRepository repository = new VagaRepository();

            List<Vaga> vaga = repository.ListarTodas();

            foreach(Vaga vag in vaga)
            {
                System.Console.WriteLine($"ID: {vag.Id} - Tipo: {vag.TipoStatus} {vag.TipoVaga}");
            }
        }
    }
}