using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idHabilidade, Habilidade HabilidadeAtualizada)
        {
            Habilidade HabilidadeBuscada = ctx.Habilidades.Find(idHabilidade);

            if (HabilidadeAtualizada.NomeHabilidade != null)
            {
                HabilidadeBuscada.NomeHabilidade = HabilidadeAtualizada.NomeHabilidade;

                ctx.Habilidades.Update(HabilidadeBuscada);

                ctx.SaveChanges();
            }
        }

        public Habilidade BuscarPorId(int idHabilidade)
        {
            return ctx.Habilidades.FirstOrDefault(e => e.IdHabilidade == idHabilidade);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Add(novaHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int idHabilidade)
        {
            ctx.Habilidades.Remove(BuscarPorId(idHabilidade));
            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades.ToList();
        }
    }
}
