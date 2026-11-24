using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackUrbanPark.Model;

namespace BackUrbanPark.Repository
{
    public static class VagaRepository
    {
        /// <summary>
        /// Insere uma vaga no banco de dados 
        ///</summary>
        ///<param name="vaga"><</param>
        ///<returns></returns>
        
        public static int Inserir(Vaga vaga)
        {
            return 1;
        }

        public static Vaga? ListarPorId(int id)
        {
            string sql = "SELECT id_vaga, numero_vaga, tipo, status FROM vagas WHERE id = @id";

            using (var cmd = new MySqlCommand(sql))
            {
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = Banco.ExecutarConsulta(cmd))
                {

                    if (reader.Read())
                    {
                        return MapearVaga(reader);
                    }

                }
            }
            return null;
        }

        public static List<Vaga> ListarTodas()
        {

            string sql = "SELECT id_vaga, numero_vaga, tipo, status FROM vagas";

            List<Vaga> vagas = new();

            using (var cmd = new MySqlCommand(sql))
            {

                using (var reader = Banco.ExecutarConsulta(cmd))
                {

                    while (reader.Read())
                    {

                        vagas.Add(MapearVaga(reader));
                    }
                }
            }
            return vagas;
        }
        private static Vaga MapearVaga(MySqlDataReader reader)
        {

            int id_vaga = reader.GetInt32("id_vaga");
            int numero_vaga = reader.GetInt32("numero_vaga");
            TipoVaga tipoVaga = Enum.Parse<TipoVaga>(reader.GetString("tipo"));
            TipoStatus tipoStatus = Enum.Parse<TipoStatus>(reader.GetString("status"));

            return new Vaga(id_vaga, numero_vaga, tipoVaga, tipoStatus);
        }
    }
}
