using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada)
        {
            TipoHabilidade TipoHabilidadeBuscada = ctx.TipoHabilidades.Find(idTipoHabilidade);

            if (TipoHabilidadeAtualizada.NomeTipo != null)
            {
                TipoHabilidadeBuscada.NomeTipo = TipoHabilidadeAtualizada.NomeTipo;

                ctx.TipoHabilidades.Update(TipoHabilidadeBuscada);

                ctx.SaveChanges();
            }
        }

        public TipoHabilidade BuscarPorId(int idTipoHabilidade)
        {
            return ctx.TipoHabilidades.FirstOrDefault(e => e.IdTipoHabilidade == idTipoHabilidade);
        }

        public void Cadastrar(TipoHabilidade novaTipoHabilidade)
        {
            ctx.TipoHabilidades.Add(novaTipoHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int idTipoHabilidade)
        {
            ctx.TipoHabilidades.Remove(BuscarPorId(idTipoHabilidade));
            ctx.SaveChanges();
        }

        public List<TipoHabilidade> Listar()
        {
            return ctx.TipoHabilidades.ToList();
        }
    }
}
