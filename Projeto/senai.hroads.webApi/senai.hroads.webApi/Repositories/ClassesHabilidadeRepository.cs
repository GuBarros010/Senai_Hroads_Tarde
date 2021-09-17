using senai.hroads.webApi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;

namespace senai.hroads.webApi.Repositories
{
    public class ClassesHabilidadeRepository : IClassesHabilidadesRepository

    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idClassesHabilidades, int idClasse, int idHabilidade, ClassesHabilidade ClassesHabilidadeAtualizado)
        {
            ClassesHabilidade ClassesHabilidadeBuscado = ctx.ClassesHabilidades.Find(idClassesHabilidades);

            if (ClassesHabilidadeAtualizado.IdClasse != null)
            {
                ClassesHabilidadeBuscado.IdClasse = ClassesHabilidadeAtualizado.IdClasse;

                ctx.ClassesHabilidades.Update(ClassesHabilidadeBuscado);

                ctx.SaveChanges();
            }

            if (ClassesHabilidadeAtualizado.IdHabilidade != null)
            {
                ClassesHabilidadeBuscado.IdHabilidade = ClassesHabilidadeAtualizado.IdHabilidade;

                ctx.ClassesHabilidades.Update(ClassesHabilidadeBuscado);

                ctx.SaveChanges();
            }
        }

        public ClassesHabilidade BuscarPorId(int idClassesHabilidade)
        {
            return ctx.ClassesHabilidades.FirstOrDefault(e => e.IdClassesHabilidades == idClassesHabilidade);
        }

        public void Cadastrar(ClassesHabilidade novoClassesHabilidade)
        {
            ctx.ClassesHabilidades.Add(novoClassesHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int idClassesHabilidade)
        {
            ctx.ClassesHabilidades.Remove(BuscarPorId(idClassesHabilidade));
            ctx.SaveChanges();
        }

        public List<ClassesHabilidade> Listar()
        {
            return ctx.ClassesHabilidades.ToList();
        }
    }
}
