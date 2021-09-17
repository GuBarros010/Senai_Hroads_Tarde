using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idClasse, Classe ClasseAtualizado)
        {
            Classe classeBuscado = ctx.Classes.Find(idClasse);

            if (ClasseAtualizado.NomeClasse != null)
            {
                classeBuscado.NomeClasse = ClasseAtualizado.NomeClasse;

                ctx.Classes.Update(classeBuscado);

                ctx.SaveChanges();
            }
        }

        public Classe BuscarPorId(int idClasse)
        {
            return ctx.Classes.FirstOrDefault(e => e.IdClasse == idClasse);
        }

        public void Cadastrar(Classe novoClasse)
        {
            ctx.Classes.Add(novoClasse);
            ctx.SaveChanges();
        }

        public void Deletar(int idClasse)
        {
            ctx.Classes.Remove(BuscarPorId(idClasse));
            ctx.SaveChanges();
        }

        public List<Classe> Listar()
        {
            return ctx.Classes.ToList();
        }

    }
}
