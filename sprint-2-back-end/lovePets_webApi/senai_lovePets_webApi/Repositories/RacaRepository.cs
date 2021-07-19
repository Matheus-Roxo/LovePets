using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class RacaRepository : IRacaRepository
    {
        public void Atualizar(int idRaca, Raca RacaAtualizada)
        {
            Raca racaBuscar = BuscarPorId(idRaca);

            if (RacaAtualizada.NomeRaca != null)
            {
               racaBuscar.NomeRaca = RacaAtualizada.NomeRaca;
            }
        }

        public Raca BuscarPorId(int idRaca)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Raca novaRaca)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idRaca)
        {
            throw new NotImplementedException();
        }

        public List<Raca> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
