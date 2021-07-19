using senai_lovePets_webApi.Contexts;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class DonoRepository : IDonoRepository
    {
        lovePetsContext ctx = new lovePetsContext();

        public void Atualizar(int idDono, Dono donoAtualizado)
        {
            Dono donoBuscar = BuscarPorId(idDono);

            if (donoAtualizado.NomeDono != null)
            {
                donoBuscar.NomeDono = donoAtualizado.NomeDono;
            }
        }

        public Dono BuscarPorId(int idDono)
        {
            return ctx.Dono.Find(idDono);
        }

        public void Cadastrar(Dono novoDono)
        {
            ctx.Dono.Add(novoDono);

            ctx.SaveChanges();
        }

        public void Deletar(int idDono)
        {
            ctx.Dono.Remove(BuscarPorId(idDono));

            ctx.SaveChanges();
        }

        public List<Dono> ListarTodos()
        {
            return ctx.Dono.ToList();
        }
    }
};
